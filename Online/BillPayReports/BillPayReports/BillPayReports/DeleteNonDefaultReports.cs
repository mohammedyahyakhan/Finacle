/*
 * Created by Ranorex
 * User: rthompson
 * Date: 4/2/2019
 * Time: 11:44 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Data;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace BillPayReports
{
    /// <summary>
    /// Description of test.
    /// </summary>
    [TestModule("9C61734B-5AA7-4243-8766-2F1D4CD1105D", ModuleType.UserCode, 1)]
    public class DeleteNonDefaultReports : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteNonDefaultReports()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            // Initialize runtime variables.
            var billPayReportsRepository = BillPayReportsRepository.Instance;
            var selectReportsDropdown = billPayReportsRepository.EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown;  
			
			// Capture all the reports in the list.      
			var allReports = new List<string>();
            var reportSpanTagAdapters = billPayReportsRepository.EasternOnlineBankingBillPay.ReportsTabPage.BillPayReportsList.NonDefaultReportsInfo.CreateAdapters<Ranorex.SpanTag>();
            foreach (var reportAdapter in reportSpanTagAdapters)
        	{
        		var elementName = reportAdapter.Element.GetAttributeValueText("innertext");
        		allReports.Add(elementName);            		
        	}
            
            // Apply the regex and filter to a new list of non-default reports, if any exist.
            // This regex will do a reverse pattern match against all of the default report options. 
            var defaultReportRegex = new Regex(@"^((?!Current Month|Include All Dates|Last \d+ \w+).)*$");
            var nonDefaultReports = allReports.Where(report => defaultReportRegex.IsMatch(report)).ToList();
            
            // If non-default reports exist, delete them.
            if (nonDefaultReports.Count > 0)
            {
            	Report.Info("There are " + nonDefaultReports.Count + " reports to be deleted.");

            	for (var i = 0; i < nonDefaultReports.Count; i++)
            	{
            		selectReportsDropdown.Self.PerformClick();
            		var index =  nonDefaultReports.ElementAt(i);
            		DivTag reportDivTag = "/dom[@domain~'fnclmob.']//div[@id='defReportBill']//div[@class='account-type']//span[@innertext='"+index+"']/..";
					
            		reportDivTag.PerformClick();
            		var billPayReportLoadingModal = billPayReportsRepository.EasternOnlineBankingBillPay.BillPayReportLoadingModal;
            		billPayReportsRepository.EasternOnlineBankingBillPay.BillPayReportLoadingModalInfo.WaitForAttributeEqual(30000,"Visible","False");
            		
            		var deleteButton = billPayReportsRepository.EasternOnlineBankingBillPay.ReportsTabPage.DeleteButton;
            		deleteButton.PerformClick();
            		var yesButton = billPayReportsRepository.EasternOnlineBankingBillPay.AreYouSureYouWantToDeleteReportModal.YesButton;
            		yesButton.PerformClick();
            		billPayReportsRepository.EasternOnlineBankingBillPay.BillPayReportLoadingModalInfo.WaitForAttributeEqual(30000,"Visible","True");
            		var deleteReportSuccessModal = billPayReportsRepository.EasternOnlineBankingBillPay.DeleteReportSuccessModal;
            		billPayReportsRepository.EasternOnlineBankingBillPay.DeleteReportSuccessModal.SelfInfo.WaitForAttributeEqual(30000,"Visible","True");
            		billPayReportsRepository.EasternOnlineBankingBillPay.BillPayReportLoadingModalInfo.WaitForAttributeEqual(30000,"Visible","False");
            		var doneButton = billPayReportsRepository.EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButton;
            		doneButton.PerformClick();
            		Delay.Seconds(1);    		
            	}
            	
            	Report.Info("All non-default reports have been deleted.");
            }
        }
    }
}

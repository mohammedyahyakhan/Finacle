/*
 * Created by Ranorex
 * User: ykhan
 * Date: 3/1/2019
 * Time: 3:35 PM
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
using Ranorex.Core.Repository;
using Ranorex.Core.Data;
using Ranorex.Core.Testing;

namespace EasternBankRegression.Module_Code
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class GeneralLibrary
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PickLastWeekDay()
        {
        	string todaydate = System.DateTime.Now.Day.ToString();
            Report.Info(todaydate);
            string lastweekday = System.DateTime.Today.AddDays(-7).Day.ToString();
            Report.Info(lastweekday);
            ButtonTag lastweekdaybtn = "/dom[@domain~'fnclmob(qa|stg).easternbank.com.*']//td[@id~'datepicker']//span[@innertext='"+lastweekday+"']/..";
            lastweekdaybtn.Click();
        
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PickJan1(RepoItemInfo datetaginfo)
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	datetaginfo.FindAdapter<InputTag>().Click();
        	
        	//string PrevDate = System.DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
        	Delay.Seconds(1);
        	Keyboard.Press("Jan 01, 2019");
        	Delay.Seconds(1);
//        	ButtonTag monthheader = "/dom[@domain~'fnclmob(qa|stg).easternbank.com.*']//div[#'fromDateAutoPaymentCreate']/table/thead//tr//th/buttontag[@id~'datepicker-\\d+-\\d+-title']";
//        	monthheader.Click();
//			ButtonTag month = "/dom[@domain~'fnclmob(qa|stg).easternbank.com.*']//div[#'fromDateAutoPaymentCreate']/?/?/tbody//span[@innertext~'January']/..";
//			month.Click();
			//dateinfo.FindAdapter<ButtonTag>().Click();
        }
        
      
       /// <summary>
       /// This is a placeholder text. Please describe the purpose of the
       /// user code method here. The method is published to the user code library
       /// within a user code collection.
       /// </summary>
        public static void todaydate(RepoItemInfo inputtagInfo)
        {
            inputtagInfo.FindAdapter<InputTag>().Click();
        	string today = System.DateTime.Today.Date.ToString("MM/dd/yyyy");
            
            Keyboard.Press(today);    
        }
        
        public static void futuredate(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "SetInputValue", "Set input value by clicking into it, clear existing and type value", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click(System.Windows.Forms.MouseButtons.Left);
            string today = System.DateTime.Today.DayOfWeek.ToString();
            Report.Info(System.DateTime.Today.DayOfWeek.ToString());
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'inputtagInfo'.", inputtagInfo);
            Keyboard.PrepareFocus(inputtagInfo.FindAdapter<InputTag>());
            Delay.Seconds(1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            if (today == "Friday") {
                string fromfriday = System.DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                inputtagInfo.FindAdapter<InputTag>().PressKeys(fromfriday);
            }
            else if (today == "Saturday") {
                string fromsaturday = System.DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                inputtagInfo.FindAdapter<InputTag>().PressKeys(fromsaturday);
            }
            else{
                string monday = System.DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                inputtagInfo.FindAdapter<InputTag>().PressKeys(monday);
            }
        }
        
        /// <summary>
        /// this method will check if there are any pending payments in the container that are delete eligible.
        /// if true, deletes them.
        /// </summary>
        [UserCodeMethod]
        public static void cleanubillpay()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	if (repo.ApplicationUnderTest.cleanup.pendingpaydeletecontainerInfo.Exists()) {
        
        		IList<Ranorex.SpanTag> deletelist = repo.ApplicationUnderTest.cleanup.pendingpaydeletecontainerInfo.CreateAdapters<Ranorex.SpanTag>();
        		Report.Info("there are : "+deletelist.Count+"  delete buttons in the container");
        		foreach (Ranorex.SpanTag item in deletelist) {
        			Report.Info("clicking on the delete button");
        			item.Element.Focus();
        			item.PressKeys("{enter}");
                    repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeleteThisPaymentPendingPaymentsInfo.WaitForAttributeContains(15000, "Enabled", "True");
        			var deleteThisPayment = repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.DeleteThisPayment;
        			deleteThisPayment.Click();

        		}	
        	}
        	else {
        		Report.Info("there are no delete buttons in the container");
        	}

        }

        /// <summary>
        /// This method will check for any inactive payees and delete them
        /// </summary>
        [UserCodeMethod]
        public static void deleteinactivepayees()
        {
        	var repo = EasternBankRegressionRepository.Instance;

        	if (repo.ApplicationUnderTest.cleanup.exAInfo.Exists()) {
        		Report.Info("an inacive payee exists");
        		Report.Info("clicking on name of inactive payee");
        		repo.ApplicationUnderTest.cleanup.exA.Click();
        		var deleteincativepayee = repo.ApplicationUnderTest.cleanup.deleteincativepayee;
        		deleteincativepayee.Click();
        		var yesToConfirm = repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeactivatePayee.YesToConfirm;
        		yesToConfirm.Click();
        		repo.ApplicationUnderTest.cleanup.donebutnsuccessmodalInfo.WaitForAttributeContains(20000, "Enabled", "True");
        		repo.ApplicationUnderTest.cleanup.donebutnsuccessmodal.Click();
        	}
        	else {
        		Report.Info("there are no inactive payees available");
        	}

        }
        
        /// <summary>
        /// this method will delete bill remainders if any exists
        /// </summary>
        [UserCodeMethod]
        public static void deletebillremainder()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	if (repo.ApplicationUnderTest.cleanup.billremaindernameInfo.Exists()) {

        		Report.Info("there is a bill remainder present on the page");
        		var deleteBillReminder = repo.ApplicationUnderTest.MajorModules.BillPay_Sub.NotificationsTab.DeleteBillReminder;
        		deleteBillReminder.Click();
        		var deleteremainderyesbtn = repo.ApplicationUnderTest.cleanup.deleteremainderyesbtn;
        		deleteremainderyesbtn.Click();
        	}
        	else {
        		Report.Info("there are no bill remainders");
        	}
        }

        /// <summary>
        /// this method will delete existing reports of ------- if exists any
        /// </summary>
        [UserCodeMethod]
        public static void DeleteExistingReport()
        {
			var repo = EasternBankRegressionRepository.Instance;
			// Capture all the reports in the list.      
			if (repo.ApplicationUnderTest.cleanup.existingreportInfo.Exists()) {
				Report.Info("there is an existing report");
				repo.ApplicationUnderTest.cleanup.existingreport.Click();
				Delay.Seconds(20);
                repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsInfo.WaitForAttributeContains(20000, "Enabled", "True");
				var delete = repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.Delete;
				delete.Click();
				var yes = repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.DeleteSub.Yes;
				yes.Click();
				Delay.Seconds(10);
				var donebutnsuccessmodal = repo.ApplicationUnderTest.cleanup.donebutnsuccessmodal;
				donebutnsuccessmodal.Click();

			}
			else {
				Report.Info("there is no existing report");
			}

        }


        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TodaysDate(RepoItemInfo datetaginfo)
        { 
        	var repo = EasternBankRegressionRepository.Instance;
        	datetaginfo.FindAdapter<InputTag>().Click();
        	
        	string today = System.DateTime.Now.ToString("MMM dd, yyyy");
        	
        	Delay.Seconds(1);
        	Keyboard.Press(today);
        	Delay.Seconds(1);
			
        	
             

        }

        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void Currentdate()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	
        	
        	string today = System.DateTime.Now.ToString("MMM dd, yyyy");
        	
        	Delay.Seconds(1);
        	Keyboard.Press(today);
        	Delay.Seconds(1);
        }
  
        
        
    }
    }

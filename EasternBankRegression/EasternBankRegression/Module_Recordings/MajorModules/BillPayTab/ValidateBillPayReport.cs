﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace EasternBankRegression.Module_Recordings.MajorModules.BillPayTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateBillPayReport recording.
    /// </summary>
    [TestModule("43a70f9b-1ab5-48da-9019-3a24f7967aa8", ModuleType.Recording, 1)]
    public partial class ValidateBillPayReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static ValidateBillPayReport instance = new ValidateBillPayReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateBillPayReport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateBillPayReport Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.BillPay'.", repo.EasternOnlineBankingDashboard.BillPayInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.BillPay.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.BillPayTabLoadingModal'.", repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.BillPayTabLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.BillPayTabLoadingModal'", repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.BillPayTabs.ReportsTab'.", repo.EasternOnlineBankingBillPay.BillPayTabs.ReportsTabInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingBillPay.BillPayTabs.ReportsTab.PerformClick();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.BillPayReportLoadingModal'", repo.EasternOnlineBankingDashboard.BillPayReportLoadingModalInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.BillPayReportLoadingModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown'", repo.EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown.SelfInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown.SelfInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ReportDropdown1'.", repo.EasternOnlineBankingDashboard.ReportDropdown1Info, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.ReportDropdown1.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Last12MonthsReport'.", repo.EasternOnlineBankingDashboard.Last12MonthsReportInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.Last12MonthsReport.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.Create_Report_Button'.", repo.EasternOnlineBankingDashboard.Create_Report_ButtonInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.Create_Report_ButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditReportButtonBillPay'.", repo.EasternOnlineBankingDashboard.EditReportButtonBillPayInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditReportButtonBillPayInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteReportButtonBillPay'.", repo.EasternOnlineBankingDashboard.DeleteReportButtonBillPayInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteReportButtonBillPayInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PrintButton'.", repo.EasternOnlineBankingDashboard.PrintButtonInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PrintButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SentOn'.", repo.EasternOnlineBankingDashboard.SentOnInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SentOnInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaidTo'.", repo.EasternOnlineBankingDashboard.PaidToInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaidToInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.Amount'.", repo.EasternOnlineBankingDashboard.AmountInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AmountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaidFrom'.", repo.EasternOnlineBankingDashboard.PaidFromInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaidFromInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.Status'.", repo.EasternOnlineBankingDashboard.StatusInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StatusInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmationHash'.", repo.EasternOnlineBankingDashboard.ConfirmationHashInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmationHashInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.GrandTotal'.", repo.EasternOnlineBankingDashboard.GrandTotalInfo, new RecordItemIndex(20));
            Validate.Exists(repo.EasternOnlineBankingDashboard.GrandTotalInfo, null, new Validate.Options(){ReportLevelOnFailure=ReportLevel.Info});
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

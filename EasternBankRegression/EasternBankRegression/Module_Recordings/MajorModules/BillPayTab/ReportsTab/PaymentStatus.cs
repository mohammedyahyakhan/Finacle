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

namespace EasternBankRegression.Module_Recordings.MajorModules.BillPayTab.ReportsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PaymentStatus recording.
    /// </summary>
    [TestModule("47903302-4baf-48f6-b2bc-1bb9efe3362d", ModuleType.Recording, 1)]
    public partial class PaymentStatus : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static PaymentStatus instance = new PaymentStatus();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PaymentStatus()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PaymentStatus Instance
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.BillPayReportLoadingModal'", repo.EasternOnlineBankingDashboard.BillPayReportLoadingModalInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.BillPayReportLoadingModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.ReportsTabPage.CreateReportButton'.", repo.EasternOnlineBankingBillPay.ReportsTabPage.CreateReportButtonInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingBillPay.ReportsTabPage.CreateReportButton.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ReportTitleInputBox'.", repo.EasternOnlineBankingDashboard.ReportTitleInputBoxInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingDashboard.ReportTitleInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'abcdefghijklmnopqrstuvwxyz1234567890123456789012' with focus on 'EasternOnlineBankingDashboard.ReportTitleInputBox'.", repo.EasternOnlineBankingDashboard.ReportTitleInputBoxInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.ReportTitleInputBox.PressKeys("abcdefghijklmnopqrstuvwxyz1234567890123456789012");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ClearedCheckbox'.", repo.EasternOnlineBankingDashboard.ClearedCheckboxInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.ClearedCheckbox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SelectAllFundingAccountsCheckbox'.", repo.EasternOnlineBankingDashboard.SelectAllFundingAccountsCheckboxInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.SelectAllFundingAccountsCheckbox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SelectAllPayeesCheckbox'.", repo.EasternOnlineBankingDashboard.SelectAllPayeesCheckboxInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.SelectAllPayeesCheckbox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CreateReportButton4'.", repo.EasternOnlineBankingDashboard.CreateReportButton4Info, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.CreateReportButton4.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.PleaseWaitModal'", repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo, new RecordItemIndex(13));
            repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo.WaitForAttributeEqual(3000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.PleaseWaitModal'", repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.DeleteReportSuccessModal.SuccessHeader'.", repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.SuccessHeaderInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.SuccessHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.DeleteReportSuccessModal.SuccessMessage'.", repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.SuccessMessageInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.SuccessMessageInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButton'.", repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButtonInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(18));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButton'.", repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButtonInfo, new RecordItemIndex(19));
            repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.EditSub.Selectabcdereport'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.EditSub.SelectabcdereportInfo, new RecordItemIndex(20));
            Validate.Exists(repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.EditSub.SelectabcdereportInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown'", repo.EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown.SelfInfo, new RecordItemIndex(21));
            repo.EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown.SelfInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.BillPayTabLoadingModal'.", repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo, new RecordItemIndex(22));
            repo.EasternOnlineBankingDashboard.BillPayTabLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(23));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown'.", repo.EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown.SelfInfo, new RecordItemIndex(24));
            repo.EasternOnlineBankingBillPay.ReportsTabPage.SelectReportDropdown.Self.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.EditSub.Selectabcdereport' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.EditSub.SelectabcdereportInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.EditSub.Selectabcdereport.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(26));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.PleaseWaitModal'", repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo, new RecordItemIndex(27));
            repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.ReportsTabPage.DeleteButton'.", repo.EasternOnlineBankingBillPay.ReportsTabPage.DeleteButtonInfo, new RecordItemIndex(28));
            repo.EasternOnlineBankingBillPay.ReportsTabPage.DeleteButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingBillPay.AreYouSureYouWantToDeleteReportModal'", repo.EasternOnlineBankingBillPay.AreYouSureYouWantToDeleteReportModal.SelfInfo, new RecordItemIndex(29));
            repo.EasternOnlineBankingBillPay.AreYouSureYouWantToDeleteReportModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.AreYouSureYouWantToDeleteReportModal.YesButton'.", repo.EasternOnlineBankingBillPay.AreYouSureYouWantToDeleteReportModal.YesButtonInfo, new RecordItemIndex(30));
            repo.EasternOnlineBankingBillPay.AreYouSureYouWantToDeleteReportModal.YesButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingBillPay.DeleteReportSuccessModal'", repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.SelfInfo, new RecordItemIndex(31));
            repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.SelfInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.PleaseWaitModal'", repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo, new RecordItemIndex(32));
            repo.EasternOnlineBankingDashboard.PleaseWaitModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButton'.", repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButtonInfo, new RecordItemIndex(33));
            repo.EasternOnlineBankingBillPay.DeleteReportSuccessModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

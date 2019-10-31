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
    ///The DeactivateReactivatePayee recording.
    /// </summary>
    [TestModule("32753c90-17e0-41ff-ae8c-61673ad6b05e", ModuleType.Recording, 1)]
    public partial class DeactivateReactivatePayee : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static DeactivateReactivatePayee instance = new DeactivateReactivatePayee();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeactivateReactivatePayee()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeactivateReactivatePayee Instance
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
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.BillPayTab'.", repo.EasternOnlineBankingDashboard.BillPayTabInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.BillPayTab.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.BillPayTabLoadingModal'.", repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.BillPayTabLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.BillPayTabLoadingModal'", repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.AaaTestPayee'", repo.EasternOnlineBankingDashboard.AaaTestPayeeInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.AaaTestPayeeInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.AaaTestPayee'.", repo.EasternOnlineBankingDashboard.AaaTestPayeeInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingDashboard.AaaTestPayee.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.PayeeOptionsDropdown'.", repo.EasternOnlineBankingDashboard.PayeeOptionsDropdown.SelfInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.PayeeOptionsDropdown.Self.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.PayeeOptionsDropdown.DeactivatePayee' at Center.", repo.EasternOnlineBankingDashboard.PayeeOptionsDropdown.DeactivatePayeeInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.PayeeOptionsDropdown.DeactivatePayee.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DeactivatePayeeModal'", repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.SelfInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.SelfInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatePayeeModal.AreYouSureYouWantToDeactivatePayee'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.AreYouSureYouWantToDeactivatePayeeInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.AreYouSureYouWantToDeactivatePayeeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatePayeeModal.AllPendingPaymentsRemindersAndNot'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.AllPendingPaymentsRemindersAndNotInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.AllPendingPaymentsRemindersAndNotInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatePayeeModal.CancelButton'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.CancelButtonInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.CancelButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatePayeeModal.YesButton'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.YesButtonInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.YesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DeactivatePayeeModal.YesButton'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.YesButtonInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.DeactivatePayeeModal.YesButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal'", repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.SelfInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.SelfInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.SuccessHeader'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.SuccessHeaderInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.SuccessHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DeactivateMsg'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DeactivateMsgInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DeactivateMsgInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DoneButtonInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DoneButtonInfo, new RecordItemIndex(20));
            repo.EasternOnlineBankingDashboard.DeactivatePayeeSuccessModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ShowSortDropdown1'.", repo.EasternOnlineBankingDashboard.ShowSortDropdown1Info, new RecordItemIndex(21));
            repo.EasternOnlineBankingDashboard.ShowSortDropdown1.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ShowSortDropdown.ActivePayeesOnly'.", repo.EasternOnlineBankingDashboard.ShowSortDropdown.ActivePayeesOnlyInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ShowSortDropdown.ActivePayeesOnlyInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ShowSortDropdown.InactivePayeesOnly'.", repo.EasternOnlineBankingDashboard.ShowSortDropdown.InactivePayeesOnlyInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ShowSortDropdown.InactivePayeesOnlyInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ShowSortDropdown.InactivePayeesOnly'.", repo.EasternOnlineBankingDashboard.ShowSortDropdown.InactivePayeesOnlyInfo, new RecordItemIndex(24));
            repo.EasternOnlineBankingDashboard.ShowSortDropdown.InactivePayeesOnly.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatedAaaTestPayee'.", repo.EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.SelfInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.Reactivate'.", repo.EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.ReactivateInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.ReactivateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.Reactivate'.", repo.EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.ReactivateInfo, new RecordItemIndex(27));
            repo.EasternOnlineBankingDashboard.DeactivatedAaaTestPayee.Reactivate.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.ReactivateSuccessModal'", repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.SelfInfo, new RecordItemIndex(28));
            repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.SelfInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReactivateSuccessModal.ReactivateSuccessCaption'.", repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.ReactivateSuccessCaptionInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.ReactivateSuccessCaptionInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReactivateSuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.DoneButtonInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ReactivateSuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.DoneButtonInfo, new RecordItemIndex(31));
            repo.EasternOnlineBankingDashboard.ReactivateSuccessModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ShowSortDropdown'.", repo.EasternOnlineBankingDashboard.ShowSortDropdown.SelfInfo, new RecordItemIndex(32));
            repo.EasternOnlineBankingDashboard.ShowSortDropdown.Self.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ShowSortDropdown.ActivePayeesOnly'.", repo.EasternOnlineBankingDashboard.ShowSortDropdown.ActivePayeesOnlyInfo, new RecordItemIndex(33));
            repo.EasternOnlineBankingDashboard.ShowSortDropdown.ActivePayeesOnly.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.AaaTestPayee'", repo.EasternOnlineBankingDashboard.AaaTestPayeeInfo, new RecordItemIndex(34));
            repo.EasternOnlineBankingDashboard.AaaTestPayeeInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

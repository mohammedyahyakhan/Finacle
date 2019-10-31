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
    ///The ScheduledPaymentsCreationDeletion recording.
    /// </summary>
    [TestModule("86f46547-3aa7-4db0-9350-ca819c20fa56", ModuleType.Recording, 1)]
    public partial class ScheduledPaymentsCreationDeletion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static ScheduledPaymentsCreationDeletion instance = new ScheduledPaymentsCreationDeletion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScheduledPaymentsCreationDeletion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ScheduledPaymentsCreationDeletion Instance
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AmountInputBox'.", repo.EasternOnlineBankingDashboard.AmountInputBoxInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AmountInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '99999' on item 'EasternOnlineBankingDashboard.AmountInputBox'.", repo.EasternOnlineBankingDashboard.AmountInputBoxInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.AmountInputBox.Element.SetAttributeValue("TagValue", "99999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.PayButton'.", repo.EasternOnlineBankingDashboard.PayButtonInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.PayButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.MaxLimitExceededError'", repo.EasternOnlineBankingDashboard.MaxLimitExceededErrorInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.MaxLimitExceededErrorInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '20' on item 'EasternOnlineBankingDashboard.AmountInputBox'.", repo.EasternOnlineBankingDashboard.AmountInputBoxInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingDashboard.AmountInputBox.Element.SetAttributeValue("TagValue", "20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.PayButton'.", repo.EasternOnlineBankingDashboard.PayButtonInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.PayButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal'", repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.SelfInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.SelfInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.AaaTestPayee'.", repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.AaaTestPayeeInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.AaaTestPayeeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.N20Dollars'.", repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.N20DollarsInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.N20DollarsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.PrintButton'.", repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.PrintButtonInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.PrintButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.DoneButton'.", repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.DoneButtonInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.BillPayTabLoadingModal'", repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.BillPayTabLoadingModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.DoneButton'.", repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.DoneButtonInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.PaymentSuccesfullyScheduledModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ScheduledTab'.", repo.EasternOnlineBankingDashboard.ScheduledTabInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.ScheduledTab.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.ScheduledTabLoadingModal'.", repo.EasternOnlineBankingDashboard.ScheduledTabLoadingModalInfo, new RecordItemIndex(17));
            repo.EasternOnlineBankingDashboard.ScheduledTabLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.ScheduledTabLoadingModal'", repo.EasternOnlineBankingDashboard.ScheduledTabLoadingModalInfo, new RecordItemIndex(18));
            repo.EasternOnlineBankingDashboard.ScheduledTabLoadingModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment'.", repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.SelfInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.EditPaymentButton'.", repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.EditPaymentButtonInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.EditPaymentButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.DeletePaymentButton'.", repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.DeletePaymentButtonInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.DeletePaymentButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.OneTime'.", repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.OneTimeInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.OneTimeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.EditPaymentButton'.", repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.EditPaymentButtonInfo, new RecordItemIndex(23));
            repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.EditPaymentButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.EditThisPaymentModal'", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SelfInfo, new RecordItemIndex(24));
            repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SelfInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.To'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.ToInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.ToInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.PayFrom'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.PayFromInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.PayFromInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.PayFromDropdown'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.PayFromDropdownInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.PayFromDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.AvailableBalance'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AvailableBalanceInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AvailableBalanceInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBox'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBoxInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.SendOnDate'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SendOnDateInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SendOnDateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.CalendarDropdown'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.CalendarDropdownInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.CalendarDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.DeliverBy'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.DeliverByInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.DeliverByInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.MemoInputBox'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.MemoInputBoxInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.MemoInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.CancelButton'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.CancelButtonInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.CancelButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButton'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButtonInfo, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '0' on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBox'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBoxInfo, new RecordItemIndex(36));
            repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBox.Element.SetAttributeValue("TagValue", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButton'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButtonInfo, new RecordItemIndex(37));
            repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.CorrectFollowingFieldsError'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.CorrectFollowingFieldsErrorInfo, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.CorrectFollowingFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.YouMustEnterAnAmountError'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.YouMustEnterAnAmountErrorInfo, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditThisPaymentModal.YouMustEnterAnAmountErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '30' on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBox'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBoxInfo, new RecordItemIndex(40));
            repo.EasternOnlineBankingDashboard.EditThisPaymentModal.AmountInputBox.Element.SetAttributeValue("TagValue", "30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButton'.", repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButtonInfo, new RecordItemIndex(41));
            repo.EasternOnlineBankingDashboard.EditThisPaymentModal.SaveButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal'", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.SelfInfo, new RecordItemIndex(42));
            repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.SelfInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.To'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.ToInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.ToInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.From'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.FromInfo, new RecordItemIndex(44));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.FromInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.Amount'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.AmountInfo, new RecordItemIndex(45));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.AmountInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.SendOn'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.SendOnInfo, new RecordItemIndex(46));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.SendOnInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DeliverBy'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DeliverByInfo, new RecordItemIndex(47));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DeliverByInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.ConfirmationNumber'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.ConfirmationNumberInfo, new RecordItemIndex(48));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.ConfirmationNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.PrintButton'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.PrintButtonInfo, new RecordItemIndex(49));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.PrintButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DoneButton'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DoneButtonInfo, new RecordItemIndex(50));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DoneButton'.", repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DoneButtonInfo, new RecordItemIndex(51));
            repo.EasternOnlineBankingDashboard.PaymentSuccessfullyUpdatedModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.DeletePaymentButton'.", repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.DeletePaymentButtonInfo, new RecordItemIndex(52));
            repo.EasternOnlineBankingDashboard.AaaTestPayeeScheduledPayment.DeletePaymentButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DeleteThisPaymentModal'", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.SelfInfo, new RecordItemIndex(53));
            repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.SelfInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteThisPaymentHeader'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteThisPaymentHeaderInfo, new RecordItemIndex(54));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteThisPaymentHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.AreYouSureYouWantToDeleteThisPayment'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.AreYouSureYouWantToDeleteThisPaymentInfo, new RecordItemIndex(55));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.AreYouSureYouWantToDeleteThisPaymentInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.To'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.ToInfo, new RecordItemIndex(56));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.ToInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.AaaTestPayee'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.AaaTestPayeeInfo, new RecordItemIndex(57));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.AaaTestPayeeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.From'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.FromInfo, new RecordItemIndex(58));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.FromInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.Amount'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.AmountInfo, new RecordItemIndex(59));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.AmountInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.N30Dollars'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.N30DollarsInfo, new RecordItemIndex(60));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.N30DollarsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.Frequency'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.FrequencyInfo, new RecordItemIndex(61));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.FrequencyInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.OneTime'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.OneTimeInfo, new RecordItemIndex(62));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.OneTimeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.SendOnDate'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.SendOnDateInfo, new RecordItemIndex(63));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.SendOnDateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.Date'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DateInfo, new RecordItemIndex(64));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.ConfirmationNumber'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.ConfirmationNumberInfo, new RecordItemIndex(65));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.ConfirmationNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.CancelButton'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.CancelButtonInfo, new RecordItemIndex(66));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.CancelButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteButton'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteButtonInfo, new RecordItemIndex(67));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteButton'.", repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteButtonInfo, new RecordItemIndex(68));
            repo.EasternOnlineBankingDashboard.DeleteThisPaymentModal.DeleteButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DeletePaymentSuccessModal'", repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.SelfInfo, new RecordItemIndex(69));
            repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.SelfInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeletePaymentSuccessModal.YouHaveDeletedYourPayments'.", repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.YouHaveDeletedYourPaymentsInfo, new RecordItemIndex(70));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.YouHaveDeletedYourPaymentsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DeletePaymentSuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.DoneButtonInfo, new RecordItemIndex(71));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DeletePaymentSuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.DoneButtonInfo, new RecordItemIndex(72));
            repo.EasternOnlineBankingDashboard.DeletePaymentSuccessModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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

namespace Transfersv2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InternalTransfersErrorValidation recording.
    /// </summary>
    [TestModule("7aa53fcd-2fed-4eda-a2c5-6066eba1cd39", ModuleType.Recording, 1)]
    public partial class InternalTransfersErrorValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TransfersRepository repository.
        /// </summary>
        public static TransfersRepository repo = TransfersRepository.Instance;

        static InternalTransfersErrorValidation instance = new InternalTransfersErrorValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InternalTransfersErrorValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InternalTransfersErrorValidation Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.CorrectTheFollowingFieldsError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.CorrectTheFollowingFieldsErrorInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.CorrectTheFollowingFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidToAccountError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidToAccountErrorInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidToAccountErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.AmountError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.AmountErrorInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.AmountErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdownInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.FrequencyList.OneTimeScheduled'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyList.OneTimeScheduledInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyList.OneTimeScheduled.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButtonInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.TransferOnDateError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.TransferOnDateErrorInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.TransferOnDateErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdownInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.FrequencyList.Weekly'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyList.WeeklyInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyList.Weekly.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.EndOnDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.EndOnDropdownInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.EndOnDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.EndTransfersList.EndAfterNumberOfTransfers'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.EndTransfersList.EndAfterNumberOfTransfersInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.EndTransfersList.EndAfterNumberOfTransfers.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButtonInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.EnterValidNumberOfTransfersError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.EnterValidNumberOfTransfersErrorInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.EnterValidNumberOfTransfersErrorInfo, "Valid", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.EndOnDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.EndOnDropdownInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.EndOnDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.EndTransfersList.EndOnDate'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.EndTransfersList.EndOnDateInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.EndTransfersList.EndOnDate.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButtonInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidEndDateError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidEndDateErrorInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidEndDateErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.CancelButton'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.CancelButtonInfo, new RecordItemIndex(18));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.CancelButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

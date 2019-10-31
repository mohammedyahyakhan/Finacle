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
    ///The ValidateMakeTransferScreen recording.
    /// </summary>
    [TestModule("76c0b9cf-bb12-4f15-9fd3-536b724ea97c", ModuleType.Recording, 1)]
    public partial class ValidateMakeTransferScreen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TransfersRepository repository.
        /// </summary>
        public static TransfersRepository repo = TransfersRepository.Instance;

        static ValidateMakeTransferScreen instance = new ValidateMakeTransferScreen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateMakeTransferScreen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateMakeTransferScreen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.TransferBetweenMyEBAccounts'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferBetweenMyEBAccountsInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferBetweenMyEBAccountsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.TransferFromDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferFromDropdownInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferFromDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.TransferToDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferToDropdownInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferToDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.TransferAmountInputBox'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferAmountInputBoxInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferAmountInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdownInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.FrequencyDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.ContinueButton'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.ContinueButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.CancelButton'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.CancelButtonInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.CancelButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The OneTimeScheduled_Errors recording.
    /// </summary>
    [TestModule("30caf41c-f5fa-4abd-906d-cf244b5cea94", ModuleType.Recording, 1)]
    public partial class OneTimeScheduled_Errors : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TransfersRepository repository.
        /// </summary>
        public static TransfersRepository repo = TransfersRepository.Instance;

        static OneTimeScheduled_Errors instance = new OneTimeScheduled_Errors();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OneTimeScheduled_Errors()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OneTimeScheduled_Errors Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.CorrectTheFollowingFieldsError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.CorrectTheFollowingFieldsErrorInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.CorrectTheFollowingFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidToAccountError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidToAccountErrorInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.InvalidToAccountErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.AmountError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.AmountErrorInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.AmountErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InternalTransferModal.Errors.TransferOnDateError'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.TransferOnDateErrorInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InternalTransferModal.Errors.TransferOnDateErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The EndAfterNumberOfTransfersConfirmTransferValidation recording.
    /// </summary>
    [TestModule("28314ffb-9d26-46cb-93f9-a5a4020f1aef", ModuleType.Recording, 1)]
    public partial class EndAfterNumberOfTransfersConfirmTransferValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TransfersRepository repository.
        /// </summary>
        public static TransfersRepository repo = TransfersRepository.Instance;

        static EndAfterNumberOfTransfersConfirmTransferValidation instance = new EndAfterNumberOfTransfersConfirmTransferValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EndAfterNumberOfTransfersConfirmTransferValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EndAfterNumberOfTransfersConfirmTransferValidation Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varAccount.
        /// </summary>
        [TestVariable("a2d01dad-19ce-4358-9a5d-c6e79fa94c83")]
        public string varAccount
        {
            get { return repo.varAccount; }
            set { repo.varAccount = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varToAccount.
        /// </summary>
        [TestVariable("779f7bab-424b-458f-87ba-bc4fa74a0653")]
        public string varToAccount
        {
            get { return repo.varToAccount; }
            set { repo.varToAccount = value; }
        }

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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.From'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.FromInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.FromInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.FromAccountVar'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.FromAccountVarInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.FromAccountVarInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.To'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.ToInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.ToInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.ToAccountVar'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.ToAccountVarInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.ToAccountVarInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.Frequency'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.FrequencyInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.FrequencyInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.StartOn'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.StartOnInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.StartOnInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.EndOn'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.EndOnInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.EndOnInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.Amount'.", repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.AmountInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmTransferDetailsModal.AmountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
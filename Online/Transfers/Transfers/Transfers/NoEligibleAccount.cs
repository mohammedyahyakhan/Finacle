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
    ///The NoEligibleAccount recording.
    /// </summary>
    [TestModule("e456b988-7942-4383-b19c-4146babe443e", ModuleType.Recording, 1)]
    public partial class NoEligibleAccount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TransfersRepository repository.
        /// </summary>
        public static TransfersRepository repo = TransfersRepository.Instance;

        static NoEligibleAccount instance = new NoEligibleAccount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NoEligibleAccount()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NoEligibleAccount Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TopBar.Transfers'.", repo.EasternOnlineBankingDashboard.TopBar.TransfersInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.TopBar.Transfers.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard'", repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.SelfInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.SelfInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButton'.", repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButton'.", repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButtonInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.OnlyOneAccountModal.OnlyOneAccountModalHeader'", repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.OnlyOneAccountModalHeaderInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.OnlyOneAccountModalHeaderInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OnlyOneAccountModal.OneAccountModalErrorDescription'.", repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.OneAccountModalErrorDescriptionInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.OneAccountModalErrorDescriptionInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OnlyOneAccountModal.DoneButton'.", repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.DoneButtonInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OnlyOneAccountModal.DoneButton'.", repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.DoneButtonInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingDashboard.OnlyOneAccountModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
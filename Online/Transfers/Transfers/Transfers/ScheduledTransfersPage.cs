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
    ///The ScheduledTransfersPage recording.
    /// </summary>
    [TestModule("5b2480a4-8b0c-45f8-ac15-88ceaa1c4132", ModuleType.Recording, 1)]
    public partial class ScheduledTransfersPage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TransfersRepository repository.
        /// </summary>
        public static TransfersRepository repo = TransfersRepository.Instance;

        static ScheduledTransfersPage instance = new ScheduledTransfersPage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScheduledTransfersPage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ScheduledTransfersPage Instance
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard'", repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.SelfInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.SelfInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButton'.", repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.MakeTransferButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.ViewManageScheduledTransfers'.", repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.ViewManageScheduledTransfersInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.TransfersPage.InternalTransfersCard.ViewManageScheduledTransfers.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.TransfersPage.ScheduledTransfersPage.ScheduledTransfersHeading'", repo.EasternOnlineBankingDashboard.TransfersPage.ScheduledTransfersPage.ScheduledTransfersHeadingInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.TransfersPage.ScheduledTransfersPage.ScheduledTransfersHeadingInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.TransfersPage.ScheduledTransfersPage.MakeATransferButton'.", repo.EasternOnlineBankingDashboard.TransfersPage.ScheduledTransfersPage.MakeATransferButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.TransfersPage.ScheduledTransfersPage.MakeATransferButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
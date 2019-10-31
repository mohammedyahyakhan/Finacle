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

namespace Debit_Cards_V2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditAtmDailyLimitOriginal recording.
    /// </summary>
    [TestModule("3b2f2990-5b04-4a05-b77d-d2c30327922a", ModuleType.Recording, 1)]
    public partial class EditAtmDailyLimitOriginal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DebitCardsRepository repository.
        /// </summary>
        public static DebitCardsRepository repo = DebitCardsRepository.Instance;

        static EditAtmDailyLimitOriginal instance = new EditAtmDailyLimitOriginal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditAtmDailyLimitOriginal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditAtmDailyLimitOriginal Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBox'.", repo.EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBox'.", repo.EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBoxInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBox);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, 10, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '750' with focus on 'EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBox'.", repo.EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBoxInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.SetDailyLimitModal.AtmDailyLimitInputBox.PressKeys("750", 10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBox'.", repo.EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBoxInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBox'.", repo.EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBoxInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBox);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2500' with focus on 'EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBox'.", repo.EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBoxInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.SetDailyLimitModal.TotalDailyLimitInputBox.PressKeys("2500");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

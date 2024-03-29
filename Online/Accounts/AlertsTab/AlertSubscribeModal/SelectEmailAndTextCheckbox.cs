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

namespace AccountsTestSuite.AlertsTab.AlertSubscribeModal
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectEmailAndTextCheckbox recording.
    /// </summary>
    [TestModule("0d5104a7-ea57-47e5-beed-67f60dcbea66", ModuleType.Recording, 1)]
    public partial class SelectEmailAndTextCheckbox : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static SelectEmailAndTextCheckbox instance = new SelectEmailAndTextCheckbox();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectEmailAndTextCheckbox()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectEmailAndTextCheckbox Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AlertsTab.SubscribeModal.EmailCheckbox'.", repo.EasternOnlineBankingAuthenticationSc.AlertsTab.SubscribeModal.EmailCheckboxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingAuthenticationSc.AlertsTab.SubscribeModal.EmailCheckbox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AlertsTab.SubscribeModal.TextCheckbox'.", repo.EasternOnlineBankingAuthenticationSc.AlertsTab.SubscribeModal.TextCheckboxInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingAuthenticationSc.AlertsTab.SubscribeModal.TextCheckbox.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

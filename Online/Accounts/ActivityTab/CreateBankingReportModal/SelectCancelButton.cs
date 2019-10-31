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

namespace AccountsTestSuite.ActivityTab.CreateBankingReportModal
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectCancelButton recording.
    /// </summary>
    [TestModule("286990ed-d604-4af1-8aa2-dcdcf3d02ce4", ModuleType.Recording, 1)]
    public partial class SelectCancelButton : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static SelectCancelButton instance = new SelectCancelButton();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectCancelButton()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectCancelButton Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.CreateBankingReportModal.CancelButton'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.CreateBankingReportModal.CancelButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.CreateBankingReportModal.CancelButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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

namespace BillPayTestSuite
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClickAddPersonAddPAyeeButton recording.
    /// </summary>
    [TestModule("493d91e9-74c2-4e84-be53-eb4f4cd89e3b", ModuleType.Recording, 1)]
    public partial class ClickAddPersonAddPayeeButton : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayTestSuiteRepository repository.
        /// </summary>
        public static BillPayTestSuiteRepository repo = BillPayTestSuiteRepository.Instance;

        static ClickAddPersonAddPayeeButton instance = new ClickAddPersonAddPayeeButton();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickAddPersonAddPayeeButton()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickAddPersonAddPayeeButton Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.AddPayeeModal.AddAPersonButton' at 52;5.", repo.EasternOnlineBankingDashboard.AddPayeeModal.AddAPersonButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.AddPayeeModal.AddAPersonButton.Click("52;5");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
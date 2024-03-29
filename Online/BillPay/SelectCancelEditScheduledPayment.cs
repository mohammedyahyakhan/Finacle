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
    ///The SelectCancelEditScheduledPayment recording.
    /// </summary>
    [TestModule("5fdbf8b8-b88b-44f8-b6e7-86a33cc5d567", ModuleType.Recording, 1)]
    public partial class SelectCancelEditScheduledPayment : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayTestSuiteRepository repository.
        /// </summary>
        public static BillPayTestSuiteRepository repo = BillPayTestSuiteRepository.Instance;

        static SelectCancelEditScheduledPayment instance = new SelectCancelEditScheduledPayment();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectCancelEditScheduledPayment()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectCancelEditScheduledPayment Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.EditThisAndAllFuturePaymentsModal.CancelButton'.", repo.EasternOnlineBankingDashboard.EditThisAndAllFuturePaymentsModal.CancelButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.EditThisAndAllFuturePaymentsModal.CancelButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

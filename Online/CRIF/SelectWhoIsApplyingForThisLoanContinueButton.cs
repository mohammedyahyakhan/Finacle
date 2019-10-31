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

namespace CRIF
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectWhoIsApplyingForThisLoanContinueButton recording.
    /// </summary>
    [TestModule("738a72ed-b263-4195-9e75-4e255f2be621", ModuleType.Recording, 1)]
    public partial class SelectWhoIsApplyingForThisLoanContinueButton : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static SelectWhoIsApplyingForThisLoanContinueButton instance = new SelectWhoIsApplyingForThisLoanContinueButton();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectWhoIsApplyingForThisLoanContinueButton()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectWhoIsApplyingForThisLoanContinueButton Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.ContinueButton'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.ContinueButtonInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.ContinueButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.ContinueButton'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.ContinueButtonInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.ContinueButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
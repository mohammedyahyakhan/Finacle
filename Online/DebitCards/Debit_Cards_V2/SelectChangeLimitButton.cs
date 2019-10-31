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
    ///The SelectChangeLimitButton recording.
    /// </summary>
    [TestModule("70c74ddf-125f-4d98-9a9b-5e64b6fdeab6", ModuleType.Recording, 1)]
    public partial class SelectChangeLimitButton : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DebitCardsRepository repository.
        /// </summary>
        public static DebitCardsRepository repo = DebitCardsRepository.Instance;

        static SelectChangeLimitButton instance = new SelectChangeLimitButton();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectChangeLimitButton()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectChangeLimitButton Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangeLimitButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangeLimitButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangeLimitButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Valid' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SetDailyLimitModal'", repo.EasternOnlineBankingDashboard.SetDailyLimitModal.SelfInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.SetDailyLimitModal.SelfInfo.WaitForAttributeEqual(10000, "Valid", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

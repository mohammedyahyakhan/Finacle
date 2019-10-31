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
    ///The ClickLostStolenDebitCard recording.
    /// </summary>
    [TestModule("262b191a-e8eb-403f-ad8c-0c22f12cbcca", ModuleType.Recording, 1)]
    public partial class ClickLostStolenDebitCard : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DebitCardsRepository repository.
        /// </summary>
        public static DebitCardsRepository repo = DebitCardsRepository.Instance;

        static ClickLostStolenDebitCard instance = new ClickLostStolenDebitCard();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickLostStolenDebitCard()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClickLostStolenDebitCard Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.CancelLostStolenCardModal'", repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.SelfInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelLostStolenCardModal.CancelLostStolenCardHeader'.", repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.CancelLostStolenCardHeaderInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.CancelLostStolenCardHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
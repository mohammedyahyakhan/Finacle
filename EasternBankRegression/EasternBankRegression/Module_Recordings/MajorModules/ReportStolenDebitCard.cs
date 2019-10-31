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

namespace EasternBankRegression.Module_Recordings.MajorModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ReportStolenDebitCard recording.
    /// </summary>
    [TestModule("47166adc-4b39-40b1-bf85-017e4cfaa525", ModuleType.Recording, 1)]
    public partial class ReportStolenDebitCard : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static ReportStolenDebitCard instance = new ReportStolenDebitCard();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReportStolenDebitCard()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReportStolenDebitCard Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DebitCardsTopTab'.", repo.EasternOnlineBankingDashboard.DebitCardsTopTabInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DebitCardsTopTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DebitCardsTopTab'.", repo.EasternOnlineBankingDashboard.DebitCardsTopTabInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.DebitCardsTopTab.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.DebitCardsLoadingModal'", repo.EasternOnlineBankingDashboard.DebitCardsLoadingModalInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.DebitCardsLoadingModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.OrderNewCardButton'", repo.EasternOnlineBankingDashboard.OrderNewCardButtonInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.OrderNewCardButtonInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DebitCardsHeader'", repo.EasternOnlineBankingDashboard.DebitCardsHeaderInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.DebitCardsHeaderInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.varFirstActivatedDebitCard'.", repo.EasternOnlineBankingDashboard.varFirstActivatedDebitCardInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.varFirstActivatedDebitCard.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.varFirstActivatedDebitCard'.", repo.EasternOnlineBankingDashboard.varFirstActivatedDebitCardInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingDashboard.varFirstActivatedDebitCard.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen'", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.SelfInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.SelfInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButtonInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.CancelLostStolenCardModal'", repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.SelfInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelLostStolenCardModal.CancelLostStolenCardHeader'.", repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.CancelLostStolenCardHeaderInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.CancelLostStolenCardHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CancelLostStolenCardModal.CloseButton'.", repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.CloseButtonInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.CancelLostStolenCardModal.CloseButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

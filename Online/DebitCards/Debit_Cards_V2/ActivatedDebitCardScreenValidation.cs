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
    ///The ActivatedDebitCardScreenValidation recording.
    /// </summary>
    [TestModule("bfc4f92e-9dbc-4f94-805f-27304b13160a", ModuleType.Recording, 1)]
    public partial class ActivatedDebitCardScreenValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DebitCardsRepository repository.
        /// </summary>
        public static DebitCardsRepository repo = DebitCardsRepository.Instance;

        static ActivatedDebitCardScreenValidation instance = new ActivatedDebitCardScreenValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActivatedDebitCardScreenValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActivatedDebitCardScreenValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.DebitCard'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.DebitCardInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.DebitCardInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.MaskedNumbers'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.MaskedNumbersInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.MaskedNumbersInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.CancelLostStolenCardButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangePinButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangePinButtonInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangePinButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ForgotPinButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ForgotPinButtonInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ForgotPinButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.AtmDailyLimit'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.AtmDailyLimitInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.AtmDailyLimitInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.TotalyDailyLimit'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.TotalyDailyLimitInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.TotalyDailyLimitInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangeLimitButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangeLimitButtonInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.ChangeLimitButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.LinkedAccounts'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.LinkedAccountsInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.LinkedAccountsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.Information'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.InformationInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.InformationInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ActivatedDebitCardScreen.BackButton'.", repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.BackButtonInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ActivatedDebitCardScreen.BackButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

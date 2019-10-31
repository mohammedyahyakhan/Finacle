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

namespace NewAccountOpening
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FundingErrorValidation recording.
    /// </summary>
    [TestModule("1a39858d-5be1-43d9-ad85-3fafde3b1a7c", ModuleType.Recording, 1)]
    public partial class FundingErrorValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewAccountOpeningRepository repository.
        /// </summary>
        public static NewAccountOpeningRepository repo = NewAccountOpeningRepository.Instance;

        static FundingErrorValidation instance = new FundingErrorValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FundingErrorValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FundingErrorValidation Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable FundingError.
        /// </summary>
        [TestVariable("b33e8407-8872-4105-a600-5ee2876df843")]
        public string FundingError
        {
            get { return repo.FundingError; }
            set { repo.FundingError = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varNegativeBalanceAccount.
        /// </summary>
        [TestVariable("0475b4f9-c38c-4afa-9cfe-706e28f9e58b")]
        public string varNegativeBalanceAccount
        {
            get { return repo.varNegativeBalanceAccount; }
            set { repo.varNegativeBalanceAccount = value; }
        }

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseFillOutRequiredFieldsError'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseFillOutRequiredFieldsErrorInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseFillOutRequiredFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox' at Center.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBoxInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9' with focus on 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBoxInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox.PressKeys("9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton' at Center.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.LessThanVariableDollarError'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.LessThanVariableDollarErrorInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.LessThanVariableDollarErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundTransferAccountDropdown'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundTransferAccountDropdownInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundTransferAccountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.varNegativeBalanceAccount'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.varNegativeBalanceAccountInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.varNegativeBalanceAccount.As<WebElement>().PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox' at Center.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBoxInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '26' with focus on 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBoxInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox.PressKeys("26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton' at Center.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.LowFundingAccountBalanceError'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.LowFundingAccountBalanceErrorInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.LowFundingAccountBalanceErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
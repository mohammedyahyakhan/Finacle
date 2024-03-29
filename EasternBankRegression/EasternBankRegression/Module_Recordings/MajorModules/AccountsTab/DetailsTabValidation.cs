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

namespace EasternBankRegression.Module_Recordings.MajorModules.AccountsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DetailsTabValidation recording.
    /// </summary>
    [TestModule("2c790210-b24f-4ec8-ab54-2802b39967d6", ModuleType.Recording, 1)]
    public partial class DetailsTabValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static DetailsTabValidation instance = new DetailsTabValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DetailsTabValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DetailsTabValidation Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Accounts'.", repo.EasternOnlineBankingDashboard.AccountsInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.Accounts.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.WelcomeMessage'", repo.EasternOnlineBankingDashboard.WelcomeMessageInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.WelcomeMessageInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Grid'.", repo.EasternOnlineBankingDashboard.GridInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.Grid.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.varAccount3'", repo.EasternOnlineBankingDashboard.varAccount3Info, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.varAccount3Info.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.varAccount3'.", repo.EasternOnlineBankingDashboard.varAccount3Info, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.varAccount3.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(7));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.AccountActivityLoadingModal' at Center.", repo.EasternOnlineBankingDashboard.AccountActivityLoadingModalInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.AccountActivityLoadingModal.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.BalanceHeader'", repo.EasternOnlineBankingDashboard.BalanceHeaderInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.BalanceHeaderInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DetailsTab'.", repo.EasternOnlineBankingDashboard.DetailsTabInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.DetailsTab.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DetailsTab'.", repo.EasternOnlineBankingDashboard.DetailsTabInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DetailsTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.AccountName'", repo.EasternOnlineBankingDashboard.AccountNameInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.AccountNameInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.RenameAccountButton'.", repo.EasternOnlineBankingDashboard.RenameAccountButtonInfo, new RecordItemIndex(13));
            repo.EasternOnlineBankingDashboard.RenameAccountButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RenameAccountModal'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.SelfInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RenameAccountModal.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RenameAccountModal.RenameAccountHeader'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.RenameAccountHeaderInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RenameAccountModal.RenameAccountHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RenameAccountModal.AccountNameInputBox'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.AccountNameInputBoxInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RenameAccountModal.AccountNameInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RenameAccountModal.AccountNameRequirements'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.AccountNameRequirementsInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RenameAccountModal.AccountNameRequirementsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RenameAccountModal.AccountNameRequirementsSymbols'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.AccountNameRequirementsSymbolsInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RenameAccountModal.AccountNameRequirementsSymbolsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RenameAccountModal.CancelButton'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.CancelButtonInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RenameAccountModal.CancelButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RenameAccountModal.SaveButton'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.SaveButtonInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RenameAccountModal.SaveButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.RenameAccountModal.CancelButton'.", repo.EasternOnlineBankingDashboard.RenameAccountModal.CancelButtonInfo, new RecordItemIndex(21));
            repo.EasternOnlineBankingDashboard.RenameAccountModal.CancelButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AccountName'.", repo.EasternOnlineBankingDashboard.AccountNameInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AccountNameInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AccountType'.", repo.EasternOnlineBankingDashboard.AccountTypeInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AccountTypeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AccountNumber'.", repo.EasternOnlineBankingDashboard.AccountNumberInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AccountNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ShowButton'.", repo.EasternOnlineBankingDashboard.ShowButtonInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ShowButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ShowButton'.", repo.EasternOnlineBankingDashboard.ShowButtonInfo, new RecordItemIndex(26));
            repo.EasternOnlineBankingDashboard.ShowButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HideButton'.", repo.EasternOnlineBankingDashboard.HideButtonInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HideButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HideButton'.", repo.EasternOnlineBankingDashboard.HideButtonInfo, new RecordItemIndex(28));
            repo.EasternOnlineBankingDashboard.HideButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RoutingNumberTitle'.", repo.EasternOnlineBankingDashboard.RoutingNumberTitleInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RoutingNumberTitleInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.RoutingNumber'.", repo.EasternOnlineBankingDashboard.RoutingNumberInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.RoutingNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StartingBalance'.", repo.EasternOnlineBankingDashboard.StartingBalanceInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StartingBalanceInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CurrentBalance1'.", repo.EasternOnlineBankingDashboard.CurrentBalance1Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CurrentBalance1Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AvailableBalance11'.", repo.EasternOnlineBankingDashboard.AvailableBalance11Info, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AvailableBalance11Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenDate'.", repo.EasternOnlineBankingDashboard.OpenDateInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenDateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LastStatementDate'.", repo.EasternOnlineBankingDashboard.LastStatementDateInfo, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LastStatementDateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LastStatementBalance'.", repo.EasternOnlineBankingDashboard.LastStatementBalanceInfo, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LastStatementBalanceInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

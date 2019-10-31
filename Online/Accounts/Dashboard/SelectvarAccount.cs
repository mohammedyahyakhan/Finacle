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

namespace AccountsTestSuite.Dashboard
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectvarAccount recording.
    /// </summary>
    [TestModule("466920b6-7070-4402-ac8e-249a9d509743", ModuleType.Recording, 1)]
    public partial class SelectvarAccount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static SelectvarAccount instance = new SelectvarAccount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectvarAccount()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectvarAccount Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varAccount.
        /// </summary>
        [TestVariable("03910666-17a8-4e09-a45d-42b5a41d5e89")]
        public string varAccount
        {
            get { return repo.varAccount; }
            set { repo.varAccount = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.TopBar.Accounts'.", repo.EasternOnlineBankingAuthenticationSc.TopBar.AccountsInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingAuthenticationSc.TopBar.Accounts.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.WelcomeArea.WelcomeMessage'", repo.EasternOnlineBankingAuthenticationSc.WelcomeArea.WelcomeMessageInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingAuthenticationSc.WelcomeArea.WelcomeMessageInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.Grid'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.GridInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.Grid.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.varAccount'", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.varAccountInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.varAccountInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.varAccount'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.varAccountInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.varAccount.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingAuthenticationSc.AccountActivityLoadingModal'.", repo.EasternOnlineBankingAuthenticationSc.AccountActivityLoadingModalInfo, new RecordItemIndex(7));
            //repo.EasternOnlineBankingAuthenticationSc.AccountActivityLoadingModal.EnsureVisible();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.AccountActivityLoadingModal'", repo.EasternOnlineBankingAuthenticationSc.AccountActivityLoadingModalInfo, new RecordItemIndex(8));
            //repo.EasternOnlineBankingAuthenticationSc.AccountActivityLoadingModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.ActivityTab.BalanceHeader'", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.BalanceHeaderInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.BalanceHeaderInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
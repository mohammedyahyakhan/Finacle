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

namespace EasternBankRegression.Module_Recordings.MajorModules.SettingsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AccountShown recording.
    /// </summary>
    [TestModule("52894124-30b8-4843-8ead-f7bc5049eb4e", ModuleType.Recording, 1)]
    public partial class AccountShown : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static AccountShown instance = new AccountShown();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AccountShown()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AccountShown Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Settings'.", repo.ApplicationUnderTest.MajorModules.SettingsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.Settings.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'ApplicationUnderTest.MajorModules.Settings'.", repo.ApplicationUnderTest.MajorModules.SettingsInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.Settings.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.MajorModules.Settings'.", repo.ApplicationUnderTest.MajorModules.SettingsInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MajorModules.Settings.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccounts'", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccountsInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccountsInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccounts'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccountsInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccounts.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccounts'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccountsInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccounts.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle_7927'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle_7927Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle_7927.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle_7927' at Center", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle_7927Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle_7927.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.Done.DoneBtn'", repo.ApplicationUnderTest.Done.DoneBtnInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Done.DoneBtnInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.Done.DoneBtn'.", repo.ApplicationUnderTest.Done.DoneBtnInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Done.DoneBtn.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.Done.DoneBtn'.", repo.ApplicationUnderTest.Done.DoneBtnInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Done.DoneBtn.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.Accounts'", repo.ApplicationUnderTest.MajorModules.AccountsInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.MajorModules.AccountsInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Accounts'.", repo.ApplicationUnderTest.MajorModules.AccountsInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.MajorModules.Accounts.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.MajorModules.Accounts'.", repo.ApplicationUnderTest.MajorModules.AccountsInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.MajorModules.Accounts.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927'.", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Info, new RecordItemIndex(14));
            Validate.Exists(repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Info);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

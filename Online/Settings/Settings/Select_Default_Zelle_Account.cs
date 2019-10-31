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

namespace Settings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Default_Zelle_Account recording.
    /// </summary>
    [TestModule("753e9811-725c-462f-8c6f-d455b15654a3", ModuleType.Recording, 1)]
    public partial class Select_Default_Zelle_Account : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SettingsRepository repository.
        /// </summary>
        public static SettingsRepository repo = SettingsRepository.Instance;

        static Select_Default_Zelle_Account instance = new Select_Default_Zelle_Account();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Default_Zelle_Account()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Default_Zelle_Account Instance
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
            Mouse.DefaultMoveTime = 10;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountHeaderInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdownInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdownInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategorySwitch'.", repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategorySwitchInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategorySwitchInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdownInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
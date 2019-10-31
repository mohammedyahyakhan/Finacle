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
    ///The SelectDefaultTransferAccountDropdown recording.
    /// </summary>
    [TestModule("eb27b63d-ba22-44a3-9371-00f06665c4a8", ModuleType.Recording, 1)]
    public partial class SelectDefaultTransferAccountDropdown : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SettingsRepository repository.
        /// </summary>
        public static SettingsRepository repo = SettingsRepository.Instance;

        static SelectDefaultTransferAccountDropdown instance = new SelectDefaultTransferAccountDropdown();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectDefaultTransferAccountDropdown()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectDefaultTransferAccountDropdown Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountDropdownInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountsList'", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountsList.SelfInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountsList.SelfInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

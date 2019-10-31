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
    ///The SelectDefaultBillPayAccountDropdown recording.
    /// </summary>
    [TestModule("06392d8e-9fa2-4ba8-a693-2ae880102040", ModuleType.Recording, 1)]
    public partial class SelectDefaultBillPayAccountDropdown : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SettingsRepository repository.
        /// </summary>
        public static SettingsRepository repo = SettingsRepository.Instance;

        static SelectDefaultBillPayAccountDropdown instance = new SelectDefaultBillPayAccountDropdown();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectDefaultBillPayAccountDropdown()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectDefaultBillPayAccountDropdown Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillpayAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillpayAccountDropdownInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillpayAccountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.BillpayAccountsList'", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.BillpayAccountsList.SelfInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.BillpayAccountsList.SelfInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
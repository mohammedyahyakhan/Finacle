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

namespace Header_Footer
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectSettingsTab recording.
    /// </summary>
    [TestModule("6409d645-84c9-47ea-9357-ceff31821adb", ModuleType.Recording, 1)]
    public partial class SelectSettingsTab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HeaderFooterRepository repository.
        /// </summary>
        public static HeaderFooterRepository repo = HeaderFooterRepository.Instance;

        static SelectSettingsTab instance = new SelectSettingsTab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectSettingsTab()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectSettingsTab Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TopBar.Settings'.", repo.EasternOnlineBankingDashboard.TopBar.SettingsInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.TopBar.Settings.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.SettingsPage.SettingsLoadingModal'.", repo.EasternOnlineBankingDashboard.SettingsPage.SettingsLoadingModalInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.SettingsPage.SettingsLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.SettingsPage.SettingsLoadingModal'", repo.EasternOnlineBankingDashboard.SettingsPage.SettingsLoadingModalInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.SettingsPage.SettingsLoadingModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
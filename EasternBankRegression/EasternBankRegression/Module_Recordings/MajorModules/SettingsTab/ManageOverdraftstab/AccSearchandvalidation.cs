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

namespace EasternBankRegression.Module_Recordings.MajorModules.SettingsTab.ManageOverdraftstab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AccSearchandvalidation recording.
    /// </summary>
    [TestModule("37b1e34d-c713-4b29-a217-4dcb313035a4", ModuleType.Recording, 1)]
    public partial class AccSearchandvalidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static AccSearchandvalidation instance = new AccSearchandvalidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AccSearchandvalidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AccSearchandvalidation Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch' at Center.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearchInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'd' with focus on 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearchInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch.PressKeys("d");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.SearchAccountODStext'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.SearchAccountODStextInfo, new RecordItemIndex(2));
            Validate.Exists(repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.SearchAccountODStextInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch' at Center.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Back}s' with focus on 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearchInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.AccSearch.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}s");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.SearchAccountODStext1'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.SearchAccountODStext1Info, new RecordItemIndex(5));
            Validate.Exists(repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageOverdrafts.SearchAccountODStext1Info);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

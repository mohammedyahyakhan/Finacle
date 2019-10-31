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

namespace EasternBankRegression.Module_Recordings.MajorModules.SettingsTab.Profile
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CurrentPasswordEdit recording.
    /// </summary>
    [TestModule("860e0917-fbb8-418e-9d95-cc2eea87e1fb", ModuleType.Recording, 1)]
    public partial class CurrentPasswordEdit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static CurrentPasswordEdit instance = new CurrentPasswordEdit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CurrentPasswordEdit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CurrentPasswordEdit Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.CurrentPassword' at Center.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.CurrentPasswordInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.CurrentPassword.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'east@123' with focus on 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.CurrentPassword'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.CurrentPasswordInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.CurrentPassword.PressKeys("east@123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.NewPasswordEdit' at Center.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.NewPasswordEditInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.NewPasswordEdit.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'east@1234' with focus on 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.NewPasswordEdit'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.NewPasswordEditInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.NewPasswordEdit.PressKeys("east@1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.ConfirmNewPassword' at Center.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.ConfirmNewPasswordInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.ConfirmNewPassword.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'east@1234' with focus on 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.ConfirmNewPassword'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.ConfirmNewPasswordInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.ConfirmNewPassword.PressKeys("east@1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.SaveEditPassword' at Center.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.SaveEditPasswordInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.SaveEditPassword.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

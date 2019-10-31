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
    ///The EditPhoneNumberwith1 recording.
    /// </summary>
    [TestModule("66065f19-40e5-4125-80cb-d75bcca18e8d", ModuleType.Recording, 1)]
    public partial class EditPhoneNumberwith1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static EditPhoneNumberwith1 instance = new EditPhoneNumberwith1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditPhoneNumberwith1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditPhoneNumberwith1 Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{LControlKey down}{Xkey}{LControlKey up}617-519-4181' with focus on 'ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.EditPhoneNumber'.", repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.EditPhoneNumberInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.Settings_Sub.ProfileSub.EditPhoneNumber.PressKeys("{LControlKey down}{Akey}{LControlKey up}{LControlKey down}{Xkey}{LControlKey up}617-519-4181");
            Delay.Milliseconds(9620);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
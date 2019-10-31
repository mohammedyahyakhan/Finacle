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

namespace Login
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LocationsAndHoursLoggedOut recording.
    /// </summary>
    [TestModule("49f8b785-0ae6-46e9-ab2a-ea34be5b954d", ModuleType.Recording, 1)]
    public partial class LocationsAndHoursLoggedOut : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SetupAndTeardownRepository repository.
        /// </summary>
        public static SetupAndTeardownRepository repo = SetupAndTeardownRepository.Instance;

        static LocationsAndHoursLoggedOut instance = new LocationsAndHoursLoggedOut();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LocationsAndHoursLoggedOut()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LocationsAndHoursLoggedOut Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'HomepageEasternBank.ATMBranchLocator'", repo.HomepageEasternBank.ATMBranchLocatorInfo, new RecordItemIndex(0));
            repo.HomepageEasternBank.ATMBranchLocatorInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'HomepageEasternBank.EasternBankLogo'", repo.HomepageEasternBank.EasternBankLogoInfo, new RecordItemIndex(1));
            repo.HomepageEasternBank.EasternBankLogoInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

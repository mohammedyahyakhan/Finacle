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

namespace EasternBankRegression.Module_Recordings.General
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Done_Finish recording.
    /// </summary>
    [TestModule("5a92f1cc-c494-42b2-b87b-e1309b07d454", ModuleType.Recording, 1)]
    public partial class Done_Finish : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static Done_Finish instance = new Done_Finish();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Done_Finish()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Done_Finish Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.Done.DoneBtn'", repo.ApplicationUnderTest.Done.DoneBtnInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Done.DoneBtnInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.Done.DoneBtn'.", repo.ApplicationUnderTest.Done.DoneBtnInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Done.DoneBtn.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.Done.DoneBtn'.", repo.ApplicationUnderTest.Done.DoneBtnInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Done.DoneBtn.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

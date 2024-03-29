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

namespace EasternBankRegression.Module_Recordings.MajorModules.BillPayTab.ReportsTab.CreateReportBTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ReportTitle recording.
    /// </summary>
    [TestModule("95bf7826-bb62-49ba-9c79-3109d737dec9", ModuleType.Recording, 1)]
    public partial class ReportTitle : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static ReportTitle instance = new ReportTitle();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReportTitle()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReportTitle Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.CreateReportSub.ReportTitle' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.CreateReportSub.ReportTitleInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.CreateReportSub.ReportTitle.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{LControlKey down}{Xkey}{LControlKey up}!B' with focus on 'ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.CreateReportSub.ReportTitle'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.CreateReportSub.ReportTitleInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsSub.CreateReportSub.ReportTitle.PressKeys("{LControlKey down}{Akey}{LControlKey up}{LControlKey down}{Xkey}{LControlKey up}!B");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

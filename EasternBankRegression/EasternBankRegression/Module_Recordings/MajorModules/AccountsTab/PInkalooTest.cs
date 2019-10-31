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

namespace EasternBankRegression.Module_Recordings.MajorModules.AccountsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PInkalooTest recording.
    /// </summary>
    [TestModule("880cff74-fdfd-4ff5-8c7e-b45f974cafe6", ModuleType.Recording, 1)]
    public partial class PInkalooTest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static PInkalooTest instance = new PInkalooTest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PInkalooTest()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PInkalooTest Instance
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'EasternOnlineBankingDashboard.PinkalooIcon'.", repo.EasternOnlineBankingDashboard.PinkalooIconInfo, new RecordItemIndex(0));
            //Validate.NotExists(repo.EasternOnlineBankingDashboard.PinkalooIconInfo);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'EasternOnlineBankingDashboard.GiveForGoodHeader'.", repo.EasternOnlineBankingDashboard.GiveForGoodHeaderInfo, new RecordItemIndex(1));
            //Validate.NotExists(repo.EasternOnlineBankingDashboard.GiveForGoodHeaderInfo);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'EasternOnlineBankingDashboard.PinkalooDescription'.", repo.EasternOnlineBankingDashboard.PinkalooDescriptionInfo, new RecordItemIndex(2));
            //Validate.NotExists(repo.EasternOnlineBankingDashboard.PinkalooDescriptionInfo);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'EasternOnlineBankingDashboard.LearnMoreButton'.", repo.EasternOnlineBankingDashboard.LearnMoreButtonInfo, new RecordItemIndex(3));
            //Validate.NotExists(repo.EasternOnlineBankingDashboard.LearnMoreButtonInfo);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.List'.", repo.EasternOnlineBankingDashboard.ListInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.List.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'EasternOnlineBankingDashboard.OtherAccounts'.", repo.EasternOnlineBankingDashboard.OtherAccountsInfo, new RecordItemIndex(5));
            Validate.NotExists(repo.EasternOnlineBankingDashboard.OtherAccountsInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
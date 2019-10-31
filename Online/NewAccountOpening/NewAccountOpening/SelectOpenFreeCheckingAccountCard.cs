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

namespace NewAccountOpening
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectOpenFreeCheckingAccountCard recording.
    /// </summary>
    [TestModule("195c4936-2426-4f33-ae90-f72f2144aa9a", ModuleType.Recording, 1)]
    public partial class SelectOpenFreeCheckingAccountCard : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewAccountOpeningRepository repository.
        /// </summary>
        public static NewAccountOpeningRepository repo = NewAccountOpeningRepository.Instance;

        static SelectOpenFreeCheckingAccountCard instance = new SelectOpenFreeCheckingAccountCard();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectOpenFreeCheckingAccountCard()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectOpenFreeCheckingAccountCard Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.OpenAccountGridViewCard'.", repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.SelfInfo, new RecordItemIndex(0));
            Validate.Exists(repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.OpenAccountGridViewCard.AccountOpenIcon'.", repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.AccountOpenIconInfo, new RecordItemIndex(1));
            Validate.Exists(repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.AccountOpenIconInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.OpenAccountGridViewCard.OpenAFreeCheckingAccount'.", repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.OpenAFreeCheckingAccountInfo, new RecordItemIndex(2));
            Validate.Exists(repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.OpenAFreeCheckingAccountInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.OpenAccountGridViewCard.ClickToLearnMore'.", repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.ClickToLearnMoreInfo, new RecordItemIndex(3));
            Validate.Exists(repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.ClickToLearnMoreInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenAccountGridViewCard.ClickToLearnMore'.", repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.ClickToLearnMoreInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.OpenAccountGridViewCard.ClickToLearnMore.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.NewAccountTypePickerModal'", repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.SelfInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
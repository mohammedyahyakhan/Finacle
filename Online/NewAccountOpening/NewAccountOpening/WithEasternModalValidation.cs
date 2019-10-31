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
    ///The WithEasternModalValidation recording.
    /// </summary>
    [TestModule("c6b589c5-7d79-4c8a-8ed7-933491983307", ModuleType.Recording, 1)]
    public partial class WithEasternModalValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewAccountOpeningRepository repository.
        /// </summary>
        public static NewAccountOpeningRepository repo = NewAccountOpeningRepository.Instance;

        static WithEasternModalValidation instance = new WithEasternModalValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WithEasternModalValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WithEasternModalValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.SetAlerts'.", repo.EasternOnlineBankingDashboard.ModalHeader.SetAlertsInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.SetAlertsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.ChooseFromAVarietyOfEmailAnd'.", repo.EasternOnlineBankingDashboard.ModalHeader.ChooseFromAVarietyOfEmailAndInfo, new RecordItemIndex(1));
            //Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.ChooseFromAVarietyOfEmailAndInfo, "Visible", "True");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.ManageYourStatementSettings'.", repo.EasternOnlineBankingDashboard.ModalHeader.ManageYourStatementSettingsInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.ManageYourStatementSettingsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.ChooseHow'.", repo.EasternOnlineBankingDashboard.ModalHeader.ChooseHowInfo, new RecordItemIndex(3));
            //Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.ChooseHowInfo, "Visible", "True");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.SelectDefaultAccounts'.", repo.EasternOnlineBankingDashboard.ModalHeader.SelectDefaultAccountsInfo, new RecordItemIndex(4));
            //Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.SelectDefaultAccountsInfo, "Visible", "True");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.SelectYourDefault'.", repo.EasternOnlineBankingDashboard.ModalHeader.SelectYourDefaultInfo, new RecordItemIndex(5));
            //Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.SelectYourDefaultInfo, "Visible", "True");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.DoneButton'.", repo.EasternOnlineBankingDashboard.ModalHeader.DoneButtonInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ModalHeader.GoToSettingsButton'.", repo.EasternOnlineBankingDashboard.ModalHeader.GoToSettingsButtonInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ModalHeader.GoToSettingsButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
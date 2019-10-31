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
    ///The ValidateFooter recording.
    /// </summary>
    [TestModule("1d7fd0e9-f27c-49c4-96d4-0f274799cfeb", ModuleType.Recording, 1)]
    public partial class ValidateFooter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HeaderFooterRepository repository.
        /// </summary>
        public static HeaderFooterRepository repo = HeaderFooterRepository.Instance;

        static ValidateFooter instance = new ValidateFooter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateFooter()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateFooter Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.EqualHousingLenderSprite'.", repo.EasternOnlineBankingDashboard.Footer.EqualHousingLenderSpriteInfo, new RecordItemIndex(0));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.EqualHousingLenderSpriteInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.EqualHousingLender'.", repo.EasternOnlineBankingDashboard.Footer.EqualHousingLenderInfo, new RecordItemIndex(1));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.EqualHousingLenderInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.MemberFDIC'.", repo.EasternOnlineBankingDashboard.Footer.MemberFDICInfo, new RecordItemIndex(2));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.MemberFDICInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.PrivacyPolicy'.", repo.EasternOnlineBankingDashboard.Footer.PrivacyPolicyInfo, new RecordItemIndex(3));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.PrivacyPolicyInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.Agreement'.", repo.EasternOnlineBankingDashboard.Footer.AgreementInfo, new RecordItemIndex(4));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.AgreementInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.ESignConsent'.", repo.EasternOnlineBankingDashboard.Footer.ESignConsentInfo, new RecordItemIndex(5));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.ESignConsentInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.FeeSchedule'.", repo.EasternOnlineBankingDashboard.Footer.FeeScheduleInfo, new RecordItemIndex(6));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.FeeScheduleInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingDashboard.Footer.CopyrightAllRightsReserved'.", repo.EasternOnlineBankingDashboard.Footer.CopyrightAllRightsReservedInfo, new RecordItemIndex(7));
            Validate.Exists(repo.EasternOnlineBankingDashboard.Footer.CopyrightAllRightsReservedInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
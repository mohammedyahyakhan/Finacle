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

namespace FirstTimeEnrollment
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AuthSignerDataEntry recording.
    /// </summary>
    [TestModule("19b480f7-76c5-4daa-8cc0-0afdf1833821", ModuleType.Recording, 1)]
    public partial class AuthSignerDataEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the FirstTimeEnrollmentRepository repository.
        /// </summary>
        public static FirstTimeEnrollmentRepository repo = FirstTimeEnrollmentRepository.Instance;

        static AuthSignerDataEntry instance = new AuthSignerDataEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AuthSignerDataEntry()
        {
            varAuthorizedSignerSsn = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AuthSignerDataEntry Instance
        {
            get { return instance; }
        }

#region Variables

        string _varAuthorizedSignerSsn;

        /// <summary>
        /// Gets or sets the value of variable varAuthorizedSignerSsn.
        /// </summary>
        [TestVariable("489eeef3-04ef-4cbc-9ca7-45356659ccaf")]
        public string varAuthorizedSignerSsn
        {
            get { return _varAuthorizedSignerSsn; }
            set { _varAuthorizedSignerSsn = value; }
        }

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.FirstNameInputBox'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.FirstNameInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.FirstNameInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Auth' with focus on 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.FirstNameInputBox'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.FirstNameInputBoxInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.FirstNameInputBox.PressKeys("Auth");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.LastNameInputBox'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.LastNameInputBoxInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.LastNameInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Signer' with focus on 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.LastNameInputBox'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.LastNameInputBoxInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.LastNameInputBox.PressKeys("Signer");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.SocialSecurityNumberInputBox'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.SocialSecurityNumberInputBoxInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.SocialSecurityNumberInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varAuthorizedSignerSsn' with focus on 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.SocialSecurityNumberInputBox'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.SocialSecurityNumberInputBoxInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.WhoIsEnrollingOnBehalfOfThisBusinessPage.SocialSecurityNumberInputBox.PressKeys(varAuthorizedSignerSsn);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

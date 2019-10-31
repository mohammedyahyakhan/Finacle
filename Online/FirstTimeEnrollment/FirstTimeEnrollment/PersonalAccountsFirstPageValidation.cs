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
    ///The PersonalAccountsFirstPageValidation recording.
    /// </summary>
    [TestModule("c3dd500e-8f60-4fb2-99ec-84e146ec8100", ModuleType.Recording, 1)]
    public partial class PersonalAccountsFirstPageValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the FirstTimeEnrollmentRepository repository.
        /// </summary>
        public static FirstTimeEnrollmentRepository repo = FirstTimeEnrollmentRepository.Instance;

        static PersonalAccountsFirstPageValidation instance = new PersonalAccountsFirstPageValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PersonalAccountsFirstPageValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PersonalAccountsFirstPageValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.SetUpOnlineAccessMessage'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.SetUpOnlineAccessMessageInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.SetUpOnlineAccessMessageInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.FirstNameInputBox'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.FirstNameInputBoxInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.FirstNameInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.LastNameInputBox'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.LastNameInputBoxInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.LastNameInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.SsnInputBox'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.SsnInputBoxInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.SsnInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.FooterButtons.BackButton'.", repo.EasternOnlineBankingOnlineBankingE.FooterButtons.BackButtonInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.FooterButtons.BackButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.NextButton'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.NextButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.NextButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.NextButton'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.NextButtonInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.NextButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.PleaseCorrectTheFollowingFieldsError'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.PleaseCorrectTheFollowingFieldsErrorInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.PleaseCorrectTheFollowingFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidFirstNameError'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidFirstNameErrorInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidFirstNameErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidLastNameError'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidLastNameErrorInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidLastNameErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidSsnError'.", repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidSsnErrorInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PersonalAccountsFirstPage.Errors.InvalidSsnErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

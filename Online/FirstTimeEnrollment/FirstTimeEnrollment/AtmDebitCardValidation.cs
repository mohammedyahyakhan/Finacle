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
    ///The AtmDebitCardValidation recording.
    /// </summary>
    [TestModule("21091c61-2800-4b49-8aa5-185c2e25045f", ModuleType.Recording, 1)]
    public partial class AtmDebitCardValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the FirstTimeEnrollmentRepository repository.
        /// </summary>
        public static FirstTimeEnrollmentRepository repo = FirstTimeEnrollmentRepository.Instance;

        static AtmDebitCardValidation instance = new AtmDebitCardValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AtmDebitCardValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AtmDebitCardValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.ATMDebitCardHeader'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.ATMDebitCardHeaderInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.ATMDebitCardHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.PleaseValidateYourAtmDebitCardHeader'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.PleaseValidateYourAtmDebitCardHeaderInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.PleaseValidateYourAtmDebitCardHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.AccountNumberLast4DigitsInputBox'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.AccountNumberLast4DigitsInputBoxInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.AccountNumberLast4DigitsInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.PinInputBox'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.PinInputBoxInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.PinInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.CaptchaImage'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.CaptchaImageInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.CaptchaImageInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.RefreshIcon'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.RefreshIconInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.RefreshIconInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.VerificationCodeInputBox'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.VerificationCodeInputBoxInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.VerificationCodeInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.FooterButtons.BackButton'.", repo.EasternOnlineBankingOnlineBankingE.FooterButtons.BackButtonInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.FooterButtons.BackButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.FooterButtons.NextButton'.", repo.EasternOnlineBankingOnlineBankingE.FooterButtons.NextButtonInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.FooterButtons.NextButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingOnlineBankingE.FooterButtons.NextButton'.", repo.EasternOnlineBankingOnlineBankingE.FooterButtons.NextButtonInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingOnlineBankingE.FooterButtons.NextButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.PleaseCorrectTheFollowingFieldsError'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.PleaseCorrectTheFollowingFieldsErrorInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.PleaseCorrectTheFollowingFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidCardNumberError'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidCardNumberErrorInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidCardNumberErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidPinError'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidPinErrorInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidPinErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidCaptchaError'.", repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidCaptchaErrorInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.AtmDebitCardPage.Errors.InvalidCaptchaErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

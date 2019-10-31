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

namespace LoginTestSuite
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AlexaTest recording.
    /// </summary>
    [TestModule("7a6826c8-87de-4ac9-b480-cc882bd30f40", ModuleType.Recording, 1)]
    public partial class AlexaTest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LoginTestSuiteRepository repository.
        /// </summary>
        public static LoginTestSuiteRepository repo = LoginTestSuiteRepository.Instance;

        static AlexaTest instance = new AlexaTest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AlexaTest()
        {
            Username = "chrome_automation";
            Password = "bank@4321";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AlexaTest Instance
        {
            get { return instance; }
        }

#region Variables

        string _Username;

        /// <summary>
        /// Gets or sets the value of variable Username.
        /// </summary>
        [TestVariable("1d68604a-76c4-4d12-b5ba-513e4f5fd0d1")]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        string _Password;

        /// <summary>
        /// Gets or sets the value of variable Password.
        /// </summary>
        [TestVariable("b35a44c8-d0e8-41be-8dfb-17c40193bd99")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.LoginPage.AlexaDescription'.", repo.Finacle.Alexa.LoginPage.AlexaDescriptionInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Finacle.Alexa.LoginPage.AlexaDescriptionInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.LoginModal.UsernameInputBox'.", repo.Finacle.LoginModal.UsernameInputBoxInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Finacle.LoginModal.UsernameInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.LoginModal.PasswordInputBox'.", repo.Finacle.LoginModal.PasswordInputBoxInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Finacle.LoginModal.PasswordInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.LoginPage.SignInButton'.", repo.Finacle.Alexa.LoginPage.SignInButtonInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Finacle.Alexa.LoginPage.SignInButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Finacle.Alexa.LoginPage.SignInButton'.", repo.Finacle.Alexa.LoginPage.SignInButtonInfo, new RecordItemIndex(4));
            repo.Finacle.Alexa.LoginPage.SignInButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.LoginPage.PleaseCorrectTheFollowingFieldsError'.", repo.Finacle.Alexa.LoginPage.PleaseCorrectTheFollowingFieldsErrorInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Finacle.Alexa.LoginPage.PleaseCorrectTheFollowingFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.LoginPage.IncorrectUsernameError'.", repo.Finacle.Alexa.LoginPage.IncorrectUsernameErrorInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.Finacle.Alexa.LoginPage.IncorrectUsernameErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.LoginPage.IncorrectPasswordError'.", repo.Finacle.Alexa.LoginPage.IncorrectPasswordErrorInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.Finacle.Alexa.LoginPage.IncorrectPasswordErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$Username' on item 'Finacle.LoginModal.UsernameInputBox'.", repo.Finacle.LoginModal.UsernameInputBoxInfo, new RecordItemIndex(8));
            repo.Finacle.LoginModal.UsernameInputBox.Element.SetAttributeValue("Value", Username);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'Wrong' on item 'Finacle.LoginModal.PasswordInputBox'.", repo.Finacle.LoginModal.PasswordInputBoxInfo, new RecordItemIndex(9));
            repo.Finacle.LoginModal.PasswordInputBox.Element.SetAttributeValue("Value", "Wrong");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Finacle.Alexa.LoginPage.SignInButton'.", repo.Finacle.Alexa.LoginPage.SignInButtonInfo, new RecordItemIndex(10));
            repo.Finacle.Alexa.LoginPage.SignInButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'Finacle.Alexa.LoginPage.IncorrectUsernameOrPasswordError'", repo.Finacle.Alexa.LoginPage.IncorrectUsernameOrPasswordErrorInfo, new RecordItemIndex(11));
            repo.Finacle.Alexa.LoginPage.IncorrectUsernameOrPasswordErrorInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$Username' on item 'Finacle.LoginModal.UsernameInputBox'.", repo.Finacle.LoginModal.UsernameInputBoxInfo, new RecordItemIndex(12));
            repo.Finacle.LoginModal.UsernameInputBox.Element.SetAttributeValue("Value", Username);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$Password' on item 'Finacle.LoginModal.PasswordInputBox'.", repo.Finacle.LoginModal.PasswordInputBoxInfo, new RecordItemIndex(13));
            repo.Finacle.LoginModal.PasswordInputBox.Element.SetAttributeValue("Value", Password);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Finacle.Alexa.LoginPage.SignInButton'.", repo.Finacle.Alexa.LoginPage.SignInButtonInfo, new RecordItemIndex(14));
            repo.Finacle.Alexa.LoginPage.SignInButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'Finacle.Alexa.AuthorizePage.AuthorizeAccess'", repo.Finacle.Alexa.AuthorizePage.AuthorizeAccessInfo, new RecordItemIndex(15));
            repo.Finacle.Alexa.AuthorizePage.AuthorizeAccessInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.AmazonIsRequestingToConnectToYourEbAccount'.", repo.Finacle.Alexa.AuthorizePage.AmazonIsRequestingToConnectToYourEbAccountInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.AmazonIsRequestingToConnectToYourEbAccountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.ByAuthorizingYouAreConsentingTo'.", repo.Finacle.Alexa.AuthorizePage.ByAuthorizingYouAreConsentingToInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.ByAuthorizingYouAreConsentingToInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.ViewAccountBalance'.", repo.Finacle.Alexa.AuthorizePage.ViewAccountBalanceInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.ViewAccountBalanceInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.ViewTransactions'.", repo.Finacle.Alexa.AuthorizePage.ViewTransactionsInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.ViewTransactionsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.ViewScheduledBills'.", repo.Finacle.Alexa.AuthorizePage.ViewScheduledBillsInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.ViewScheduledBillsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.NeverShareYourAmazonAlexaAppOrEbCreds'.", repo.Finacle.Alexa.AuthorizePage.NeverShareYourAmazonAlexaAppOrEbCredsInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.NeverShareYourAmazonAlexaAppOrEbCredsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.DenyButton'.", repo.Finacle.Alexa.AuthorizePage.DenyButtonInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.DenyButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AuthorizePage.AuthorizeButton'.", repo.Finacle.Alexa.AuthorizePage.AuthorizeButtonInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.Finacle.Alexa.AuthorizePage.AuthorizeButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Finacle.Alexa.AuthorizePage.AuthorizeButton'.", repo.Finacle.Alexa.AuthorizePage.AuthorizeButtonInfo, new RecordItemIndex(24));
            repo.Finacle.Alexa.AuthorizePage.AuthorizeButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'Finacle.Alexa.AccountSetupPage.AccountSetup'", repo.Finacle.Alexa.AccountSetupPage.AccountSetupInfo, new RecordItemIndex(25));
            repo.Finacle.Alexa.AccountSetupPage.AccountSetupInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.PleaseSelectADefaultAccountForAlexa'.", repo.Finacle.Alexa.AccountSetupPage.PleaseSelectADefaultAccountForAlexaInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.PleaseSelectADefaultAccountForAlexaInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.SelectAccountLabel'.", repo.Finacle.Alexa.AccountSetupPage.SelectAccountLabelInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.SelectAccountLabelInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.AccountDropdown'.", repo.Finacle.Alexa.AccountSetupPage.AccountDropdownInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.AccountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.Enter4DigitPinLabel'.", repo.Finacle.Alexa.AccountSetupPage.Enter4DigitPinLabelInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.Enter4DigitPinLabelInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.PinInputBox'.", repo.Finacle.Alexa.AccountSetupPage.PinInputBoxInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.PinInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.ConfirmPinLabel'.", repo.Finacle.Alexa.AccountSetupPage.ConfirmPinLabelInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.ConfirmPinLabelInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.ConfirmPinInputBox'.", repo.Finacle.Alexa.AccountSetupPage.ConfirmPinInputBoxInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.ConfirmPinInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.LoginPage.SignInButton'.", repo.Finacle.Alexa.LoginPage.SignInButtonInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.Finacle.Alexa.LoginPage.SignInButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Finacle.Alexa.LoginPage.SignInButton'.", repo.Finacle.Alexa.LoginPage.SignInButtonInfo, new RecordItemIndex(34));
            repo.Finacle.Alexa.LoginPage.SignInButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.PinError'.", repo.Finacle.Alexa.AccountSetupPage.PinErrorInfo, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.PinErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1234' on item 'Finacle.Alexa.AccountSetupPage.PinInputBox'.", repo.Finacle.Alexa.AccountSetupPage.PinInputBoxInfo, new RecordItemIndex(36));
            repo.Finacle.Alexa.AccountSetupPage.PinInputBox.Element.SetAttributeValue("Value", "1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Finacle.Alexa.LoginPage.SignInButton'.", repo.Finacle.Alexa.LoginPage.SignInButtonInfo, new RecordItemIndex(37));
            repo.Finacle.Alexa.LoginPage.SignInButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Finacle.Alexa.AccountSetupPage.ConfirmPinError'.", repo.Finacle.Alexa.AccountSetupPage.ConfirmPinErrorInfo, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.Finacle.Alexa.AccountSetupPage.ConfirmPinErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
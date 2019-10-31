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

namespace EasternBankRegression.Module_Recordings.MajorModules.Login
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SaveUnsaveUsername recording.
    /// </summary>
    [TestModule("fc13ca7d-a5e1-412f-b56c-4b1784ef30b2", ModuleType.Recording, 1)]
    public partial class SaveUnsaveUsername : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static SaveUnsaveUsername instance = new SaveUnsaveUsername();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SaveUnsaveUsername()
        {
            varBrowser = "Chrome";
            EnvURL = "https://fnclmobqa.easternbank.com:8543/angular/AuthenticationController?__START_TRAN_FLAG__=Y&FORMSGROUP_ID__=AuthenticationFG&__EVENT_ID__=LOAD&FG_BUTTONS__=LOAD&ACTION.LOAD=Y&AuthenticationFG.LOGIN_FLAG=1&BANK_ID=EBK&LANGUAGE_ID=001&ANGULAR_FLAG=Y";
            varUrl = "";
            varPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SaveUnsaveUsername Instance
        {
            get { return instance; }
        }

#region Variables

        string _varBrowser;

        /// <summary>
        /// Gets or sets the value of variable varBrowser.
        /// </summary>
        [TestVariable("c45a1579-83c2-4c8b-8b37-774478a09f2c")]
        public string varBrowser
        {
            get { return _varBrowser; }
            set { _varBrowser = value; }
        }

        string _EnvURL;

        /// <summary>
        /// Gets or sets the value of variable EnvURL.
        /// </summary>
        [TestVariable("79a9a87a-ed05-4e9f-8c2f-389b99454533")]
        public string EnvURL
        {
            get { return _EnvURL; }
            set { _EnvURL = value; }
        }

        string _varUrl;

        /// <summary>
        /// Gets or sets the value of variable varUrl.
        /// </summary>
        [TestVariable("07e75e0f-54f2-49c8-8d7f-3e3acd520a89")]
        public string varUrl
        {
            get { return _varUrl; }
            set { _varUrl = value; }
        }

        string _varPassword;

        /// <summary>
        /// Gets or sets the value of variable varPassword.
        /// </summary>
        [TestVariable("e808499c-bc2c-4ef9-bdff-b2187aef207e")]
        public string varPassword
        {
            get { return _varPassword; }
            set { _varPassword = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $EnvURL with browser specified by variable $varBrowser in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(EnvURL, varBrowser, "", false, true, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL'.", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPALInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL' at Center", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPALInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'qacon1' with focus on 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL'.", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPALInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL.PressKeys("qacon1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO' at UpperCenter", repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGOInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO.Touch(Location.UpperCenter);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SaveUsernameCheckboxUnchecked'.", repo.EasternOnlineBankingDashboard.SaveUsernameCheckboxUncheckedInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.SaveUsernameCheckboxUnchecked.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1' at Center", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'east@1234' with focus on 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1'.", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1.PressKeys("east@1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO' at UpperCenter", repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGOInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO.Touch(Location.UpperCenter);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO' at UpperCenter", repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGOInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO.Touch(Location.UpperCenter);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.LoginCredentials_Signin.ActionVALIDATECREDENTIALS'.", repo.ApplicationUnderTest.LoginCredentials_Signin.ActionVALIDATECREDENTIALSInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.LoginCredentials_Signin.ActionVALIDATECREDENTIALS.PerformClick();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccounts'", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccountsInfo, new RecordItemIndex(11));
                repo.ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccountsInfo.WaitForAttributeContains(5000, "Enabled", "True");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+W' Press with focus on 'Finacle'.", repo.Finacle.SelfInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.Finacle.Self);
            Keyboard.Press(System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $EnvURL with browser specified by variable $varBrowser in maximized mode.", new RecordItemIndex(13));
            Host.Current.OpenBrowser(EnvURL, varBrowser, "", false, true, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.EasternBankLogo'", repo.EasternOnlineBankingDashboard.EasternBankLogoInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.EasternBankLogoInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.UsernameInputBox'.", repo.EasternOnlineBankingDashboard.UsernameInputBoxInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.UsernameInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (TagValue~'.*') on item 'EasternOnlineBankingDashboard.UsernameInputBox'.", repo.EasternOnlineBankingDashboard.UsernameInputBoxInfo, new RecordItemIndex(16));
            Validate.AttributeRegex(repo.EasternOnlineBankingDashboard.UsernameInputBoxInfo, "TagValue", new Regex(".*"));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SaveUsernameCheckboxChecked'.", repo.EasternOnlineBankingDashboard.SaveUsernameCheckboxCheckedInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SaveUsernameCheckboxCheckedInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SaveUsernameCheckboxChecked'.", repo.EasternOnlineBankingDashboard.SaveUsernameCheckboxCheckedInfo, new RecordItemIndex(18));
            repo.EasternOnlineBankingDashboard.SaveUsernameCheckboxChecked.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'east@1234' with focus on 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1'.", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1Info, new RecordItemIndex(19));
            repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1.PressKeys("east@1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SignInButton2'.", repo.EasternOnlineBankingDashboard.SignInButton2Info, new RecordItemIndex(20));
            repo.EasternOnlineBankingDashboard.SignInButton2.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.Welcome1'", repo.EasternOnlineBankingDashboard.Welcome1Info, new RecordItemIndex(21));
            repo.EasternOnlineBankingDashboard.Welcome1Info.WaitForAttributeEqual(5000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
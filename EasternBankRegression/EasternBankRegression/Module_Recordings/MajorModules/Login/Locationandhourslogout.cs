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
    ///The Locationandhourslogout recording.
    /// </summary>
    [TestModule("2e6ded9e-a851-47f7-9723-67ef4cac7251", ModuleType.Recording, 1)]
    public partial class Locationandhourslogout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static Locationandhourslogout instance = new Locationandhourslogout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Locationandhourslogout()
        {
            varBrowser = "Chrome";
            EnvURL = "https://fnclmobqa.easternbank.com:8543/angular/AuthenticationController?__START_TRAN_FLAG__=Y&FORMSGROUP_ID__=AuthenticationFG&__EVENT_ID__=LOAD&FG_BUTTONS__=LOAD&ACTION.LOAD=Y&AuthenticationFG.LOGIN_FLAG=1&BANK_ID=EBK&LANGUAGE_ID=001&ANGULAR_FLAG=Y";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Locationandhourslogout Instance
        {
            get { return instance; }
        }

#region Variables

        string _varBrowser;

        /// <summary>
        /// Gets or sets the value of variable varBrowser.
        /// </summary>
        [TestVariable("ef9136ca-ac76-4afe-8d00-e71afe781ecb")]
        public string varBrowser
        {
            get { return _varBrowser; }
            set { _varBrowser = value; }
        }

        string _EnvURL;

        /// <summary>
        /// Gets or sets the value of variable EnvURL.
        /// </summary>
        [TestVariable("8b7fc9ea-087f-4253-b2a4-b38bdaf69c8d")]
        public string EnvURL
        {
            get { return _EnvURL; }
            set { _EnvURL = value; }
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
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL' at Center", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPALInfo, new RecordItemIndex(2));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL.Touch();
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'qacon1' with focus on 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL'.", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPALInfo, new RecordItemIndex(3));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGUSERPRINCIPAL.PressKeys("qacon1");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO' at UpperCenter", repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGOInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO.Touch(Location.UpperCenter);
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1' at Center", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1Info, new RecordItemIndex(5));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1.Touch();
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'east@1234' with focus on 'ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1'.", repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1Info, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.AuthenticationFGACCESSCODE1.PressKeys("east@1234");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO' at UpperCenter", repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGOInfo, new RecordItemIndex(7));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO.Touch(Location.UpperCenter);
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO' at UpperCenter", repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGOInfo, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.EasternBankLOGO.Touch(Location.UpperCenter);
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.LoginCredentials_Signin.ActionVALIDATECREDENTIALS'.", repo.ApplicationUnderTest.LoginCredentials_Signin.ActionVALIDATECREDENTIALSInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.LoginCredentials_Signin.ActionVALIDATECREDENTIALS.PerformClick();
            //Delay.Milliseconds(0);
            
            try {
                //Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccounts'", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccountsInfo, new RecordItemIndex(10));
                //repo.ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccountsInfo.WaitForAttributeContains(5000, "Enabled", "True");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.WelcomeMessage'.", repo.EasternOnlineBankingDashboard.WelcomeMessageInfo, new RecordItemIndex(11));
            //repo.EasternOnlineBankingDashboard.WelcomeMessage.EnsureVisible();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.LastLogin'.", repo.EasternOnlineBankingDashboard.LastLoginInfo, new RecordItemIndex(12));
            //repo.EasternOnlineBankingDashboard.LastLogin.EnsureVisible();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.SearchAccountsInputBox'.", repo.EasternOnlineBankingDashboard.SearchAccountsInputBoxInfo, new RecordItemIndex(13));
            //repo.EasternOnlineBankingDashboard.SearchAccountsInputBox.EnsureVisible();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.LocationsAndHoursButton'.", repo.EasternOnlineBankingDashboard.LocationsAndHoursButtonInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.LocationsAndHoursButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'HomepageEasternBank.FindABranchOrATMNearYou'", repo.HomepageEasternBank.FindABranchOrATMNearYouInfo, new ActionTimeout(15000), new RecordItemIndex(15));
            repo.HomepageEasternBank.FindABranchOrATMNearYouInfo.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'HomepageEasternBank.ATMBranchLocator'", repo.HomepageEasternBank.ATMBranchLocatorInfo, new RecordItemIndex(16));
            repo.HomepageEasternBank.ATMBranchLocatorInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'HomepageEasternBank.EasternBankLogo'", repo.HomepageEasternBank.EasternBankLogoInfo, new RecordItemIndex(17));
            repo.HomepageEasternBank.EasternBankLogoInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+F4' Press.", new RecordItemIndex(18));
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

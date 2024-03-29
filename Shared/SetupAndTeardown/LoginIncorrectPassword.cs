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

namespace Login
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LoginIncorrectPassword recording.
    /// </summary>
    [TestModule("25c0c63a-d905-4a9b-b865-8388e35fef19", ModuleType.Recording, 1)]
    public partial class LoginIncorrectPassword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SetupAndTeardownRepository repository.
        /// </summary>
        public static SetupAndTeardownRepository repo = SetupAndTeardownRepository.Instance;

        static LoginIncorrectPassword instance = new LoginIncorrectPassword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoginIncorrectPassword()
        {
            varUrl = "https://fnclmobstg.easternbank.com/angular/AuthenticationController?__START_TRAN_FLAG__=Y&FORMSGROUP_ID__=AuthenticationFG&__EVENT_ID__=LOAD&FG_BUTTONS__=LOAD&ACTION.LOAD=Y&AuthenticationFG.LOGIN_FLAG=1&BANK_ID=EBK&LANGUAGE_ID=001&ANGULAR_FLAG=Y";
            varBrowser = "Chrome";
            varUsername = "stg1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LoginIncorrectPassword Instance
        {
            get { return instance; }
        }

#region Variables

        string _varUrl;

        /// <summary>
        /// Gets or sets the value of variable varUrl.
        /// </summary>
        [TestVariable("7a51ecc1-0c83-4767-beaa-fe556b2b9be2")]
        public string varUrl
        {
            get { return _varUrl; }
            set { _varUrl = value; }
        }

        string _varBrowser;

        /// <summary>
        /// Gets or sets the value of variable varBrowser.
        /// </summary>
        [TestVariable("e716bdab-21e2-4209-b4b3-86768360d44a")]
        public string varBrowser
        {
            get { return _varBrowser; }
            set { _varBrowser = value; }
        }

        string _varUsername;

        /// <summary>
        /// Gets or sets the value of variable varUsername.
        /// </summary>
        [TestVariable("52c40d55-8041-47d4-93c7-22939ad44a8d")]
        public string varUsername
        {
            get { return _varUsername; }
            set { _varUsername = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $varUrl with browser specified by variable $varBrowser in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(varUrl, varBrowser, "", false, true, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'Finacle.LoginModal.EasternBankLogo'", repo.Finacle.LoginModal.EasternBankLogoInfo, new RecordItemIndex(1));
            repo.Finacle.LoginModal.EasternBankLogoInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$varUsername' on item 'Finacle.LoginModal.UsernameField'.", repo.Finacle.LoginModal.UsernameFieldInfo, new RecordItemIndex(2));
            repo.Finacle.LoginModal.UsernameField.Element.SetAttributeValue("Value", varUsername);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'incorrect' on item 'Finacle.LoginModal.PasswordField'.", repo.Finacle.LoginModal.PasswordFieldInfo, new RecordItemIndex(3));
            repo.Finacle.LoginModal.PasswordField.Element.SetAttributeValue("Value", "incorrect");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'Finacle.LoginModal.SignInButton'.", repo.Finacle.LoginModal.SignInButtonInfo, new RecordItemIndex(4));
            repo.Finacle.LoginModal.SignInButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'Finacle.InvalidUNorPWError'", repo.Finacle.InvalidUNorPWErrorInfo, new RecordItemIndex(6));
            repo.Finacle.InvalidUNorPWErrorInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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

namespace EasternBankRegression.Module_Recordings.MajorModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SupportValidationOUt recording.
    /// </summary>
    [TestModule("77a38bd7-6f8c-4569-8a3c-1d1b2d8614f3", ModuleType.Recording, 1)]
    public partial class SupportValidationOUt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static SupportValidationOUt instance = new SupportValidationOUt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SupportValidationOUt()
        {
            varBrowser = "Chrome";
            EnvURL = "https://fnclmobqa.easternbank.com:8543/angular/AuthenticationController?__START_TRAN_FLAG__=Y&FORMSGROUP_ID__=AuthenticationFG&__EVENT_ID__=LOAD&FG_BUTTONS__=LOAD&ACTION.LOAD=Y&AuthenticationFG.LOGIN_FLAG=1&BANK_ID=EBK&LANGUAGE_ID=001&ANGULAR_FLAG=Y";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SupportValidationOUt Instance
        {
            get { return instance; }
        }

#region Variables

        string _varBrowser;

        /// <summary>
        /// Gets or sets the value of variable varBrowser.
        /// </summary>
        [TestVariable("ffce4d42-5467-4a31-937c-ba929f882c1a")]
        public string varBrowser
        {
            get { return _varBrowser; }
            set { _varBrowser = value; }
        }

        string _EnvURL;

        /// <summary>
        /// Gets or sets the value of variable EnvURL.
        /// </summary>
        [TestVariable("d4954acc-a00b-4c1a-a8b3-c10799d135e6")]
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
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ContactUs'.", repo.EasternOnlineBankingDashboard.ContactUsInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.ContactUs.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CallUs1'.", repo.EasternOnlineBankingDashboard.CallUs1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CallUs1Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OnlineBankingSupportHeader'.", repo.EasternOnlineBankingDashboard.OnlineBankingSupportHeaderInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OnlineBankingSupportHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SupportNumber'.", repo.EasternOnlineBankingDashboard.SupportNumberInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SupportNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='tel:+18004572043') on item 'EasternOnlineBankingDashboard.SupportNumber'.", repo.EasternOnlineBankingDashboard.SupportNumberInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SupportNumberInfo, "Href", "tel:+18004572043");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BusinessInquiriesHeader'.", repo.EasternOnlineBankingDashboard.BusinessInquiriesHeaderInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BusinessInquiriesHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BusinessInquiriesNumber'.", repo.EasternOnlineBankingDashboard.BusinessInquiriesNumberInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BusinessInquiriesNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='tel:+18003338000') on item 'EasternOnlineBankingDashboard.BusinessInquiriesNumber'.", repo.EasternOnlineBankingDashboard.BusinessInquiriesNumberInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BusinessInquiriesNumberInfo, "Href", "tel:+18003338000");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DaysAvailable'.", repo.EasternOnlineBankingDashboard.DaysAvailableInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DaysAvailableInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HoursAvailable'.", repo.EasternOnlineBankingDashboard.HoursAvailableInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HoursAvailableInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AutomatedAccountInfo'.", repo.EasternOnlineBankingDashboard.AutomatedAccountInfoInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AutomatedAccountInfoInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AutomatedAccountNumber'.", repo.EasternOnlineBankingDashboard.AutomatedAccountNumberInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AutomatedAccountNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

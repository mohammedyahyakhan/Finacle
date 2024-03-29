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

namespace CRIF
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ContactInfoDataEntry recording.
    /// </summary>
    [TestModule("1e7911a6-1bdf-4c86-918f-8c2216bd1bac", ModuleType.Recording, 1)]
    public partial class ContactInfoDataEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static ContactInfoDataEntry instance = new ContactInfoDataEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ContactInfoDataEntry()
        {
            Email = "Test";
            Phone = "";
            Address = "";
            City = "";
            State = "";
            Zip = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ContactInfoDataEntry Instance
        {
            get { return instance; }
        }

#region Variables

        string _Email;

        /// <summary>
        /// Gets or sets the value of variable Email.
        /// </summary>
        [TestVariable("65712485-964a-4966-b88f-2c50cad9b1dd")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        string _Phone;

        /// <summary>
        /// Gets or sets the value of variable Phone.
        /// </summary>
        [TestVariable("17a92d8f-1e55-4a31-b3e2-b60cca2729a3")]
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        string _Address;

        /// <summary>
        /// Gets or sets the value of variable Address.
        /// </summary>
        [TestVariable("bed0d2f0-439a-4ee0-929b-38a68639b264")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        string _City;

        /// <summary>
        /// Gets or sets the value of variable City.
        /// </summary>
        [TestVariable("6e60214e-8cef-434f-acfd-2e7919498e65")]
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        string _Zip;

        /// <summary>
        /// Gets or sets the value of variable Zip.
        /// </summary>
        [TestVariable("1b4f1788-8f01-4755-9e6a-7c7fbdc1c62b")]
        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable State.
        /// </summary>
        [TestVariable("47aee246-392f-498a-a33c-9181fabb48d0")]
        public string State
        {
            get { return repo.State; }
            set { repo.State = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBox' at Center.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Email' with focus on 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBoxInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBox.PressKeys(Email);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBox' at Center.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBoxInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Phone' with focus on 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBoxInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBox.PressKeys(Phone);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBox' at Center.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBoxInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Address' with focus on 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBoxInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBox.PressKeys(Address);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBox' at Center.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBoxInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$City' with focus on 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBoxInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBox.PressKeys(City);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateDropdown' at Center.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateDropdownInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateDropdown.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StateCrifDetailsFirstMA'.", repo.EasternOnlineBankingDashboard.StateCrifDetailsFirstMAInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StateCrifDetailsFirstMAInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$State) on item 'EasternOnlineBankingDashboard.SpanTagMA1'.", repo.EasternOnlineBankingDashboard.SpanTagMA1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SpanTagMA1Info, "InnerText", State);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.StateCrifDetailsFirstMA' at Center.", repo.EasternOnlineBankingDashboard.StateCrifDetailsFirstMAInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.StateCrifDetailsFirstMA.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBox' at Center.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBoxInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Zip' with focus on 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBoxInfo, new RecordItemIndex(18));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBox.PressKeys(Zip);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

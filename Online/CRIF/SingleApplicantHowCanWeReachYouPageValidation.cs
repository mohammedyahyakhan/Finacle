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
    ///The SingleApplicantHowCanWeReachYouPageValidation recording.
    /// </summary>
    [TestModule("16800796-035d-4ac7-a137-55f3afad843c", ModuleType.Recording, 1)]
    public partial class SingleApplicantHowCanWeReachYouPageValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static SingleApplicantHowCanWeReachYouPageValidation instance = new SingleApplicantHowCanWeReachYouPageValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SingleApplicantHowCanWeReachYouPageValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SingleApplicantHowCanWeReachYouPageValidation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.ContactInformationPage.HowCanWeReachYouHeader'", repo.EasternOnlineBankingDashboard.ContactInformationPage.HowCanWeReachYouHeaderInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ContactInformationPage.HowCanWeReachYouHeaderInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailHeader'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailHeaderInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBoxInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.EmailInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneNumberHeader'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneNumberHeaderInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneNumberHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBoxInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.HomePhoneInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1Header'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1HeaderInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1HeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBoxInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine1InputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine2Header'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine2HeaderInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine2HeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine2InputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine2InputBoxInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.MailingAddressLine2InputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityHeader'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityHeaderInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBoxInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CityInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateHeader'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateHeaderInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateDropdown'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateDropdownInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.StateDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeHeader'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeHeaderInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBox'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBoxInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.ZipCodeInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CurrentAddressCheckboxUnchecked'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CurrentAddressCheckboxUncheckedInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.CurrentAddressCheckboxUncheckedInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.SameAsMailingAddressMessage'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.SameAsMailingAddressMessageInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.JustMeContactInfo.SameAsMailingAddressMessageInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.BackButton'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.BackButtonInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.BackButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ContactInformationPage.SingleApplicantContinueButton'.", repo.EasternOnlineBankingDashboard.ContactInformationPage.SingleApplicantContinueButtonInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ContactInformationPage.SingleApplicantContinueButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

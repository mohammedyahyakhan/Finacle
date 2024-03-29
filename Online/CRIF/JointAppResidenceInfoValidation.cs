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
    ///The JointAppResidenceInfoValidation recording.
    /// </summary>
    [TestModule("c4d59760-3ad1-49b7-ab89-aeb8a80536ac", ModuleType.Recording, 1)]
    public partial class JointAppResidenceInfoValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static JointAppResidenceInfoValidation instance = new JointAppResidenceInfoValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public JointAppResidenceInfoValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static JointAppResidenceInfoValidation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.PrimaryApplicantHeader'", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.PrimaryApplicantHeaderInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.PrimaryApplicantHeaderInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.RentOrOwnHeader'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.RentOrOwnHeaderInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.RentOrOwnHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.RentOrOwnDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.RentOrOwnDropdownInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.RentOrOwnDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CurrentAddressLine1Header'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CurrentAddressLine1HeaderInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CurrentAddressLine1HeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CurrentAddressLine1InputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CurrentAddressLine1InputBoxInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CurrentAddressLine1InputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CityInputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CityInputBoxInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.CityInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.StateDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.StateDropdownInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.StateDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.ZipCodeInputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.ZipCodeInputBoxInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.ZipCodeInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthlyRentMortgagePaymentsHeader'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthlyRentMortgagePaymentsHeaderInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthlyRentMortgagePaymentsHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthlyRentMortgagePaymentsInputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthlyRentMortgagePaymentsInputBoxInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthlyRentMortgagePaymentsInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.HowLongHaveYouLivedHereHeader'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.HowLongHaveYouLivedHereHeaderInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.HowLongHaveYouLivedHereHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.YearsDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.YearsDropdownInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.YearsDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthsDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthsDropdownInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.PrimaryApplicantResidentInformation.MonthsDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.JointApplicantHeader'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.JointApplicantHeaderInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.JointApplicantHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.SameAsPrimaryApplicantCheckbox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.SameAsPrimaryApplicantCheckboxInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.SameAsPrimaryApplicantCheckboxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.SameAsPrimaryApplicant'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.SameAsPrimaryApplicantInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.SameAsPrimaryApplicantInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.RentOrOwnHeader'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.RentOrOwnHeaderInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.RentOrOwnHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.RentOrOwnDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.RentOrOwnDropdownInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.RentOrOwnDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CurrentAddressLine1Header'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CurrentAddressLine1HeaderInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CurrentAddressLine1HeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CurrentAddressLine1InputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CurrentAddressLine1InputBoxInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CurrentAddressLine1InputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CityInputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CityInputBoxInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.CityInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.StateDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.StateDropdownInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.StateDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.ZipCodeInputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.ZipCodeInputBoxInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.ZipCodeInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthlyRentMortgagePaymentsHeader'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthlyRentMortgagePaymentsHeaderInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthlyRentMortgagePaymentsHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthlyRentMortgagePaymentsInputBox'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthlyRentMortgagePaymentsInputBoxInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthlyRentMortgagePaymentsInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.HowLongHaveYouLivedHereHeader'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.HowLongHaveYouLivedHereHeaderInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.HowLongHaveYouLivedHereHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.YearsDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.YearsDropdownInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.YearsDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthsDropdown'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthsDropdownInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.SecondaryApplicantResidentInformation.MonthsDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.BackButton'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.BackButtonInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.BackButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.ContinueButton'.", repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.ContinueButtonInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ResidentInformationPage.JointApplicationResidentInformation.ContinueButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The ReviewAndSubmitJointApplicantValidation recording.
    /// </summary>
    [TestModule("a1da2df5-43b5-47c3-ac8d-563cb4609088", ModuleType.Recording, 1)]
    public partial class ReviewAndSubmitJointApplicantValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static ReviewAndSubmitJointApplicantValidation instance = new ReviewAndSubmitJointApplicantValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReviewAndSubmitJointApplicantValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReviewAndSubmitJointApplicantValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.FinalStepSubmitYourApplicationHeader'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.FinalStepSubmitYourApplicationHeaderInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.FinalStepSubmitYourApplicationHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProgressBar.ReviewAndSubmit'.", repo.EasternOnlineBankingDashboard.ProgressBar.ReviewAndSubmitInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProgressBar.ReviewAndSubmitInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.ProgressBar100'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.ProgressBar100Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.ProgressBar100Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.Name'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.NameInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.NameInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.LoanAmount'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.LoanAmountInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.LoanAmountInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.LoanTerm'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.LoanTermInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.LoanTermInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant1'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant1Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.HomePhoneNumber'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.HomePhoneNumberInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.HomePhoneNumberInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant2HomePhoneNumber'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant2HomePhoneNumberInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant2HomePhoneNumberInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.EmailAddress'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.EmailAddressInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.EmailAddressInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant2EmailAddress'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant2EmailAddressInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.Applicant2EmailAddressInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.Address'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.AddressInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.AddressInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.WhereWouldYouLikeToCloseThisLoanHeader'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.WhereWouldYouLikeToCloseThisLoanHeaderInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.WhereWouldYouLikeToCloseThisLoanHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.FindABranchNearYouLink'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.FindABranchNearYouLinkInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.FindABranchNearYouLinkInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.BranchDropdown'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.BranchDropdownInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.BranchDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.WouldYouLikeToPayForThisLoanUsingAutopayHeader'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.WouldYouLikeToPayForThisLoanUsingAutopayHeaderInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.WouldYouLikeToPayForThisLoanUsingAutopayHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.AutopayOptionsDropdown'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.AutopayOptionsDropdownInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.AutopayOptionsDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditionsCheckbox'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditionsCheckboxInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditionsCheckboxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TermsAndConditions'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TermsAndConditionsInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TermsAndConditionsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine1'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine1Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine1Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine2'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine2Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine2Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine3'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine3Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine3Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine4'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine4Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine4Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine5'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine5Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine5Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine6'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine6Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.TermsAndConditions.TCLine6Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -10920 units.", new RecordItemIndex(25));
            Mouse.ScrollWheel(-10920);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(26));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.BackButton'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.BackButtonInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.BackButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ReviewAndSubmitPage.SubmitApplicationButton'.", repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.SubmitApplicationButtonInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ReviewAndSubmitPage.SubmitApplicationButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

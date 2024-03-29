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

namespace NewAccountOpening
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FundAccountModalValidation recording.
    /// </summary>
    [TestModule("d110617f-2bfd-4c9a-a6e5-6dd0361276cd", ModuleType.Recording, 1)]
    public partial class FundAccountModalValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewAccountOpeningRepository repository.
        /// </summary>
        public static NewAccountOpeningRepository repo = NewAccountOpeningRepository.Instance;

        static FundAccountModalValidation instance = new FundAccountModalValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FundAccountModalValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FundAccountModalValidation Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CheckingAccountType.
        /// </summary>
        [TestVariable("ac9a8903-b4fb-46dc-84a0-866e8fdf3c27")]
        public string CheckingAccountType
        {
            get { return repo.CheckingAccountType; }
            set { repo.CheckingAccountType = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Title.
        /// </summary>
        [TestVariable("4e1183da-5db6-410d-856a-bcc6ac8b0952")]
        public string Title
        {
            get { return repo.Title; }
            set { repo.Title = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FundAccountType.
        /// </summary>
        [TestVariable("82ad4b65-e8d1-49b7-ad2b-953324d75709")]
        public string FundAccountType
        {
            get { return repo.FundAccountType; }
            set { repo.FundAccountType = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable OpeningDeposit.
        /// </summary>
        [TestVariable("da642fff-a51a-4290-93d5-a2cb35b19a63")]
        public string OpeningDeposit
        {
            get { return repo.OpeningDeposit; }
            set { repo.OpeningDeposit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DepositButton1.
        /// </summary>
        [TestVariable("3a3edcb0-b002-48e6-9f5f-4e7f257b0ef6")]
        public string DepositButton1
        {
            get { return repo.DepositButton1; }
            set { repo.DepositButton1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DepositButton2.
        /// </summary>
        [TestVariable("9ab817cc-deb5-4af9-9868-403cabea073a")]
        public string DepositButton2
        {
            get { return repo.DepositButton2; }
            set { repo.DepositButton2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DepositButton3.
        /// </summary>
        [TestVariable("b26d076b-103f-4f63-a022-3e70e0534e7a")]
        public string DepositButton3
        {
            get { return repo.DepositButton3; }
            set { repo.DepositButton3 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DepositButton4.
        /// </summary>
        [TestVariable("54500081-327d-4206-86d4-48bb826f8a3f")]
        public string DepositButton4
        {
            get { return repo.DepositButton4; }
            set { repo.DepositButton4 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DepositButton5.
        /// </summary>
        [TestVariable("6f9d5f28-5cc4-49fb-a6a9-84938edb4ee5")]
        public string DepositButton5
        {
            get { return repo.DepositButton5; }
            set { repo.DepositButton5 = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.NewAccountTypePickerModal.AccountPickerModal.CheckingAccountVariable'.", repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.AccountPickerModal.CheckingAccountVariableInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.AccountPickerModal.CheckingAccountVariable.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.OpenAccountHeaderVariable'", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.OpenAccountHeaderVariableInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.OpenAccountHeaderVariableInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.FundAccount'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.FundAccountInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.FundAccountInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.ReviewAndSubmit'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.ReviewAndSubmitInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.ReviewAndSubmitInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar.SelfInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar.StepOne'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar.StepOneInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar.StepOneInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.BecauseYouAlreadyHaveAnAccountWithEastern'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.BecauseYouAlreadyHaveAnAccountWithEasternInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.BecauseYouAlreadyHaveAnAccountWithEasternInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundYourNewAccountHeader'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundYourNewAccountHeaderInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundYourNewAccountHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.EasternBankFundAccountTypeVariable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.EasternBankFundAccountTypeVariableInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.EasternBankFundAccountTypeVariableInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.OpeningDepositVariable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.OpeningDepositVariableInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.OpeningDepositVariableInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.WhichAccountWouldYouLikeToTransferFundsFrom'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.WhichAccountWouldYouLikeToTransferFundsFromInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.WhichAccountWouldYouLikeToTransferFundsFromInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundTransferAccountDropdown'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundTransferAccountDropdownInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FundTransferAccountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.HowMuchWouldYouLikeToDeposit'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.HowMuchWouldYouLikeToDepositInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.HowMuchWouldYouLikeToDepositInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton1Variable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton1VariableInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton1VariableInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton2Variable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton2VariableInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton2VariableInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton3Variable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton3VariableInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton3VariableInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton4Variable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton4VariableInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton4VariableInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton5Variable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton5VariableInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.DepositButton5VariableInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.CustomAmount'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.CustomAmountInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.CustomAmountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.CustomAmount'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.CustomAmountInfo, new RecordItemIndex(19));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountOptions.CustomAmount.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBoxInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.AmountInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FreeCheckingAccountDisclosureLink'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FreeCheckingAccountDisclosureLinkInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FreeCheckingAccountDisclosureLinkInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.easternbank.com/media/7716') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FreeCheckingAccountDisclosureLink'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FreeCheckingAccountDisclosureLinkInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.FreeCheckingAccountDisclosureLinkInfo, "Href", "https://www.easternbank.com/media/7716");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.ToReviewWhich'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.ToReviewWhichInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.ToReviewWhichInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.TermsDisabledCheckbox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.TermsDisabledCheckboxInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.TermsDisabledCheckboxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.IAgreeTermsFreeCheckingAccountDisclosure'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.IAgreeTermsFreeCheckingAccountDisclosureInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.FundAccount.IAgreeTermsFreeCheckingAccountDisclosureInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.BackButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.BackButtonInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.BackButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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

namespace EasternBankRegression.Module_Recordings.MajorModules.AccountsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectDebitPinEnterSelectOverdraft recording.
    /// </summary>
    [TestModule("56257a92-e94d-4752-8dfe-808de96a2c4f", ModuleType.Recording, 1)]
    public partial class SelectDebitPinEnterSelectOverdraft : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static SelectDebitPinEnterSelectOverdraft instance = new SelectDebitPinEnterSelectOverdraft();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectDebitPinEnterSelectOverdraft()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectDebitPinEnterSelectOverdraft Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable DebitCardType.
        /// </summary>
        [TestVariable("42e570e6-b566-4b60-88f3-9610e5999eb2")]
        public string DebitCardType
        {
            get { return repo.DebitCardType; }
            set { repo.DebitCardType = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.NextButton' at Center.", repo.EasternOnlineBankingDashboard.NextButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DebitCardSetup'.", repo.EasternOnlineBankingDashboard.DebitCardSetupInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DebitCardSetupInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProgressBar'.", repo.EasternOnlineBankingDashboard.ProgressBar.SelfInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProgressBar.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.MasterCardVariable'.", repo.EasternOnlineBankingDashboard.MasterCardVariableInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.MasterCardVariableInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ThisAccountComesWithAComplimentary'.", repo.EasternOnlineBankingDashboard.ThisAccountComesWithAComplimentaryInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ThisAccountComesWithAComplimentaryInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.WouldYouLikeANewDebitCardForThis'.", repo.EasternOnlineBankingDashboard.WouldYouLikeANewDebitCardForThisInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.WouldYouLikeANewDebitCardForThisInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DebitCardYesButton'.", repo.EasternOnlineBankingDashboard.DebitCardYesButtonInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DebitCardYesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DebitCardNoButton'.", repo.EasternOnlineBankingDashboard.DebitCardNoButtonInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DebitCardNoButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ThisDebitCardWillBeSentToYourAddressOnFile'.", repo.EasternOnlineBankingDashboard.ThisDebitCardWillBeSentToYourAddressOnFileInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ThisDebitCardWillBeSentToYourAddressOnFileInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AddressLine'.", repo.EasternOnlineBankingDashboard.AddressLineInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AddressLineInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.IsTheAddressOnFileYourCurrentMail'.", repo.EasternOnlineBankingDashboard.IsTheAddressOnFileYourCurrentMailInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.IsTheAddressOnFileYourCurrentMailInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CurrentMailingAddressYesButton'.", repo.EasternOnlineBankingDashboard.CurrentMailingAddressYesButtonInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CurrentMailingAddressYesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CurrentMailingAddressNoButton'.", repo.EasternOnlineBankingDashboard.CurrentMailingAddressNoButtonInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CurrentMailingAddressNoButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SetUp4DigitPinHeader'.", repo.EasternOnlineBankingDashboard.SetUp4DigitPinHeaderInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SetUp4DigitPinHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PinInputBox'.", repo.EasternOnlineBankingDashboard.PinInputBoxInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PinInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmPinHeader'.", repo.EasternOnlineBankingDashboard.ConfirmPinHeaderInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmPinHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ConfirmPinInputBox'.", repo.EasternOnlineBankingDashboard.ConfirmPinInputBoxInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ConfirmPinInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingDashboard.PinInputBox'.", repo.EasternOnlineBankingDashboard.PinInputBoxInfo, new RecordItemIndex(17));
            repo.EasternOnlineBankingDashboard.PinInputBox.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingDashboard.ConfirmPinInputBox'.", repo.EasternOnlineBankingDashboard.ConfirmPinInputBoxInfo, new RecordItemIndex(18));
            repo.EasternOnlineBankingDashboard.ConfirmPinInputBox.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.NextButton'.", repo.EasternOnlineBankingDashboard.NextButtonInfo, new RecordItemIndex(19));
            repo.EasternOnlineBankingDashboard.NextButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PleaseFillOutRequiredFieldsError'.", repo.EasternOnlineBankingDashboard.PleaseFillOutRequiredFieldsErrorInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PleaseFillOutRequiredFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1234' on item 'EasternOnlineBankingDashboard.PinInputBox'.", repo.EasternOnlineBankingDashboard.PinInputBoxInfo, new RecordItemIndex(21));
            repo.EasternOnlineBankingDashboard.PinInputBox.Element.SetAttributeValue("TagValue", "1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1235' on item 'EasternOnlineBankingDashboard.ConfirmPinInputBox'.", repo.EasternOnlineBankingDashboard.ConfirmPinInputBoxInfo, new RecordItemIndex(22));
            repo.EasternOnlineBankingDashboard.ConfirmPinInputBox.Element.SetAttributeValue("TagValue", "1235");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.NextButton'.", repo.EasternOnlineBankingDashboard.NextButtonInfo, new RecordItemIndex(23));
            repo.EasternOnlineBankingDashboard.NextButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.MatchingPinsError'.", repo.EasternOnlineBankingDashboard.MatchingPinsErrorInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.MatchingPinsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '123' on item 'EasternOnlineBankingDashboard.PinInputBox'.", repo.EasternOnlineBankingDashboard.PinInputBoxInfo, new RecordItemIndex(25));
            repo.EasternOnlineBankingDashboard.PinInputBox.Element.SetAttributeValue("TagValue", "123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.NextButton'.", repo.EasternOnlineBankingDashboard.NextButtonInfo, new RecordItemIndex(26));
            repo.EasternOnlineBankingDashboard.NextButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PleaseEnterA4DigitPinError'.", repo.EasternOnlineBankingDashboard.PleaseEnterA4DigitPinErrorInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PleaseEnterA4DigitPinErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1234' on item 'EasternOnlineBankingDashboard.PinInputBox'.", repo.EasternOnlineBankingDashboard.PinInputBoxInfo, new RecordItemIndex(28));
            repo.EasternOnlineBankingDashboard.PinInputBox.Element.SetAttributeValue("TagValue", "1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1234' on item 'EasternOnlineBankingDashboard.ConfirmPinInputBox'.", repo.EasternOnlineBankingDashboard.ConfirmPinInputBoxInfo, new RecordItemIndex(29));
            repo.EasternOnlineBankingDashboard.ConfirmPinInputBox.Element.SetAttributeValue("TagValue", "1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.NextButton' at Center.", repo.EasternOnlineBankingDashboard.NextButtonInfo, new RecordItemIndex(30));
            repo.EasternOnlineBankingDashboard.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.Overdrafts'.", repo.EasternOnlineBankingDashboard.OverdraftsInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OverdraftsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProgressBar'.", repo.EasternOnlineBankingDashboard.ProgressBar.SelfInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProgressBar.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OverdraftSettings'.", repo.EasternOnlineBankingDashboard.OverdraftSettingsInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OverdraftSettingsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OverdraftExplanation'.", repo.EasternOnlineBankingDashboard.OverdraftExplanationInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OverdraftExplanationInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OverdraftAgreementLink'.", repo.EasternOnlineBankingDashboard.OverdraftAgreementLinkInfo, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OverdraftAgreementLinkInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StandardOverdraftPracticesExplanation'.", repo.EasternOnlineBankingDashboard.StandardOverdraftPracticesExplanationInfo, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StandardOverdraftPracticesExplanationInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DoYouWantUsToPayOverdraftsOnAtm'.", repo.EasternOnlineBankingDashboard.DoYouWantUsToPayOverdraftsOnAtmInfo, new RecordItemIndex(37));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DoYouWantUsToPayOverdraftsOnAtmInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OverdraftYes'.", repo.EasternOnlineBankingDashboard.OverdraftYesInfo, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OverdraftYesInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OverdraftNo'.", repo.EasternOnlineBankingDashboard.OverdraftNoInfo, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OverdraftNoInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OverdraftAgreementLink'.", repo.EasternOnlineBankingDashboard.OverdraftAgreementLinkInfo, new RecordItemIndex(40));
            repo.EasternOnlineBankingDashboard.OverdraftAgreementLink.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

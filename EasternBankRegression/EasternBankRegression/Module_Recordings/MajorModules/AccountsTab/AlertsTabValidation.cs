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
    ///The AlertsTabValidation recording.
    /// </summary>
    [TestModule("cb38eed2-6476-4b25-88c1-3b0ff10129bf", ModuleType.Recording, 1)]
    public partial class AlertsTabValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static AlertsTabValidation instance = new AlertsTabValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AlertsTabValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AlertsTabValidation Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Accounts'.", repo.EasternOnlineBankingDashboard.AccountsInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.Accounts.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.WelcomeMessage'", repo.EasternOnlineBankingDashboard.WelcomeMessageInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.WelcomeMessageInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Grid'.", repo.EasternOnlineBankingDashboard.GridInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.Grid.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.varAccount3'", repo.EasternOnlineBankingDashboard.varAccount3Info, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.varAccount3Info.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.varAccount3'.", repo.EasternOnlineBankingDashboard.varAccount3Info, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.varAccount3.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.AccountActivityLoadingModal'.", repo.EasternOnlineBankingDashboard.AccountActivityLoadingModalInfo, new RecordItemIndex(7));
            //repo.EasternOnlineBankingDashboard.AccountActivityLoadingModal.EnsureVisible();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(8));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.AccountActivityLoadingModal' at Center.", repo.EasternOnlineBankingDashboard.AccountActivityLoadingModalInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.AccountActivityLoadingModal.Click();
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.AccountActivityLoadingModal'", repo.EasternOnlineBankingDashboard.AccountActivityLoadingModalInfo, new RecordItemIndex(10));
            //repo.EasternOnlineBankingDashboard.AccountActivityLoadingModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.BalanceHeader'", repo.EasternOnlineBankingDashboard.BalanceHeaderInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.BalanceHeaderInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.AlertsTab'.", repo.EasternOnlineBankingDashboard.AlertsTabInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.AlertsTab.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.AlertsTab'.", repo.EasternOnlineBankingDashboard.AlertsTabInfo, new RecordItemIndex(13));
            repo.EasternOnlineBankingDashboard.AlertsTab.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DoNotDisturbMode'", repo.EasternOnlineBankingDashboard.DoNotDisturbModeInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.DoNotDisturbModeInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SendAlertsToHeader'", repo.EasternOnlineBankingDashboard.SendAlertsToHeaderInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.SendAlertsToHeaderInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DoNotDisturbMode'", repo.EasternOnlineBankingDashboard.DoNotDisturbModeInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.DoNotDisturbModeInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SendAlertsToHeader'", repo.EasternOnlineBankingDashboard.SendAlertsToHeaderInfo, new RecordItemIndex(17));
            repo.EasternOnlineBankingDashboard.SendAlertsToHeaderInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditButton'.", repo.EasternOnlineBankingDashboard.EditButtonInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.DoNotDisturbSwitch'.", repo.EasternOnlineBankingDashboard.DoNotDisturbSwitchInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.DoNotDisturbSwitchInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BalanceIsBelowRow'.", repo.EasternOnlineBankingDashboard.BalanceIsBelowRowInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BalanceIsBelowRowInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BalanceIsAboveRow'.", repo.EasternOnlineBankingDashboard.BalanceIsAboveRowInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BalanceIsAboveRowInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.WhenAnOverdraftOccursRow'.", repo.EasternOnlineBankingDashboard.WhenAnOverdraftOccursRowInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.WhenAnOverdraftOccursRowInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.WhenADepositIsMadeRow'.", repo.EasternOnlineBankingDashboard.WhenADepositIsMadeRowInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.WhenADepositIsMadeRowInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.WhenAnOnlineTransferIsSentRow'.", repo.EasternOnlineBankingDashboard.WhenAnOnlineTransferIsSentRowInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.WhenAnOnlineTransferIsSentRowInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.WhenACheckNumberClearsRow'.", repo.EasternOnlineBankingDashboard.WhenACheckNumberClearsRowInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.WhenACheckNumberClearsRowInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ClearedCheckAmountAboveRow'.", repo.EasternOnlineBankingDashboard.ClearedCheckAmountAboveRowInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ClearedCheckAmountAboveRowInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.MessageAndDataRatesInfo'.", repo.EasternOnlineBankingDashboard.MessageAndDataRatesInfoInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.MessageAndDataRatesInfoInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.MessageAndDataRatesInfo'.", repo.EasternOnlineBankingDashboard.MessageAndDataRatesInfoInfo, new RecordItemIndex(28));
            repo.EasternOnlineBankingDashboard.MessageAndDataRatesInfo.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.AlertsTab'.", repo.EasternOnlineBankingDashboard.AlertsTabInfo, new RecordItemIndex(29));
            repo.EasternOnlineBankingDashboard.AlertsTab.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.EditButton'.", repo.EasternOnlineBankingDashboard.EditButtonInfo, new RecordItemIndex(30));
            repo.EasternOnlineBankingDashboard.EditButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.EditContactInformationModal'", repo.EasternOnlineBankingDashboard.EditContactInformationModal.SelfInfo, new RecordItemIndex(31));
            repo.EasternOnlineBankingDashboard.EditContactInformationModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EditContactInformationHeader'.", repo.EasternOnlineBankingDashboard.EditContactInformationHeaderInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EditContactInformationHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EmailInputBox'.", repo.EasternOnlineBankingDashboard.EmailInputBoxInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EmailInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.MobileNumberInputBox'.", repo.EasternOnlineBankingDashboard.MobileNumberInputBoxInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.MobileNumberInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelButton2'.", repo.EasternOnlineBankingDashboard.CancelButton2Info, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelButton2Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SaveButton'.", repo.EasternOnlineBankingDashboard.SaveButtonInfo, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SaveButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingDashboard.EmailInputBox'.", repo.EasternOnlineBankingDashboard.EmailInputBoxInfo, new RecordItemIndex(37));
            repo.EasternOnlineBankingDashboard.EmailInputBox.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingDashboard.MobileNumberInputBox'.", repo.EasternOnlineBankingDashboard.MobileNumberInputBoxInfo, new RecordItemIndex(38));
            repo.EasternOnlineBankingDashboard.MobileNumberInputBox.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SaveButton'.", repo.EasternOnlineBankingDashboard.SaveButtonInfo, new RecordItemIndex(39));
            repo.EasternOnlineBankingDashboard.SaveButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PleaseCorrectTheFollowingFieldsError'.", repo.EasternOnlineBankingDashboard.PleaseCorrectTheFollowingFieldsErrorInfo, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PleaseCorrectTheFollowingFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InvalidEmailAddressError'.", repo.EasternOnlineBankingDashboard.InvalidEmailAddressErrorInfo, new RecordItemIndex(41));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InvalidEmailAddressErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CancelButton2'.", repo.EasternOnlineBankingDashboard.CancelButton2Info, new RecordItemIndex(42));
            repo.EasternOnlineBankingDashboard.CancelButton2.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DoNotDisturbToggle'.", repo.EasternOnlineBankingDashboard.DoNotDisturbToggleInfo, new RecordItemIndex(43));
            repo.EasternOnlineBankingDashboard.DoNotDisturbToggle.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DoNotDisturbTime'", repo.EasternOnlineBankingDashboard.DoNotDisturbTimeInfo, new RecordItemIndex(44));
            repo.EasternOnlineBankingDashboard.DoNotDisturbTimeInfo.WaitForAttributeEqual(20000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DoNotDisturbTime'.", repo.EasternOnlineBankingDashboard.DoNotDisturbTimeInfo, new RecordItemIndex(45));
            repo.EasternOnlineBankingDashboard.DoNotDisturbTime.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.DoNotDisturbSettingsModal'", repo.EasternOnlineBankingDashboard.DoNotDisturbSettingsModal.SelfInfo, new RecordItemIndex(46));
            repo.EasternOnlineBankingDashboard.DoNotDisturbSettingsModal.SelfInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.IDoNotWantToReceiveAlertsBetween'.", repo.EasternOnlineBankingDashboard.IDoNotWantToReceiveAlertsBetweenInfo, new RecordItemIndex(47));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.IDoNotWantToReceiveAlertsBetweenInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StartTimeHour'.", repo.EasternOnlineBankingDashboard.StartTimeHourInfo, new RecordItemIndex(48));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StartTimeHourInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StartTimeMinute'.", repo.EasternOnlineBankingDashboard.StartTimeMinuteInfo, new RecordItemIndex(49));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StartTimeMinuteInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StartTimeAMPM'.", repo.EasternOnlineBankingDashboard.StartTimeAMPMInfo, new RecordItemIndex(50));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StartTimeAMPMInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EndTime'.", repo.EasternOnlineBankingDashboard.EndTimeInfo, new RecordItemIndex(51));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EndTimeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EndTimeHour'.", repo.EasternOnlineBankingDashboard.EndTimeHourInfo, new RecordItemIndex(52));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EndTimeHourInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EndTimeMinute'.", repo.EasternOnlineBankingDashboard.EndTimeMinuteInfo, new RecordItemIndex(53));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EndTimeMinuteInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EndTimeAMPM'.", repo.EasternOnlineBankingDashboard.EndTimeAMPMInfo, new RecordItemIndex(54));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EndTimeAMPMInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.TimeZoneDropdown'.", repo.EasternOnlineBankingDashboard.TimeZoneDropdownInfo, new RecordItemIndex(55));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.TimeZoneDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TimeZoneDropdown'.", repo.EasternOnlineBankingDashboard.TimeZoneDropdownInfo, new RecordItemIndex(56));
            repo.EasternOnlineBankingDashboard.TimeZoneDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.PacificTime'.", repo.EasternOnlineBankingDashboard.PacificTimeInfo, new RecordItemIndex(57));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.PacificTimeInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.MountainTime'.", repo.EasternOnlineBankingDashboard.MountainTimeInfo, new RecordItemIndex(58));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.MountainTimeInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CentralTime'.", repo.EasternOnlineBankingDashboard.CentralTimeInfo, new RecordItemIndex(59));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CentralTimeInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.EasternTime'.", repo.EasternOnlineBankingDashboard.EasternTimeInfo, new RecordItemIndex(60));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.EasternTimeInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TimeZoneDropdown'.", repo.EasternOnlineBankingDashboard.TimeZoneDropdownInfo, new RecordItemIndex(61));
            repo.EasternOnlineBankingDashboard.TimeZoneDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelButton3'.", repo.EasternOnlineBankingDashboard.CancelButton3Info, new RecordItemIndex(62));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelButton3Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SaveButton1'.", repo.EasternOnlineBankingDashboard.SaveButton1Info, new RecordItemIndex(63));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SaveButton1Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CancelButton3'.", repo.EasternOnlineBankingDashboard.CancelButton3Info, new RecordItemIndex(64));
            repo.EasternOnlineBankingDashboard.CancelButton3.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(65));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.DoNotDisturbToggle'.", repo.EasternOnlineBankingDashboard.DoNotDisturbToggleInfo, new RecordItemIndex(66));
            repo.EasternOnlineBankingDashboard.DoNotDisturbToggle.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
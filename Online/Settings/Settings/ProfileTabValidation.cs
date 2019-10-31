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

namespace Settings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ProfileTabValidation recording.
    /// </summary>
    [TestModule("835920a0-243d-488c-bde9-fbba1fbf99c1", ModuleType.Recording, 1)]
    public partial class ProfileTabValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SettingsRepository repository.
        /// </summary>
        public static SettingsRepository repo = SettingsRepository.Instance;

        static ProfileTabValidation instance = new ProfileTabValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ProfileTabValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ProfileTabValidation Instance
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
            Mouse.DefaultMoveTime = 10;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SettingsHeader'.", repo.EasternOnlineBankingDashboard.SettingsHeaderInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SettingsHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SettingsTabs.ProfileTab'.", repo.EasternOnlineBankingDashboard.SettingsTabs.ProfileTabInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SettingsTabs.ProfileTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SettingsTabs.ManageStatementsTab'.", repo.EasternOnlineBankingDashboard.SettingsTabs.ManageStatementsTabInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SettingsTabs.ManageStatementsTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SettingsTabs.ManageOverdraftsTab'.", repo.EasternOnlineBankingDashboard.SettingsTabs.ManageOverdraftsTabInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SettingsTabs.ManageOverdraftsTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SettingsTabs.AlertsTab'.", repo.EasternOnlineBankingDashboard.SettingsTabs.AlertsTabInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SettingsTabs.AlertsTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SettingsTabs.ManageAccountsTab'.", repo.EasternOnlineBankingDashboard.SettingsTabs.ManageAccountsTabInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SettingsTabs.ManageAccountsTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.SecurityInformationHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.SecurityInformationHeaderInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.SecurityInformationHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.UsernameHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.UsernameHeaderInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.UsernameHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.EditUsernameButton'.", repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.EditUsernameButtonInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.EditUsernameButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.PasswordHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.PasswordHeaderInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.PasswordHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.EditPasswordButton'.", repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.EditPasswordButtonInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.SecurityInformation.EditPasswordButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.ContactInformationHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.ContactInformationHeaderInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.ContactInformationHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EmailHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EmailHeaderInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EmailHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EditEmailButton'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EditEmailButtonInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EditEmailButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.PhoneHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.PhoneHeaderInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.PhoneHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.MobileLabel'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.MobileLabelInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.MobileLabelInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.HomeLabel'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.HomeLabelInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.HomeLabelInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.WorkLabel'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.WorkLabelInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.WorkLabelInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.InternationalLabel'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.InternationalLabelInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.InternationalLabelInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EditContactInfoButton'.", repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EditContactInfoButtonInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.ContactInformation.EditContactInfoButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategoriesHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategoriesHeaderInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategoriesHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.ManageCategoriesButton'.", repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.ManageCategoriesButtonInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.ManageCategoriesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategorySwitch'.", repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategorySwitchInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.TransactionCategorySwitchInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.DisplayCategoriesInAccountActivity'.", repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.DisplayCategoriesInAccountActivityInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.TransactionCategories.DisplayCategoriesInAccountActivityInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultAccountHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultAccountHeaderInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultAccountHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultAccountITag'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultAccountITagInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultAccountITagInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountHeaderInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountDropdownInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultTransferAccountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillPayAccountHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillPayAccountHeaderInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillPayAccountHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillpayAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillpayAccountDropdownInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultBillpayAccountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountHeader'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountHeaderInfo, new RecordItemIndex(30));
            //Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountHeaderInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdown'.", repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdownInfo, new RecordItemIndex(31));
            //Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ProfilePage.DefaultAccount.DefaultZelleAccountDropdownInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
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

namespace AccountsTestSuite.ActivityTab.ReportModal
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BankingReportModalValidation recording.
    /// </summary>
    [TestModule("22d4e6a3-e3ec-41f3-9287-c378f6162b5b", ModuleType.Recording, 1)]
    public partial class BankingReportModalValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static BankingReportModalValidation instance = new BankingReportModalValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BankingReportModalValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BankingReportModalValidation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal'", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.SelfInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.SelfInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.IfACategoryHasNoTransactionsAssoci'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.IfACategoryHasNoTransactionsAssociInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.IfACategoryHasNoTransactionsAssociInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.TotalSelectedExpenseCategories'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.TotalSelectedExpenseCategoriesInfo, new RecordItemIndex(2));
            Validate.Exists(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.TotalSelectedExpenseCategoriesInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.CancelButton'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.CancelButtonInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.CancelButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.PrintReportButton'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.PrintReportButtonInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.PrintReportButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.CancelButton'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.CancelButtonInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ReportModal.CancelButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

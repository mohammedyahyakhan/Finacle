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

namespace AdvancedSearch.ActivityTab.AdvancedSearchDropdown.TransactionTypeDropdown
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TransactionTypeValidation recording.
    /// </summary>
    [TestModule("5f89bc91-ef9e-4758-a248-76621279b633", ModuleType.Recording, 1)]
    public partial class TransactionTypeValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AdvancedSearch.AdvancedSearchRepository repository.
        /// </summary>
        public static global::AdvancedSearch.AdvancedSearchRepository repo = global::AdvancedSearch.AdvancedSearchRepository.Instance;

        static TransactionTypeValidation instance = new TransactionTypeValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TransactionTypeValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TransactionTypeValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllTransactions'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllTransactionsInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllTransactionsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllDeposits'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllDepositsInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllDepositsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllWithdrawals'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllWithdrawalsInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AllWithdrawalsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.Atm'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AtmInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.AtmInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.Checks'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.ChecksInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.ChecksInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.DebitCard'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.DebitCardInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.DebitCardInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.ElectronicPayments'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.ElectronicPaymentsInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.ElectronicPaymentsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.Transfers'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.TransfersInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.TransfersInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.Wires'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.WiresInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TransactionTypeList.WiresInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

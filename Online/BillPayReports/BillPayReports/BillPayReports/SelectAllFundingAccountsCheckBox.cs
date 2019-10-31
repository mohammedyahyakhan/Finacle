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

namespace BillPayReports
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectAllFundingAccountsCheckBox recording.
    /// </summary>
    [TestModule("df51e090-aea8-4b81-a852-72f1767b8a6b", ModuleType.Recording, 1)]
    public partial class SelectAllFundingAccountsCheckbox : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayReportsRepository repository.
        /// </summary>
        public static BillPayReportsRepository repo = BillPayReportsRepository.Instance;

        static SelectAllFundingAccountsCheckbox instance = new SelectAllFundingAccountsCheckbox();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectAllFundingAccountsCheckbox()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectAllFundingAccountsCheckbox Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SelectAllFundingAccountsCheckbox'.", repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SelectAllFundingAccountsCheckboxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SelectAllFundingAccountsCheckbox.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
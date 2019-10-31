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

namespace BillPayTestSuite
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DiscoverCompanyPayeeDataEntry recording.
    /// </summary>
    [TestModule("1decb871-3340-4f38-bd14-7f1851a7d309", ModuleType.Recording, 1)]
    public partial class DiscoverCompanyPayeeDataEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayTestSuiteRepository repository.
        /// </summary>
        public static BillPayTestSuiteRepository repo = BillPayTestSuiteRepository.Instance;

        static DiscoverCompanyPayeeDataEntry instance = new DiscoverCompanyPayeeDataEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DiscoverCompanyPayeeDataEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DiscoverCompanyPayeeDataEntry Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBox'.", repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBoxInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBox'.", repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBoxInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '6011208954052457' with focus on 'EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBox'.", repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBoxInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.AccountNumberInputBox.PressKeys("6011208954052457");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.AddCompanyPayeeModal.PayeeNicknameInputBox'.", repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.PayeeNicknameInputBoxInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.PayeeNicknameInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Aaa Discover Credit Card 123' with focus on 'EasternOnlineBankingDashboard.AddCompanyPayeeModal.PayeeNicknameInputBox'.", repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.PayeeNicknameInputBoxInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.AddCompanyPayeeModal.PayeeNicknameInputBox.PressKeys("Aaa Discover Credit Card 123");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
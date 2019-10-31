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

namespace BillPayTestSuite.BillPayTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BillPayTabValidation recording.
    /// </summary>
    [TestModule("15e2b2c6-7935-4566-bfda-19a73e933d54", ModuleType.Recording, 1)]
    public partial class BillPayTabValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::BillPayTestSuite.BillPayTestSuiteRepository repository.
        /// </summary>
        public static global::BillPayTestSuite.BillPayTestSuiteRepository repo = global::BillPayTestSuite.BillPayTestSuiteRepository.Instance;

        static BillPayTabValidation instance = new BillPayTabValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BillPayTabValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BillPayTabValidation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.BillPayTabs.BillPayTab'", repo.EasternOnlineBankingDashboard.BillPayTabs.BillPayTabInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.BillPayTabs.BillPayTabInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTabs.ScheduledTab'.", repo.EasternOnlineBankingDashboard.BillPayTabs.ScheduledTabInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTabs.ScheduledTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTabs.HistoryTab'.", repo.EasternOnlineBankingDashboard.BillPayTabs.HistoryTabInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTabs.HistoryTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTabs.NotificationsTab'.", repo.EasternOnlineBankingDashboard.BillPayTabs.NotificationsTabInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTabs.NotificationsTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTabs.ReportsTab'.", repo.EasternOnlineBankingDashboard.BillPayTabs.ReportsTabInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTabs.ReportsTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.PendingPaymentsHeader'.", repo.EasternOnlineBankingDashboard.BillPayTab.PendingPaymentsHeaderInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.PendingPaymentsHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.CompletedPaymentsHeader'.", repo.EasternOnlineBankingDashboard.BillPayTab.CompletedPaymentsHeaderInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.CompletedPaymentsHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.AddPayeeButton'.", repo.EasternOnlineBankingDashboard.BillPayTab.AddPayeeButtonInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.AddPayeeButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.BillpaySearchInputBox'.", repo.EasternOnlineBankingDashboard.BillPayTab.BillpaySearchInputBoxInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.BillpaySearchInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.BillpayAccountDropdown'.", repo.EasternOnlineBankingDashboard.BillPayTab.BillpayAccountDropdownInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.BillpayAccountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown'.", repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.SelfInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdown'.", repo.EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdownInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdownInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdown'.", repo.EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdownInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.SortByOptions.Name'.", repo.EasternOnlineBankingDashboard.BillPayTab.SortByOptions.NameInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.SortByOptions.NameInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.SortByOptions.LastPaid'.", repo.EasternOnlineBankingDashboard.BillPayTab.SortByOptions.LastPaidInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.SortByOptions.LastPaidInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.SortByOptions.DueDate'.", repo.EasternOnlineBankingDashboard.BillPayTab.SortByOptions.DueDateInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.SortByOptions.DueDateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdown'.", repo.EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdownInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.BillPayTab.SortByFilterDropdown.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown1'.", repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown1Info, new RecordItemIndex(17));
            repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown1.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.ActivePayeesOnly'.", repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.ActivePayeesOnlyInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.ActivePayeesOnlyInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.InactivePayeesOnly'.", repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.InactivePayeesOnlyInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown.InactivePayeesOnlyInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown1'.", repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown1Info, new RecordItemIndex(20));
            repo.EasternOnlineBankingDashboard.BillPayTab.ShowSortDropdown1.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The HistoryTabAdvancedSearchValidation recording.
    /// </summary>
    [TestModule("dbb6010a-75ac-4d71-9dc2-2ecd7a12aa17", ModuleType.Recording, 1)]
    public partial class HistoryTabAdvancedSearchValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayTestSuiteRepository repository.
        /// </summary>
        public static BillPayTestSuiteRepository repo = BillPayTestSuiteRepository.Instance;

        static HistoryTabAdvancedSearchValidation instance = new HistoryTabAdvancedSearchValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HistoryTabAdvancedSearchValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HistoryTabAdvancedSearchValidation Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.HistoryTab.HistorySearchInputBox' at Center.", repo.EasternOnlineBankingDashboard.HistoryTab.HistorySearchInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.HistoryTab.HistorySearchInputBox.Click(10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.HistoryTab.FilterButton'", repo.EasternOnlineBankingDashboard.HistoryTab.FilterButtonInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.HistoryTab.FilterButtonInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'EasternOnlineBankingDashboard.HistoryTab.FilterButton'.", repo.EasternOnlineBankingDashboard.HistoryTab.FilterButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.FilterButtonInfo, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.HistoryTab.FilterButton' at Center.", repo.EasternOnlineBankingDashboard.HistoryTab.FilterButtonInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.HistoryTab.FilterButton.Click(10);
            Delay.Milliseconds(490);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown'", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SelfInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SelfInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AllPayeesDrodown'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AllPayeesDrodownInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AllPayeesDrodownInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.PayFromAccountDropdown'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.PayFromAccountDropdownInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.PayFromAccountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdown'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdown'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownList.SingleAmount'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownList.SingleAmountInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownList.SingleAmount.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SingleAmountInputBox'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SingleAmountInputBoxInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SingleAmountInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdown'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownList.AmountRange'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownList.AmountRangeInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.AmountDropdownList.AmountRange.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.MinimumAmountInputBox'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.MinimumAmountInputBoxInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.MinimumAmountInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.MaximumAmountInputBox'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.MaximumAmountInputBoxInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.MaximumAmountInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFramedropdown'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFramedropdownInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFramedropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last3Months'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last3MonthsInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last3MonthsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last6Months'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last6MonthsInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last6MonthsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last12Months'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last12MonthsInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.Last12MonthsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.CustomDateRange'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.CustomDateRangeInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.CustomDateRangeInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.CustomDateRange'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.CustomDateRangeInfo, new RecordItemIndex(20));
            repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.TimeFrameDropdownList.CustomDateRange.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.FromDateHistory'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.FromDateHistoryInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.FromDateHistoryInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.ToDateHistory'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.ToDateHistoryInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.ToDateHistoryInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.ResetButton'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.ResetButtonInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.ResetButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SearchButton'.", repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SearchButtonInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.HistoryTab.AdvancedSearchDropdown.SearchButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
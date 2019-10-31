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

namespace AccountsTestSuite.ActivityTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DateFilterSetup recording.
    /// </summary>
    [TestModule("3a67701a-f27c-4585-9446-54238e6a2721", ModuleType.Recording, 1)]
    public partial class DateFilterSetup : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static DateFilterSetup instance = new DateFilterSetup();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DateFilterSetup()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DateFilterSetup Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.FilterButton'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.FilterButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.FilterButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TimeFrameDropdown'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TimeFrameDropdownInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TimeFrameDropdown.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TimeFrameList.CustomDate'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TimeFrameList.CustomDateInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.TimeFrameList.CustomDate.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.SelectStartDate'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.SelectStartDateInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.SelectStartDate.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.MonthSelector'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.MonthSelectorInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.MonthSelector.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.YearSelector'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.YearSelectorInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.YearSelector.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.Year2018'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.Year2018Info, new RecordItemIndex(6));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.Year2018.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.September'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.SeptemberInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.September.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.Date24'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.Date24Info, new RecordItemIndex(8));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.FromCalendar.Date24.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.SelfInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.Self.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.ToMonthSelector'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.ToMonthSelectorInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.ToMonthSelector.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.ToYearSelector'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.ToYearSelectorInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.ToYearSelector.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.Year2018'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.Year2018Info, new RecordItemIndex(12));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.Year2018.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.October'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.OctoberInfo, new RecordItemIndex(13));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.October.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.Date11'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.Date11Info, new RecordItemIndex(14));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ToCalendar.Date11.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ApplyButton'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ApplyButtonInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.ApplyButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.ActivityTab.ShowingResultsFor'", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ShowingResultsForInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.ShowingResultsForInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
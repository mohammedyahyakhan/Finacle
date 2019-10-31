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
    ///The OnedaySearchTest recording.
    /// </summary>
    [TestModule("8dc571d8-0195-4bf9-8cce-1564ff736460", ModuleType.Recording, 1)]
    public partial class OnedaySearchTest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static OnedaySearchTest instance = new OnedaySearchTest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OnedaySearchTest()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OnedaySearchTest Instance
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Valid' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.TopBar.Acc0054'", repo.EasternOnlineBankingDashboard.TopBar.Acc0054Info, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.TopBar.Acc0054Info.WaitForAttributeEqual(5000, "Valid", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TopBar.Acc0054'.", repo.EasternOnlineBankingDashboard.TopBar.Acc0054Info, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.TopBar.Acc0054.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.BalanceHeader'", repo.EasternOnlineBankingDashboard.BalanceHeaderInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingDashboard.BalanceHeaderInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.FilterButton16'.", repo.EasternOnlineBankingDashboard.FilterButton16Info, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.FilterButton16.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TransactionTypeDropdown6'.", repo.EasternOnlineBankingDashboard.TransactionTypeDropdown6Info, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.TransactionTypeDropdown6.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.varTransactionType'.", repo.EasternOnlineBankingDashboard.varTransactionTypeInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.varTransactionType.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TimeframeDropdown9'.", repo.EasternOnlineBankingDashboard.TimeframeDropdown9Info, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.TimeframeDropdown9.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CustomDate2'.", repo.EasternOnlineBankingDashboard.CustomDate2Info, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.CustomDate2.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SelectStartDate'.", repo.EasternOnlineBankingDashboard.SelectStartDateInfo, new RecordItemIndex(13));
            repo.EasternOnlineBankingDashboard.SelectStartDate.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.MonthSelector'.", repo.EasternOnlineBankingDashboard.MonthSelectorInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.MonthSelector.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.YearSelector2'.", repo.EasternOnlineBankingDashboard.YearSelector2Info, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.YearSelector2.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Year2018'.", repo.EasternOnlineBankingDashboard.Year2018Info, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.Year2018.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.September'.", repo.EasternOnlineBankingDashboard.SeptemberInfo, new RecordItemIndex(17));
            repo.EasternOnlineBankingDashboard.September.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Date24'.", repo.EasternOnlineBankingDashboard.Date24Info, new RecordItemIndex(18));
            repo.EasternOnlineBankingDashboard.Date24.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SelectEndDate'.", repo.EasternOnlineBankingDashboard.SelectEndDateInfo, new RecordItemIndex(19));
            repo.EasternOnlineBankingDashboard.SelectEndDate.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ToCalendar.MonthSelector'.", repo.EasternOnlineBankingDashboard.ToCalendar.MonthSelectorInfo, new RecordItemIndex(20));
            repo.EasternOnlineBankingDashboard.ToCalendar.MonthSelector.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ToCalendar.YearSelector'.", repo.EasternOnlineBankingDashboard.ToCalendar.YearSelectorInfo, new RecordItemIndex(21));
            repo.EasternOnlineBankingDashboard.ToCalendar.YearSelector.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ToCalendar.Year2018'.", repo.EasternOnlineBankingDashboard.ToCalendar.Year2018Info, new RecordItemIndex(22));
            repo.EasternOnlineBankingDashboard.ToCalendar.Year2018.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ToCalendar.September'.", repo.EasternOnlineBankingDashboard.ToCalendar.SeptemberInfo, new RecordItemIndex(23));
            repo.EasternOnlineBankingDashboard.ToCalendar.September.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ToCalendar.Date24'.", repo.EasternOnlineBankingDashboard.ToCalendar.Date24Info, new RecordItemIndex(24));
            repo.EasternOnlineBankingDashboard.ToCalendar.Date24.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.AmountDropdown'.", repo.EasternOnlineBankingDashboard.AmountDropdownInfo, new RecordItemIndex(25));
            repo.EasternOnlineBankingDashboard.AmountDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformCLick() on item 'EasternOnlineBankingDashboard.TopBar.chkRange1select'.", repo.EasternOnlineBankingDashboard.TopBar.chkRange1selectInfo, new RecordItemIndex(26));
            repo.EasternOnlineBankingDashboard.TopBar.chkRange1select.Element.InvokeActionWithText("PerformCLick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CheckNumberDropdown'.", repo.EasternOnlineBankingDashboard.CheckNumberDropdownInfo, new RecordItemIndex(27));
            repo.EasternOnlineBankingDashboard.CheckNumberDropdown.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformCLick() on item 'EasternOnlineBankingDashboard.TopBar.chkRange1select'.", repo.EasternOnlineBankingDashboard.TopBar.chkRange1selectInfo, new RecordItemIndex(28));
            repo.EasternOnlineBankingDashboard.TopBar.chkRange1select.Element.InvokeActionWithText("PerformCLick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ApplyButton'.", repo.EasternOnlineBankingDashboard.ApplyButtonInfo, new RecordItemIndex(29));
            repo.EasternOnlineBankingDashboard.ApplyButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ClearSearchButton'.", repo.EasternOnlineBankingDashboard.ClearSearchButtonInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ClearSearchButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ClearSearchButton'.", repo.EasternOnlineBankingDashboard.ClearSearchButtonInfo, new RecordItemIndex(31));
            repo.EasternOnlineBankingDashboard.ClearSearchButton.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.BalanceHeader2'", repo.EasternOnlineBankingDashboard.BalanceHeader2Info, new RecordItemIndex(32));
            repo.EasternOnlineBankingDashboard.BalanceHeader2Info.WaitForAttributeEqual(30000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

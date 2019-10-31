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
    ///The ActualReportPageValidation recording.
    /// </summary>
    [TestModule("63c54a4e-a842-4325-b085-03b7387ed59e", ModuleType.Recording, 1)]
    public partial class ActualReportPageValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BPRv2Repository repository.
        /// </summary>
        public static BPRv2Repository repo = BPRv2Repository.Instance;

        static ActualReportPageValidation instance = new ActualReportPageValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActualReportPageValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActualReportPageValidation Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.ReportDropdown'.", repo.EasternOnlineBankingBillPay.ReportDropdownInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingBillPay.ReportDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.Last12MonthsReport'.", repo.EasternOnlineBankingBillPay.Last12MonthsReportInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingBillPay.Last12MonthsReport.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.Create_Report_Button'.", repo.EasternOnlineBankingBillPay.Create_Report_ButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.Create_Report_ButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.EditReportButtonBillPay'.", repo.EasternOnlineBankingBillPay.EditReportButtonBillPayInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.EditReportButtonBillPayInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.DeleteReportButtonBillPay'.", repo.EasternOnlineBankingBillPay.DeleteReportButtonBillPayInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.DeleteReportButtonBillPayInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.PrintButton'.", repo.EasternOnlineBankingBillPay.PrintButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.PrintButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.SentOn'.", repo.EasternOnlineBankingBillPay.SentOnInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.SentOnInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.PaidTo'.", repo.EasternOnlineBankingBillPay.PaidToInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.PaidToInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.Amount'.", repo.EasternOnlineBankingBillPay.AmountInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.AmountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.PaidFrom'.", repo.EasternOnlineBankingBillPay.PaidFromInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.PaidFromInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.Status'.", repo.EasternOnlineBankingBillPay.StatusInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.StatusInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.ConfirmationHash'.", repo.EasternOnlineBankingBillPay.ConfirmationHashInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.ConfirmationHashInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'EasternOnlineBankingBillPay.GrandTotal'.", repo.EasternOnlineBankingBillPay.GrandTotalInfo, new RecordItemIndex(12));
            Validate.Exists(repo.EasternOnlineBankingBillPay.GrandTotalInfo, null, new Validate.Options(){ReportLevelOnFailure=ReportLevel.Info});
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
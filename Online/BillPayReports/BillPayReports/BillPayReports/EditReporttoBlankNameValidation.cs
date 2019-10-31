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
    ///The EditReporttoBlankNameValidation recording.
    /// </summary>
    [TestModule("54a67b56-ecf7-4907-9a3a-2eea85c3875b", ModuleType.Recording, 1)]
    public partial class EditReporttoBlankNameValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayReportsRepository repository.
        /// </summary>
        public static BillPayReportsRepository repo = BillPayReportsRepository.Instance;

        static EditReporttoBlankNameValidation instance = new EditReporttoBlankNameValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditReporttoBlankNameValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditReporttoBlankNameValidation Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingBillPay.EditReportButton' at Center.", repo.EasternOnlineBankingBillPay.EditReportButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingBillPay.EditReportButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingBillPay.ReportTitleTab' at 15;29.", repo.EasternOnlineBankingBillPay.ReportTitleTabInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingBillPay.ReportTitleTab.Click("15;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingBillPay.ReportTitleTab'.", repo.EasternOnlineBankingBillPay.ReportTitleTabInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingBillPay.ReportTitleTab.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.SaveReport'.", repo.EasternOnlineBankingBillPay.SaveReportInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingBillPay.SaveReport.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.PleaseFillOutAllRequiredFieldsToC'.", repo.EasternOnlineBankingBillPay.PleaseFillOutAllRequiredFieldsToCInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.PleaseFillOutAllRequiredFieldsToCInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingBillPay.SomeTableTag.Error'.", repo.EasternOnlineBankingBillPay.SomeTableTag.ErrorInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingBillPay.SomeTableTag.ErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingBillPay.BackReportButton' at 27;11.", repo.EasternOnlineBankingBillPay.BackReportButtonInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingBillPay.BackReportButton.Click("27;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingBillPay.DefaultReportBill'", repo.EasternOnlineBankingBillPay.DefaultReportBillInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingBillPay.DefaultReportBillInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

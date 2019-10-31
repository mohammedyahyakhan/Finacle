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
    ///The SelectSubtotalVar recording.
    /// </summary>
    [TestModule("41e8e4dc-fcb1-43f3-b2e6-0e0715ef8a19", ModuleType.Recording, 1)]
    public partial class SelectSubtotalVar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayReportsRepository repository.
        /// </summary>
        public static BillPayReportsRepository repo = BillPayReportsRepository.Instance;

        static SelectSubtotalVar instance = new SelectSubtotalVar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectSubtotalVar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectSubtotalVar Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varSubtotal.
        /// </summary>
        [TestVariable("273bb935-27ec-461c-8dde-9e1196559b30")]
        public string varSubtotal
        {
            get { return repo.varSubtotal; }
            set { repo.varSubtotal = value; }
        }

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubTotalDropdown'.", repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubTotalDropdownInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubTotalDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubtotalList'", repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubtotalList.SelfInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubtotalList.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubtotalList.varSubtotal'.", repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubtotalList.varSubtotalInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingBillPay.CreateBillPaymentReportPage.SubtotalList.varSubtotal.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

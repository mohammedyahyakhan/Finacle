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
    ///The SelectEditReport recording.
    /// </summary>
    [TestModule("585a3305-6a92-4f95-9d36-31ae96367b2f", ModuleType.Recording, 1)]
    public partial class SelectEditReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BillPayReportsRepository repository.
        /// </summary>
        public static BillPayReportsRepository repo = BillPayReportsRepository.Instance;

        static SelectEditReport instance = new SelectEditReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectEditReport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectEditReport Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingBillPay.ReportsTabPage.EditButton'.", repo.EasternOnlineBankingBillPay.ReportsTabPage.EditButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingBillPay.ReportsTabPage.EditButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingBillPay.Modals.PleaseWaitModal'", repo.EasternOnlineBankingBillPay.Modals.PleaseWaitModalInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingBillPay.Modals.PleaseWaitModalInfo.WaitForAttributeEqual(30000, "Visible", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
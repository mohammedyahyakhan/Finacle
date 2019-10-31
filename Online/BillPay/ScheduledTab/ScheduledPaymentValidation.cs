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

namespace BillPayTestSuite.ScheduledTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ScheduledPaymentValidation recording.
    /// </summary>
    [TestModule("c5e90c81-2b57-49eb-916e-e26a9ec04c45", ModuleType.Recording, 1)]
    public partial class ScheduledPaymentValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::BillPayTestSuite.BillPayTestSuiteRepository repository.
        /// </summary>
        public static global::BillPayTestSuite.BillPayTestSuiteRepository repo = global::BillPayTestSuite.BillPayTestSuiteRepository.Instance;

        static ScheduledPaymentValidation instance = new ScheduledPaymentValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ScheduledPaymentValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ScheduledPaymentValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment'.", repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.SelfInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.EditPaymentButton'.", repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.EditPaymentButtonInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.EditPaymentButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.DeletePaymentButton'.", repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.DeletePaymentButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.DeletePaymentButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.OneTime'.", repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.OneTimeInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ScheduledTab.AaaTestPayeeScheduledPayment.OneTimeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

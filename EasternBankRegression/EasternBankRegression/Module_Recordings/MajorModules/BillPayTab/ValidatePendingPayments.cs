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

namespace EasternBankRegression.Module_Recordings.MajorModules.BillPayTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidatePendingPayments recording.
    /// </summary>
    [TestModule("8f3b82ed-ce49-48f2-8995-f30a4b0f1f65", ModuleType.Recording, 1)]
    public partial class ValidatePendingPayments : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static ValidatePendingPayments instance = new ValidatePendingPayments();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatePendingPayments()
        {
            varAmount = "3.00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidatePendingPayments Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varAmount.
        /// </summary>
        [TestVariable("2a12e761-5cc9-4b01-a301-34901f09ee6d")]
        public string varAmount
        {
            get { return repo.varAmount; }
            set { repo.varAmount = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (innertext~$varAmount) on item 'ApplicationUnderTest.MajorModules.BillPay_Sub.Pendingpayments.amount1'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.Pendingpayments.amount1Info, new RecordItemIndex(0));
            Validate.AttributeRegex(repo.ApplicationUnderTest.MajorModules.BillPay_Sub.Pendingpayments.amount1Info, "innertext", new Regex(varAmount));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
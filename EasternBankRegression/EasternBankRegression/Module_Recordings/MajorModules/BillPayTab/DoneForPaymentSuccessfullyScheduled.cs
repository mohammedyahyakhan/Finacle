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
    ///The DoneForPaymentSuccessfullyScheduled recording.
    /// </summary>
    [TestModule("48254ce1-5a2a-42b7-98a2-b0552c696ca9", ModuleType.Recording, 1)]
    public partial class DoneForPaymentSuccessfullyScheduled : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static DoneForPaymentSuccessfullyScheduled instance = new DoneForPaymentSuccessfullyScheduled();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DoneForPaymentSuccessfullyScheduled()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DoneForPaymentSuccessfullyScheduled Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.BillPay_Sub.AddPayee'", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.AddPayeeInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.AddPayeeInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.BillPay_Sub.AddPayee'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.AddPayeeInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.AddPayee.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.Done.TapRightMark' at Center", repo.ApplicationUnderTest.Done.TapRightMarkInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Done.TapRightMark.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.Done.TestDone'.", repo.ApplicationUnderTest.Done.TestDoneInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Done.TestDone.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Done.TestDone' at Center.", repo.ApplicationUnderTest.Done.TestDoneInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Done.TestDone.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
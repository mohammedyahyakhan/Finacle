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

namespace EasternBankRegression.Module_Recordings.MajorModules.BillPayTab.NotificationsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeleteThisPayement1 recording.
    /// </summary>
    [TestModule("1de5b263-65a5-400b-93c1-84f8f4ef7ffe", ModuleType.Recording, 1)]
    public partial class DeleteThisPayement1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static DeleteThisPayement1 instance = new DeleteThisPayement1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteThisPayement1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteThisPayement1 Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.DeleteThisPayment'", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.DeleteThisPaymentInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.DeleteThisPaymentInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.DeleteThisPayment' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.DeleteThisPaymentInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.DeleteThisPayment.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'ApplicationUnderTest.Done.BlankModal'", repo.ApplicationUnderTest.Done.BlankModalInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Done.BlankModalInfo.WaitForAttributeEqual(5000, "Visible", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
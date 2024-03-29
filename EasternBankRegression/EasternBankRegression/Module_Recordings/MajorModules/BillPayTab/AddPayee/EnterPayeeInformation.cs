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

namespace EasternBankRegression.Module_Recordings.MajorModules.BillPayTab.AddPayee
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterPayeeInformation recording.
    /// </summary>
    [TestModule("9d3abe54-dedb-493f-ac40-a2c8a595b1bd", ModuleType.Recording, 1)]
    public partial class EnterPayeeInformation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static EnterPayeeInformation instance = new EnterPayeeInformation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterPayeeInformation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterPayeeInformation Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeName' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '!B' with focus on 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeName'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeName.PressKeys("!B");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeAddress' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeAddressInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeAddress.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1419 commonwealth' with focus on 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeAddress'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeAddressInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.PayeeAddress.PressKeys("1419 commonwealth");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.City' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.CityInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.City.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Brighton' with focus on 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.City'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.CityInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.City.PressKeys("Brighton");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.State' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.StateInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.State.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'MA' with focus on 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.State'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.StateInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.State.PressKeys("MA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.ZipCode' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.ZipCodeInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.ZipCode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '02135' with focus on 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.ZipCode'.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.ZipCodeInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.ZipCode.PressKeys("02135");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.AddPayeeBtn' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.AddPayeeBtnInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.EnterPayeeInformation.AddPayeeBtn.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

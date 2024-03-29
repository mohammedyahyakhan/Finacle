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

namespace AccountsTestSuite.ServicesTab.StopCheckHistoryModal
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CancelStoppedCheck recording.
    /// </summary>
    [TestModule("9821b664-9da4-4993-a057-d8105845aa29", ModuleType.Recording, 1)]
    public partial class CancelStoppedCheck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static CancelStoppedCheck instance = new CancelStoppedCheck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CancelStoppedCheck()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CancelStoppedCheck Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.StopCheckHistoryModal.CancelStopButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StopCheckHistoryModal.CancelStopButtonInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StopCheckHistoryModal.CancelStopButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.StopCheckHistoryModal.CancelStopButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StopCheckHistoryModal.CancelStopButtonInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StopCheckHistoryModal.CancelStopButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal'", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.SelfInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.SelfInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.AreYouSureYouWantToCancelTheStop'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.AreYouSureYouWantToCancelTheStopInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.AreYouSureYouWantToCancelTheStopInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.YesButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.YesButtonInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.YesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.NoButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.NoButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.NoButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.YesButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.YesButtonInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelCheckYesorNoModal.YesButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal'", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.SelfInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.SelfInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.StopCheckSuccessMessage'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.StopCheckSuccessMessageInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.StopCheckSuccessMessageInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.DoneButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.DoneButtonInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.CancelStopCheckSuccessfulModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

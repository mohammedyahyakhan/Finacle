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

namespace EasternBankRegression.Module_Recordings.MajorModules.AccountsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CancelStopCheck recording.
    /// </summary>
    [TestModule("9c04a351-b240-4a1a-acef-0bd4f14ec9b0", ModuleType.Recording, 1)]
    public partial class CancelStopCheck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static CancelStopCheck instance = new CancelStopCheck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CancelStopCheck()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CancelStopCheck Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Accounts'.", repo.EasternOnlineBankingDashboard.AccountsInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.Accounts.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.WelcomeMessage'", repo.EasternOnlineBankingDashboard.WelcomeMessageInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.WelcomeMessageInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Grid'.", repo.EasternOnlineBankingDashboard.GridInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.Grid.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.varAccount3'", repo.EasternOnlineBankingDashboard.varAccount3Info, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.varAccount3Info.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.varAccount3'.", repo.EasternOnlineBankingDashboard.varAccount3Info, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.varAccount3.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(7));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EasternOnlineBankingDashboard.AccountActivityLoadingModal' at Center.", repo.EasternOnlineBankingDashboard.AccountActivityLoadingModalInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.AccountActivityLoadingModal.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.BalanceHeader'", repo.EasternOnlineBankingDashboard.BalanceHeaderInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.BalanceHeaderInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ServicesTab'.", repo.EasternOnlineBankingDashboard.ServicesTabInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingDashboard.ServicesTab.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.CheckServices'", repo.EasternOnlineBankingDashboard.CheckServicesInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingDashboard.CheckServicesInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.Itag'.", repo.EasternOnlineBankingDashboard.ItagInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ItagInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.Itag'.", repo.EasternOnlineBankingDashboard.ItagInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ItagInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ViewCancelStoppedChecks'.", repo.EasternOnlineBankingDashboard.ViewCancelStoppedChecksInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.ViewCancelStoppedChecks.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(15));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.StopCheckHistoryModal'", repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.SelfInfo, new RecordItemIndex(16));
            repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StopCheckHistoryModal.ButtonClose'.", repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.ButtonCloseInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.ButtonCloseInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.StopCheckHistoryModal.CancelStopButton'.", repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.CancelStopButtonInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.CancelStopButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.StopCheckHistoryModal.CancelStopButton'.", repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.CancelStopButtonInfo, new RecordItemIndex(19));
            repo.EasternOnlineBankingDashboard.StopCheckHistoryModal.CancelStopButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.CancelCheckYesorNoModal'", repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.SelfInfo, new RecordItemIndex(20));
            repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.SelfInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelCheckYesorNoModal.AreYouSureYouWantToCancelTheStop'.", repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.AreYouSureYouWantToCancelTheStopInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.AreYouSureYouWantToCancelTheStopInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelCheckYesorNoModal.YesButton'.", repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.YesButtonInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.YesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelCheckYesorNoModal.NoButton'.", repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.NoButtonInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.NoButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CancelCheckYesorNoModal.YesButton'.", repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.YesButtonInfo, new RecordItemIndex(24));
            repo.EasternOnlineBankingDashboard.CancelCheckYesorNoModal.YesButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal'", repo.EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.SelfInfo, new RecordItemIndex(25));
            repo.EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.SelfInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.StopCheckSuccessMessage'.", repo.EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.StopCheckSuccessMessageInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.StopCheckSuccessMessageInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(27));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.DoneButton'.", repo.EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.DoneButtonInfo, new RecordItemIndex(28));
            repo.EasternOnlineBankingDashboard.CancelStopCheckSuccessfulModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(29));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

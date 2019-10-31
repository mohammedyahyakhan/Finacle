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

namespace EasternBankRegression.Module_Recordings.MajorModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InitiatePreTestCleanup recording.
    /// </summary>
    [TestModule("a21458c8-1eb8-4bdb-a174-d7d3cf0b929b", ModuleType.Recording, 1)]
    public partial class InitiatePreTestCleanup : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static InitiatePreTestCleanup instance = new InitiatePreTestCleanup();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InitiatePreTestCleanup()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InitiatePreTestCleanup Instance
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

            // clean bill pay section
            Report.Log(ReportLevel.Info, "Section", "clean bill pay section", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay' at Center.", repo.ApplicationUnderTest.MajorModules.BillPayInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.BillPay.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.SearchPayees'", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.SearchPayeesInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.SearchPayeesInfo.WaitForAttributeContains(10000, "Enabled", "True");
            
            Module_Code.GeneralLibrary.cleanubillpay();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.SearchPayees'", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.SearchPayeesInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.DeletePayeeSub.SearchPayeesInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.ShowButton' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ShowButtonInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ShowButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.InactivePayeesOnly' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.InactivePayeesOnlyInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.InactivePayeesOnly.Click();
            Delay.Milliseconds(200);
            
            Module_Code.GeneralLibrary.deleteinactivepayees();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.cleanup.donebutnsuccessmodal'", repo.ApplicationUnderTest.cleanup.donebutnsuccessmodalInfo, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.cleanup.donebutnsuccessmodalInfo.WaitForAttributeContains(10000, "Enabled", "True");
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.cleanup.donebutnsuccessmodal' at Center.", repo.ApplicationUnderTest.cleanup.donebutnsuccessmodalInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.cleanup.donebutnsuccessmodal.Click();
            //Delay.Milliseconds(200);
            
            // clean notications
            Report.Log(ReportLevel.Info, "Section", "clean notications", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.Notifications' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.NotificationsInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.Notifications.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.BillPay_Sub.Notifications'", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.NotificationsInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.NotificationsInfo.WaitForAttributeContains(10000, "Enabled", "True");
            
            Module_Code.GeneralLibrary.deletebillremainder();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.cleanup.donebutnsuccessmodal'", repo.ApplicationUnderTest.cleanup.donebutnsuccessmodalInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.cleanup.donebutnsuccessmodalInfo.WaitForAttributeContains(30000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.cleanup.donebutnsuccessmodal' at Center.", repo.ApplicationUnderTest.cleanup.donebutnsuccessmodalInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.cleanup.donebutnsuccessmodal.Click();
            Delay.Milliseconds(200);
            
            // clean reports
            Report.Log(ReportLevel.Info, "Section", "clean reports", new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MajorModules.BillPay_Sub.Reports' at Center.", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.Reports.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(18));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.BillPay_Sub.Reports'", repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.MajorModules.BillPay_Sub.ReportsInfo.WaitForAttributeContains(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.cleanup.reportsdropdown' at Center.", repo.ApplicationUnderTest.cleanup.reportsdropdownInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.cleanup.reportsdropdown.Click();
            Delay.Milliseconds(200);
            
            Module_Code.GeneralLibrary.DeleteExistingReport();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.MajorModules.Accounts'.", repo.ApplicationUnderTest.MajorModules.AccountsInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.MajorModules.Accounts.PerformClick();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'Enabled' to contain the specified value 'True'. Associated repository item: 'ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccounts'", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccountsInfo, new RecordItemIndex(23));
                repo.ApplicationUnderTest.MajorModules.Accounts_Sub.SearchAccountsInfo.WaitForAttributeContains(5000, "Enabled", "True");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Accounts'.", repo.ApplicationUnderTest.MajorModules.AccountsInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.MajorModules.Accounts.EnsureVisible();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
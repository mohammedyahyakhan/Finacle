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

namespace AccountsTestSuite.Dashboard
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnrolledPinkalooCardAndListViewValidation recording.
    /// </summary>
    [TestModule("7fef18e1-eed5-40bf-8fa8-395b43129ec1", ModuleType.Recording, 1)]
    public partial class EnrolledPinkalooCardAndListViewValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static EnrolledPinkalooCardAndListViewValidation instance = new EnrolledPinkalooCardAndListViewValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnrolledPinkalooCardAndListViewValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnrolledPinkalooCardAndListViewValidation Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.Grid'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.GridInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.Grid.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.PinkalooIcon'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.PinkalooIconInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.PinkalooIconInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.GiveForGood'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.GiveForGoodInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.GiveForGoodInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.MyCharitableGivingAccount'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.MyCharitableGivingAccountInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.MyCharitableGivingAccountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.List'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.ListInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.List.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.OtherAccounts'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.OtherAccountsInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.OtherAccountsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.GiveForGoodIcon'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.GiveForGoodIconInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.GiveForGoodIconInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.GiveForGood'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.GiveForGoodInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.GiveForGoodInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.MyCharitableGivingAccount'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.MyCharitableGivingAccountInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.MyCharitableGivingAccountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.Grid'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.GridInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.Grid.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.GiveForGood'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.GiveForGoodInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.PinkalooAccountCard.GiveForGood.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.PinkalooIFrame.ModernGivingProvidedBy'", repo.EasternOnlineBankingAuthenticationSc.PinkalooIFrame.ModernGivingProvidedByInfo, new RecordItemIndex(11));
            repo.EasternOnlineBankingAuthenticationSc.PinkalooIFrame.ModernGivingProvidedByInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
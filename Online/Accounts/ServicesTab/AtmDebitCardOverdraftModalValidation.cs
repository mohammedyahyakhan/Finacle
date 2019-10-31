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

namespace AccountsTestSuite.ServicesTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AtmDebitCardOverdraftModalValidation recording.
    /// </summary>
    [TestModule("6a71bc0b-339d-4022-a4b0-7c5651a01e64", ModuleType.Recording, 1)]
    public partial class AtmDebitCardOverdraftModalValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static AtmDebitCardOverdraftModalValidation instance = new AtmDebitCardOverdraftModalValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AtmDebitCardOverdraftModalValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AtmDebitCardOverdraftModalValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.Itag'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.ItagInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.ItagInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.ATMDebitCardOverdraft'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.ATMDebitCardOverdraftInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.ATMDebitCardOverdraftInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.OverdraftSwitch'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.OverdraftSwitchInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.OverdraftSwitch.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.StandardOverdraftPracticesHeader'", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.StandardOverdraftPracticesHeaderInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.StandardOverdraftPracticesHeaderInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.OverdraftDescription'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.OverdraftDescriptionInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.OverdraftDescriptionInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.ViewDocumentButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.ViewDocumentButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.ViewDocumentButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.CancelButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.CancelButtonInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.CancelButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.EnableButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.EnableButtonInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.EnableButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.CancelButton'.", repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.CancelButtonInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingAuthenticationSc.ServicesTab.StandardOverdraftPracticesModal.CancelButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
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

namespace CRIF
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ApplicationApprovedValidation recording.
    /// </summary>
    [TestModule("2804bae5-8c95-4b26-bead-2448f112875a", ModuleType.Recording, 1)]
    public partial class ApplicationApprovedValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static ApplicationApprovedValidation instance = new ApplicationApprovedValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ApplicationApprovedValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ApplicationApprovedValidation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.LoanApprovedPage.LoanApprovedMessage'", repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanApprovedMessageInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanApprovedMessageInfo.WaitForAttributeEqual(120000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.LoanAmount'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.LoanAmountInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.LoanAmountInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.LoanDuration'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.LoanDurationInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.LoanDurationInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.APR'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.APRInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.APRInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.Interest'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.InterestInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.InterestInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.MonthlyPayment'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.MonthlyPaymentInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.MonthlyPaymentInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.ApplicationNumber'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.ApplicationNumberInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.LoanInfoBox.ApplicationNumberInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.EasternBankRepMessage'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.EasternBankRepMessageInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.EasternBankRepMessageInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.LoanApprovedPage.DoneButton'.", repo.EasternOnlineBankingDashboard.LoanApprovedPage.DoneButtonInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.LoanApprovedPage.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
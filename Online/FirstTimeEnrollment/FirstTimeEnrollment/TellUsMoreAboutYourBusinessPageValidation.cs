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

namespace FirstTimeEnrollment
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TellUsMoreAboutYourBusinessPageValidation recording.
    /// </summary>
    [TestModule("29f6f336-5af8-4bd2-bd42-68482865bc91", ModuleType.Recording, 1)]
    public partial class TellUsMoreAboutYourBusinessPageValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the FirstTimeEnrollmentRepository repository.
        /// </summary>
        public static FirstTimeEnrollmentRepository repo = FirstTimeEnrollmentRepository.Instance;

        static TellUsMoreAboutYourBusinessPageValidation instance = new TellUsMoreAboutYourBusinessPageValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TellUsMoreAboutYourBusinessPageValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TellUsMoreAboutYourBusinessPageValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.SomeBusinessCustomersNeedMoreAdvanc'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.SomeBusinessCustomersNeedMoreAdvancInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.SomeBusinessCustomersNeedMoreAdvancInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.AccessAndControlsForMultipleUsers'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.AccessAndControlsForMultipleUsersInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.AccessAndControlsForMultipleUsersInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.ProcessingEmployeePayrollTransactions'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.ProcessingEmployeePayrollTransactionsInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.ProcessingEmployeePayrollTransactionsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.InitiatingDomesticWireTransfers'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.InitiatingDomesticWireTransfersInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.InitiatingDomesticWireTransfersInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.DoYouNeedAnyOfTheseFeatures'.", repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.DoYouNeedAnyOfTheseFeaturesInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.TellUsMoreAboutYourBusinessPage.DoYouNeedAnyOfTheseFeaturesInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingOnlineBankingE.FooterButtons.BackButton'.", repo.EasternOnlineBankingOnlineBankingE.FooterButtons.BackButtonInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingOnlineBankingE.FooterButtons.BackButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingOnlineBankingE.PleaseContactUsModal'", repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.SelfInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.PleaseReachOutToOurEasternBankBusinessTeam'.", repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.PleaseReachOutToOurEasternBankBusinessTeamInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.PleaseReachOutToOurEasternBankBusinessTeamInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.OkButton'.", repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.OkButtonInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.OkButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.OkButton'.", repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.OkButtonInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingOnlineBankingE.PleaseContactUsModal.OkButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The MessagesTabValidation recording.
    /// </summary>
    [TestModule("2ff65521-2c1f-42be-9ea7-2ce363b54407", ModuleType.Recording, 1)]
    public partial class MessagesTabValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static MessagesTabValidation instance = new MessagesTabValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MessagesTabValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MessagesTabValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.Messages1'.", repo.EasternOnlineBankingDashboard.Messages1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.Messages1Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.Messages1'.", repo.EasternOnlineBankingDashboard.Messages1Info, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.Messages1.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.InboxLoadingModal'.", repo.EasternOnlineBankingDashboard.InboxLoadingModalInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.InboxLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.InboxLoadingModal'", repo.EasternOnlineBankingDashboard.InboxLoadingModalInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.InboxLoadingModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.MessagesHeader'", repo.EasternOnlineBankingDashboard.MessagesHeaderInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.MessagesHeaderInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ComposeNewMessageButton'.", repo.EasternOnlineBankingDashboard.ComposeNewMessageButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ComposeNewMessageButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab'.", repo.EasternOnlineBankingDashboard.InboxTabInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SentTab'.", repo.EasternOnlineBankingDashboard.SentTabInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SentTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.TrashTab'.", repo.EasternOnlineBankingDashboard.TrashTabInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.TrashTabInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab1'.", repo.EasternOnlineBankingDashboard.InboxTab1.SelfInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab1.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab1.SearchInputBox'.", repo.EasternOnlineBankingDashboard.InboxTab1.SearchInputBoxInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab1.SearchInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab1.FirstMessage'.", repo.EasternOnlineBankingDashboard.InboxTab1.FirstMessageInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab1.FirstMessageInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SentTab'.", repo.EasternOnlineBankingDashboard.SentTabInfo, new RecordItemIndex(12));
            repo.EasternOnlineBankingDashboard.SentTab.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.SentLoadingModal'.", repo.EasternOnlineBankingDashboard.SentLoadingModalInfo, new RecordItemIndex(13));
            repo.EasternOnlineBankingDashboard.SentLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.SentLoadingModal'", repo.EasternOnlineBankingDashboard.SentLoadingModalInfo, new RecordItemIndex(14));
            repo.EasternOnlineBankingDashboard.SentLoadingModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SearchInputBox'", repo.EasternOnlineBankingDashboard.SearchInputBoxInfo, new RecordItemIndex(15));
            repo.EasternOnlineBankingDashboard.SearchInputBoxInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.FirstMessage'", repo.EasternOnlineBankingDashboard.FirstMessageInfo, new RecordItemIndex(16));
            //repo.EasternOnlineBankingDashboard.FirstMessageInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TrashTab'.", repo.EasternOnlineBankingDashboard.TrashTabInfo, new RecordItemIndex(17));
            repo.EasternOnlineBankingDashboard.TrashTab.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'EasternOnlineBankingDashboard.TrashLoadingModal'.", repo.EasternOnlineBankingDashboard.TrashLoadingModalInfo, new RecordItemIndex(18));
            repo.EasternOnlineBankingDashboard.TrashLoadingModal.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'False'. Associated repository item: 'EasternOnlineBankingDashboard.TrashLoadingModal'", repo.EasternOnlineBankingDashboard.TrashLoadingModalInfo, new RecordItemIndex(19));
            repo.EasternOnlineBankingDashboard.TrashLoadingModalInfo.WaitForAttributeEqual(60000, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SearchInputBox1'", repo.EasternOnlineBankingDashboard.SearchInputBox1Info, new RecordItemIndex(20));
            repo.EasternOnlineBankingDashboard.SearchInputBox1Info.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.FirstMessage1'.", repo.EasternOnlineBankingDashboard.FirstMessage1Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.FirstMessage1Info, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

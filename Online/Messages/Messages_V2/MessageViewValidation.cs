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

namespace Messages_V2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MessageViewValidation recording.
    /// </summary>
    [TestModule("cfa8b5f1-a776-4017-9c75-51785f4607d2", ModuleType.Recording, 1)]
    public partial class MessageViewValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MessagesRepository repository.
        /// </summary>
        public static MessagesRepository repo = MessagesRepository.Instance;

        static MessageViewValidation instance = new MessageViewValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MessageViewValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MessageViewValidation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.InboxTab.MessageView.BackButton'", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.BackButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.InboxTab.MessageView.BackButtonInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.ReplyButton'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.ReplyButtonInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.ReplyButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.MoveToTrashButton'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.MoveToTrashButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.MoveToTrashButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.PrintButton'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.PrintButtonInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.PrintButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.From'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.FromInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.FromInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.Subject'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.SubjectInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.SubjectInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.Date'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.DateInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.DateInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.RepliedInfo'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.RepliedInfoInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.RepliedInfoInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.ShowReplyButton'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.ShowReplyButtonInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.ShowReplyButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.InboxTab.MessageView.MessageBody'.", repo.EasternOnlineBankingDashboard.InboxTab.MessageView.MessageBodyInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.InboxTab.MessageView.MessageBodyInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

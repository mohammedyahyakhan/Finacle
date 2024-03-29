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
    ///The SelectRestoreMessage recording.
    /// </summary>
    [TestModule("6405adcd-4609-44f3-96db-b2d602a2c00a", ModuleType.Recording, 1)]
    public partial class SelectRestoreMessage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MessagesRepository repository.
        /// </summary>
        public static MessagesRepository repo = MessagesRepository.Instance;

        static SelectRestoreMessage instance = new SelectRestoreMessage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectRestoreMessage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectRestoreMessage Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.TrashTab.MessageView.RestoreButton'.", repo.EasternOnlineBankingDashboard.TrashTab.MessageView.RestoreButtonInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.TrashTab.MessageView.RestoreButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SuccessModal'", repo.EasternOnlineBankingDashboard.SuccessModal.SelfInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.SuccessModal.SelfInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SuccessModal.SuccessHeader'.", repo.EasternOnlineBankingDashboard.SuccessModal.SuccessHeaderInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SuccessModal.SuccessHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your message has been restored.') on item 'EasternOnlineBankingDashboard.SuccessModal.SuccessMessage'.", repo.EasternOnlineBankingDashboard.SuccessModal.SuccessMessageInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SuccessModal.SuccessMessageInfo, "InnerText", "Your message has been restored.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.SuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.SuccessModal.DoneButtonInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.SuccessModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SuccessModal.DoneButton'.", repo.EasternOnlineBankingDashboard.SuccessModal.DoneButtonInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.SuccessModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

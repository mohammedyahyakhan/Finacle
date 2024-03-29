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
    ///The SentTabValidation recording.
    /// </summary>
    [TestModule("1d6acbe4-1e31-49f9-bcea-b38571438015", ModuleType.Recording, 1)]
    public partial class SentTabValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MessagesRepository repository.
        /// </summary>
        public static MessagesRepository repo = MessagesRepository.Instance;

        static SentTabValidation instance = new SentTabValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SentTabValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SentTabValidation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SentTab.SearchInputBox'", repo.EasternOnlineBankingDashboard.SentTab.SearchInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.SentTab.SearchInputBoxInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingDashboard.SentTab.FirstMessage'", repo.EasternOnlineBankingDashboard.SentTab.FirstMessageInfo, new RecordItemIndex(1));
            //repo.EasternOnlineBankingDashboard.SentTab.FirstMessageInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

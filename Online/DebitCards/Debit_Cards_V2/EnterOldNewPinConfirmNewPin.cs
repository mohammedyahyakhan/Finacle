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

namespace Debit_Cards_V2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterOldNewPinConfirmNewPin recording.
    /// </summary>
    [TestModule("51e8ed8f-c96f-4d38-a4f6-304472f892cf", ModuleType.Recording, 1)]
    public partial class EnterOldNewPinConfirmNewPin : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DebitCardsRepository repository.
        /// </summary>
        public static DebitCardsRepository repo = DebitCardsRepository.Instance;

        static EnterOldNewPinConfirmNewPin instance = new EnterOldNewPinConfirmNewPin();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterOldNewPinConfirmNewPin()
        {
            varPin = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterOldNewPinConfirmNewPin Instance
        {
            get { return instance; }
        }

#region Variables

        string _varPin;

        /// <summary>
        /// Gets or sets the value of variable varPin.
        /// </summary>
        [TestVariable("b8ffade5-7d17-47c1-a074-febda111bcfe")]
        public string varPin
        {
            get { return _varPin; }
            set { _varPin = value; }
        }

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ChangePinModal.NewPinInputBox'.", repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPin' with focus on 'EasternOnlineBankingDashboard.ChangePinModal.NewPinInputBox'.", repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinInputBoxInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinInputBox.PressKeys(varPin);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.ChangePinModal.NewPinConfirmInputBox'.", repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinConfirmInputBoxInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinConfirmInputBox.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPin' with focus on 'EasternOnlineBankingDashboard.ChangePinModal.NewPinConfirmInputBox'.", repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinConfirmInputBoxInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.ChangePinModal.NewPinConfirmInputBox.PressKeys(varPin);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

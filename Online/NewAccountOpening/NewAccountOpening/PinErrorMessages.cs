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

namespace NewAccountOpening
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PinErrorMessages recording.
    /// </summary>
    [TestModule("7519a771-5abb-4533-ab84-ac73b5f5bdd7", ModuleType.Recording, 1)]
    public partial class PinErrorMessages : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewAccountOpeningRepository repository.
        /// </summary>
        public static NewAccountOpeningRepository repo = NewAccountOpeningRepository.Instance;

        static PinErrorMessages instance = new PinErrorMessages();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PinErrorMessages()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PinErrorMessages Instance
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBox.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBoxInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBox.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseFillOutRequiredFieldsError'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseFillOutRequiredFieldsErrorInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseFillOutRequiredFieldsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1234' on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBoxInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBox.Element.SetAttributeValue("TagValue", "1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1235' on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBoxInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBox.Element.SetAttributeValue("TagValue", "1235");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.MatchingPinsError'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.MatchingPinsErrorInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.MatchingPinsErrorInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '123' on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBoxInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBox.Element.SetAttributeValue("TagValue", "123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButtonInfo, new RecordItemIndex(9));
            repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.NextButton.PerformClick();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseEnterA4DigitPinError'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseEnterA4DigitPinErrorInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.Errors.PleaseEnterA4DigitPinErrorInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

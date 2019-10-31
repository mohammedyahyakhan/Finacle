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
    ///The DebitCardSetupModalValidation recording.
    /// </summary>
    [TestModule("5d90350f-c9a4-4618-b277-329e70a338c9", ModuleType.Recording, 1)]
    public partial class DebitCardSetupModalValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewAccountOpeningRepository repository.
        /// </summary>
        public static NewAccountOpeningRepository repo = NewAccountOpeningRepository.Instance;

        static DebitCardSetupModalValidation instance = new DebitCardSetupModalValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DebitCardSetupModalValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DebitCardSetupModalValidation Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable DebitCardType.
        /// </summary>
        [TestVariable("6e8a9c9e-452d-4f8c-95ee-d47a84445aa9")]
        public string DebitCardType
        {
            get { return repo.DebitCardType; }
            set { repo.DebitCardType = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.DebitCardSetup'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.DebitCardSetupInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.StepHeader.DebitCardSetupInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar.SelfInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.ProgressBar.SelfInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.MasterCardVariable'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.MasterCardVariableInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.MasterCardVariableInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ThisAccountComesWithAComplimentary'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ThisAccountComesWithAComplimentaryInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ThisAccountComesWithAComplimentaryInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.WouldYouLikeANewDebitCardForThis'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.WouldYouLikeANewDebitCardForThisInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.WouldYouLikeANewDebitCardForThisInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.DebitCardYesButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.DebitCardYesButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.DebitCardYesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.DebitCardNoButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.DebitCardNoButtonInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.DebitCardNoButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ThisDebitCardWillBeSentToYourAddressOnFile'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ThisDebitCardWillBeSentToYourAddressOnFileInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ThisDebitCardWillBeSentToYourAddressOnFileInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.AddressLine'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.AddressLineInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.AddressLineInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.IsTheAddressOnFileYourCurrentMail'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.IsTheAddressOnFileYourCurrentMailInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.IsTheAddressOnFileYourCurrentMailInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.CurrentMailingAddressYesButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.CurrentMailingAddressYesButtonInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.CurrentMailingAddressYesButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.CurrentMailingAddressNoButton'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.CurrentMailingAddressNoButtonInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.CurrentMailingAddressNoButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.SetUp4DigitPinHeader'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.SetUp4DigitPinHeaderInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.SetUp4DigitPinHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBoxInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.PinInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinHeader'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinHeaderInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinHeaderInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBox'.", repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBoxInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.OpenCheckingAccountModal.DebitCardSetup.ConfirmPinInputBoxInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
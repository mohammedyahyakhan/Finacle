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
    ///The NewAccountPickerModalValidation recording.
    /// </summary>
    [TestModule("04df8109-ed02-4a46-b82a-2502039c70a3", ModuleType.Recording, 1)]
    public partial class NewAccountPickerModalValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewAccountOpeningRepository repository.
        /// </summary>
        public static NewAccountOpeningRepository repo = NewAccountOpeningRepository.Instance;

        static NewAccountPickerModalValidation instance = new NewAccountPickerModalValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NewAccountPickerModalValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NewAccountPickerModalValidation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.NewAccountTypePickerModal.IWantToOpenAHeader'.", repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.IWantToOpenAHeaderInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.IWantToOpenAHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.NewAccountTypePickerModal.CheckingAccountButton'.", repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.CheckingAccountButtonInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.CheckingAccountButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.NewAccountTypePickerModal.SavingsAccountButton'.", repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.SavingsAccountButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.NewAccountTypePickerModal.SavingsAccountButtonInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

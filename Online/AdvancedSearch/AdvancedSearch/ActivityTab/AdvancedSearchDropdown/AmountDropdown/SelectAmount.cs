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

namespace AdvancedSearch.ActivityTab.AdvancedSearchDropdown.AmountDropdown
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectAmount recording.
    /// </summary>
    [TestModule("ad64fe44-9903-4758-91df-fb8be4186220", ModuleType.Recording, 1)]
    public partial class SelectAmount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AdvancedSearch.AdvancedSearchRepository repository.
        /// </summary>
        public static global::AdvancedSearch.AdvancedSearchRepository repo = global::AdvancedSearch.AdvancedSearchRepository.Instance;

        static SelectAmount instance = new SelectAmount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectAmount()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectAmount Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varAmountRange.
        /// </summary>
        [TestVariable("9a9c0928-94e0-40b7-b0e8-12ebb157327e")]
        public string varAmountRange
        {
            get { return repo.varAmountRange; }
            set { repo.varAmountRange = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.AmountList.varAmount'.", repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.AmountList.varAmountInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingAuthenticationSc.ActivityTab.AdvancedSearchDropdown.AmountList.varAmount.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

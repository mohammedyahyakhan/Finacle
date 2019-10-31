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

namespace CRIF
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectNumberOfYears recording.
    /// </summary>
    [TestModule("a55ced7c-4224-45ea-a24f-5c8a2d9875e3", ModuleType.Recording, 1)]
    public partial class SelectNumberOfYears : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static SelectNumberOfYears instance = new SelectNumberOfYears();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectNumberOfYears()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectNumberOfYears Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Years.
        /// </summary>
        [TestVariable("5bd1784d-04ca-4dd6-a738-00f0e165ef8b")]
        public string Years
        {
            get { return repo.Years; }
            set { repo.Years = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.HowMuchWouldYouLikeToBorrowPage.NumberOfYearsVar'.", repo.EasternOnlineBankingDashboard.HowMuchWouldYouLikeToBorrowPage.NumberOfYearsVarInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.HowMuchWouldYouLikeToBorrowPage.NumberOfYearsVar.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
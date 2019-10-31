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

namespace Settings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ManageCategoriesModalValidation recording.
    /// </summary>
    [TestModule("4eb3cf47-3953-4ce1-8fab-9a57d17f367b", ModuleType.Recording, 1)]
    public partial class ManageCategoriesModalValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SettingsRepository repository.
        /// </summary>
        public static SettingsRepository repo = SettingsRepository.Instance;

        static ManageCategoriesModalValidation instance = new ManageCategoriesModalValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ManageCategoriesModalValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ManageCategoriesModalValidation Instance
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
            Mouse.DefaultMoveTime = 10;
            Keyboard.DefaultKeyPressTime = 10;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ManageCategoriesModal.CategoryName'.", repo.EasternOnlineBankingDashboard.ManageCategoriesModal.CategoryNameInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ManageCategoriesModal.CategoryNameInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ManageCategoriesModal.CategoryType'.", repo.EasternOnlineBankingDashboard.ManageCategoriesModal.CategoryTypeInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ManageCategoriesModal.CategoryTypeInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ManageCategoriesModal.NewCategoryButton'.", repo.EasternOnlineBankingDashboard.ManageCategoriesModal.NewCategoryButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ManageCategoriesModal.NewCategoryButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.ManageCategoriesModal.DoneButton'.", repo.EasternOnlineBankingDashboard.ManageCategoriesModal.DoneButtonInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.ManageCategoriesModal.DoneButtonInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
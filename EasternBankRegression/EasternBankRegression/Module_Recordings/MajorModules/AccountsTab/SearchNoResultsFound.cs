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

namespace EasternBankRegression.Module_Recordings.MajorModules.AccountsTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SearchNoResultsFound recording.
    /// </summary>
    [TestModule("24b6bb45-d793-49f4-8b02-5986c267d81b", ModuleType.Recording, 1)]
    public partial class SearchNoResultsFound : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static SearchNoResultsFound instance = new SearchNoResultsFound();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchNoResultsFound()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchNoResultsFound Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.SearchAccountsInputBox2'.", repo.EasternOnlineBankingDashboard.SearchAccountsInputBox2Info, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.SearchAccountsInputBox2.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '?!?!?!??!' on item 'EasternOnlineBankingDashboard.SearchAccountsInputBox2'.", repo.EasternOnlineBankingDashboard.SearchAccountsInputBox2Info, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.SearchAccountsInputBox2.Element.SetAttributeValue("TagValue", "?!?!?!??!");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.NoResultsFound1'.", repo.EasternOnlineBankingDashboard.NoResultsFound1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.NoResultsFound1Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.NoResultsIcon'.", repo.EasternOnlineBankingDashboard.NoResultsIconInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.NoResultsIconInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingDashboard.NoResultsFoundUnderIcon'.", repo.EasternOnlineBankingDashboard.NoResultsFoundUnderIconInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingDashboard.NoResultsFoundUnderIconInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '' on item 'EasternOnlineBankingDashboard.SearchAccountsInputBox2'.", repo.EasternOnlineBankingDashboard.SearchAccountsInputBox2Info, new RecordItemIndex(6));
            repo.EasternOnlineBankingDashboard.SearchAccountsInputBox2.Element.SetAttributeValue("TagValue", "");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

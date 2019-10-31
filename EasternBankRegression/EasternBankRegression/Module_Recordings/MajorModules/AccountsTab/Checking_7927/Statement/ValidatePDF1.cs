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

namespace EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Statement
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidatePDF1 recording.
    /// </summary>
    [TestModule("3c715c4f-dc78-4504-9084-68b084a14e48", ModuleType.Recording, 1)]
    public partial class ValidatePDF1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EasternBankRegression.EasternBankRegressionRepository repository.
        /// </summary>
        public static global::EasternBankRegression.EasternBankRegressionRepository repo = global::EasternBankRegression.EasternBankRegressionRepository.Instance;

        static ValidatePDF1 instance = new ValidatePDF1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatePDF1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidatePDF1 Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF'.", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDFInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF'.", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDFInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF'.", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDFInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF'.", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDFInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF' at Center", repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDFInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDF.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'DocumentView.ValidationDocument'.", repo.DocumentView.ValidationDocumentInfo, new RecordItemIndex(5));
            repo.DocumentView.ValidationDocument.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DocumentView.ValidationDocument'.", repo.DocumentView.ValidationDocumentInfo, new RecordItemIndex(6));
            Validate.Exists(repo.DocumentView.ValidationDocumentInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'DocumentView.ValidationDocument'.", repo.DocumentView.ValidationDocumentInfo, new RecordItemIndex(7));
            repo.DocumentView.ValidationDocument.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'DocumentView.DocumentView1' at Center", repo.DocumentView.DocumentView1Info, new RecordItemIndex(8));
            repo.DocumentView.DocumentView1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+W' Press with focus on 'DocumentView.DocumentView1'.", repo.DocumentView.DocumentView1Info, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.DocumentView.DocumentView1);
            Keyboard.Press(System.Windows.Forms.Keys.W | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

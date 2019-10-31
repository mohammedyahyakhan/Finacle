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
    ///The EnterSecondaryApplicantsInfo recording.
    /// </summary>
    [TestModule("9d5f5a70-c660-44fe-b329-f1caf05a2c46", ModuleType.Recording, 1)]
    public partial class EnterSecondaryApplicantsInfo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRIFRepository repository.
        /// </summary>
        public static CRIFRepository repo = CRIFRepository.Instance;

        static EnterSecondaryApplicantsInfo instance = new EnterSecondaryApplicantsInfo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterSecondaryApplicantsInfo()
        {
            Ssn = "";
            BirthMonth = "";
            BirthDay = "";
            BirthYear = "";
            FirstName = "";
            LastName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterSecondaryApplicantsInfo Instance
        {
            get { return instance; }
        }

#region Variables

        string _Ssn;

        /// <summary>
        /// Gets or sets the value of variable Ssn.
        /// </summary>
        [TestVariable("86debaf6-3c04-4797-817e-fee892ced33c")]
        public string Ssn
        {
            get { return _Ssn; }
            set { _Ssn = value; }
        }

        string _BirthMonth;

        /// <summary>
        /// Gets or sets the value of variable BirthMonth.
        /// </summary>
        [TestVariable("7cd22607-a16f-4bb5-9753-f24ef2554a8f")]
        public string BirthMonth
        {
            get { return _BirthMonth; }
            set { _BirthMonth = value; }
        }

        string _BirthDay;

        /// <summary>
        /// Gets or sets the value of variable BirthDay.
        /// </summary>
        [TestVariable("f6b54e78-c77a-4d56-a4a7-e407a1280b41")]
        public string BirthDay
        {
            get { return _BirthDay; }
            set { _BirthDay = value; }
        }

        string _BirthYear;

        /// <summary>
        /// Gets or sets the value of variable BirthYear.
        /// </summary>
        [TestVariable("31ca0980-b852-4f6a-a64f-b32425b517eb")]
        public string BirthYear
        {
            get { return _BirthYear; }
            set { _BirthYear = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("2da25c29-8dbc-4a94-9462-24891c144782")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("874024b9-fa69-4d57-9dbc-074629f18a3e")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$FirstName' on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.FirstNameInputBox'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.FirstNameInputBoxInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.FirstNameInputBox.Element.SetAttributeValue("TagValue", FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$LastName' on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.LastNameInputBox'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.LastNameInputBoxInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.LastNameInputBox.Element.SetAttributeValue("TagValue", LastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$Ssn' on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.SocialSecurityNumberInputBox'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.SocialSecurityNumberInputBoxInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.SocialSecurityNumberInputBox.Element.SetAttributeValue("TagValue", Ssn);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$BirthMonth' on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.MonthDropdown'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.MonthDropdownInfo, new RecordItemIndex(3));
            repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.MonthDropdown.Element.SetAttributeValue("TagValue", BirthMonth);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$BirthDay' on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.DayDropdown'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.DayDropdownInfo, new RecordItemIndex(4));
            repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.DayDropdown.Element.SetAttributeValue("TagValue", BirthDay);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$BirthYear' on item 'EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.YearDropdown'.", repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.YearDropdownInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingDashboard.WhoIsApplyingForThisLoanPage.SecondaryApplicantInformationFirstPage.YearDropdown.Element.SetAttributeValue("TagValue", BirthYear);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

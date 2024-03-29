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

namespace AccountsTestSuite.Dashboard
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddFavoriteRemoveFavorite recording.
    /// </summary>
    [TestModule("b5031961-4fef-4660-b049-55d0459423f8", ModuleType.Recording, 1)]
    public partial class AddFavoriteRemoveFavorite : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AccountsTestSuite.AccountsTestSuiteRepository repository.
        /// </summary>
        public static global::AccountsTestSuite.AccountsTestSuiteRepository repo = global::AccountsTestSuite.AccountsTestSuiteRepository.Instance;

        static AddFavoriteRemoveFavorite instance = new AddFavoriteRemoveFavorite();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddFavoriteRemoveFavorite()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddFavoriteRemoveFavorite Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varAccount.
        /// </summary>
        [TestVariable("03910666-17a8-4e09-a45d-42b5a41d5e89")]
        public string varAccount
        {
            get { return repo.varAccount; }
            set { repo.varAccount = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.AddToFavoriteIcon'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.AddToFavoriteIconInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.AddToFavoriteIconInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.AddToFavoriteIcon'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.AddToFavoriteIconInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.AddToFavoriteIcon.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal'", repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.SelfInfo, new RecordItemIndex(2));
            repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.SuccessHeader'.", repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.SuccessHeaderInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.SuccessHeaderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='You have added this account to your favorites.') on item 'EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.Message'.", repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.MessageInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.MessageInfo, "InnerText", "You have added this account to your favorites.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.DoneButton'.", repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.DoneButtonInfo, new RecordItemIndex(5));
            repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.FavoriteCheckingSavingsAccounts'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.FavoriteCheckingSavingsAccountsInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.FavoriteCheckingSavingsAccountsInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AccountsDashboard.RemoveFavoriteIcon'.", repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.RemoveFavoriteIconInfo, new RecordItemIndex(7));
            repo.EasternOnlineBankingAuthenticationSc.AccountsDashboard.RemoveFavoriteIcon.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal'", repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.SelfInfo, new RecordItemIndex(8));
            repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.SelfInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='You have removed this account from your favorites.') on item 'EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.Message'.", repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.MessageInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.MessageInfo, "InnerText", "You have removed this account from your favorites.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.DoneButton'.", repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.DoneButtonInfo, new RecordItemIndex(10));
            repo.EasternOnlineBankingAuthenticationSc.AddRemoveFavoritesModal.DoneButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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

namespace Transfersv2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectToAccountVar recording.
    /// </summary>
    [TestModule("50efb842-4a89-44d1-b151-66d558884e9c", ModuleType.Recording, 1)]
    public partial class SelectToAccountVar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TransfersRepository repository.
        /// </summary>
        public static TransfersRepository repo = TransfersRepository.Instance;

        static SelectToAccountVar instance = new SelectToAccountVar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectToAccountVar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectToAccountVar Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varToAccount.
        /// </summary>
        [TestVariable("779f7bab-424b-458f-87ba-bc4fa74a0653")]
        public string varToAccount
        {
            get { return repo.varToAccount; }
            set { repo.varToAccount = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.TransferToDropdown'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferToDropdownInfo, new RecordItemIndex(0));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.TransferToDropdown.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'EasternOnlineBankingDashboard.InternalTransferModal.ToAccountList.ToAccountVar'.", repo.EasternOnlineBankingDashboard.InternalTransferModal.ToAccountList.ToAccountVarInfo, new RecordItemIndex(1));
            repo.EasternOnlineBankingDashboard.InternalTransferModal.ToAccountList.ToAccountVar.As<WebElement>().PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

﻿/*
 * Created by Ranorex
 * User: ykhan
 * Date: 3/1/2019
 * Time: 3:40 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace EasternBankRegression.Module_Code
{
    /// <summary>
    /// Description of UserCodeModule.
    /// </summary>
    [TestModule("E75F1A4A-9EDF-4FF1-8D5B-09C2A01F4EDA", ModuleType.UserCode, 1)]
    public class UserCodeModule : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
             
            
        
        }
    }
}

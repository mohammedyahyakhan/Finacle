/*
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
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
 
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Data;
using Ranorex.Core.Testing;

namespace EasternBankRegression.Module_Code
{
    /// <summary>
    /// Description of UserCodeModule.
    /// </summary>
    [TestModule("E75F1A4A-9EDF-4FF1-8D5B-09C2A01F4EDA", ModuleType.UserCode, 1)]
    public class Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Test()
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
            //{"One Time Now", "One Time, Scheduled", "Weekly", "Every 2 Weeks", "Monthly", "Every 3 Months", "Every 6 Months", "Annually" }
            var repo = EasternBankRegressionRepository.Instance;
            List<KeyValuePair<int,string>> ConfirmationList = new List<KeyValuePair<int,string>>(){
            		new KeyValuePair<int,string>(1,"One Time Now"),
            		new KeyValuePair<int,string>(2,"One Time, Scheduled"),
            		new KeyValuePair<int,string>(3,"Weekly"),
            		new KeyValuePair<int,string>(4,"Every 2 Weeks"),
            		new KeyValuePair<int,string>(5,"Monthly"),
            		new KeyValuePair<int,string>(6,"Every 3 Months"),
            		new KeyValuePair<int,string>(7,"Every 6 Months"),
            		new KeyValuePair<int,string>(8,"Annually"),
            };
            
            //IList<Ranorex.TdTag> fromcontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.FromContainerInfo.CreateAdapters<Ranorex.TdTag>();
            Report.Info(ConfirmationList.Count.ToString());
            foreach (KeyValuePair<int,string> item in ConfirmationList) {
            	Report.Info(item.Key.ToString()+"             "+item.Value.ToString());
            }
           
        }
    }
}

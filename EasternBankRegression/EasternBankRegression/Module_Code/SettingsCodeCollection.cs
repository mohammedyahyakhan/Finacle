/*
 * Created by Ranorex
 * User: ykhan
 * Date: 4/10/2019
 * Time: 6:26 PM
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
using Ranorex.Core.Repository;
using Ranorex.Core.Data;
using Ranorex.Core.Testing;

namespace EasternBankRegression.Module_Code
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class SettingsCodeCollection
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This method will cehck the account visibility switch status if switch is on - it will turn off
        /// </summary>
        [UserCodeMethod]
        public static void CheckAccountSwitch()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	var toggle_7927 = repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle_7927;
        	
        	string status = toggle_7927.Element.FindSingle("//div[@class~'eb-switch switch']").GetAttributeValueText("class");
        	
        	
        	if (status == "eb-switch switch-on") {
        		Report.Info("switch is :       "+status+"   so turning off");
        		toggle_7927.Click();
        		Delay.Seconds(1);
        		var doneBtn = repo.ApplicationUnderTest.Done.DoneBtn;
        		doneBtn.Click();
        	}
        	else {
        		Report.Info("switch is :       "+status+" so doing nothing");
        	}

        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ToggleAllpresentAccounts()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	IList<Ranorex.DivTag> accountslist = repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle.AccountslistcontainerInfo.CreateAdapters<Ranorex.DivTag>();
        	
        	var list = new List<string>();
        		
        	foreach (Ranorex.DivTag item in accountslist) {
        		list.Add(item.Element.GetAttributeValueText("class").ToString());
        		Report.Info(list.Count.ToString());
        	}
        	for (int i = 1; i <= list.Count; i++) {
        		DivTag ebSwitchSwitchOn = "//div[#'stmtTabSettings-settings']//table/tbody//tr//td//div[@class~'eb-switch switch']["+i+"]";
        		ebSwitchSwitchOn.Click();
        		Delay.Seconds(2);
        		var doneBtn = repo.ApplicationUnderTest.Done.DoneBtn;
        		doneBtn.Click();
        	}

        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ToggleallbutOneAccount()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	IList<Ranorex.DivTag> accountslist = repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageStatementsSub.Toggle.AccountslistcontainerInfo.CreateAdapters<Ranorex.DivTag>();
        	
        	var list = new List<string>();
        	repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageAccounts.Focus();

        	foreach (Ranorex.DivTag item in accountslist) {
        		list.Add(item.Element.GetAttributeValueText("class").ToString());
        		Report.Info(list.Count.ToString());
        	}
        	for (int i = 1; i < list.Count; i++) {
        		DivTag ebSwitchSwitchOn = "//div[@id~'stmtTabSettings-settings' or @id~'accMng-settings']//table/tbody//tr//td//div[@class~'eb-switch switch']["+i+"]";
        		ebSwitchSwitchOn.Click();
        		Delay.Seconds(2);
        		var doneBtn = repo.ApplicationUnderTest.Done.DoneBtn;
        		doneBtn.Click();
        	}
        }
        
    }
}

/*
 * Created by Ranorex
 * User: ykhan
 * Date: 3/1/2019
 * Time: 3:35 PM
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
    public class UserCodeCollection
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PickLastWeekDay()
        {
        	string todaydate = System.DateTime.Now.Day.ToString();
            Report.Info(todaydate);
            string lastweekday = System.DateTime.Today.AddDays(-7).Day.ToString();
            Report.Info(lastweekday);
            ButtonTag lastweekdaybtn = "/dom[@domain='fnclmobqa.easternbank.com:8543']//td[@id~'datepicker']//span[@innertext='"+lastweekday+"']/..";
            lastweekdaybtn.Click();
        
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PickJan1(RepoItemInfo datetaginfo, RepoItemInfo dateinfo)
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	datetaginfo.FindAdapter<InputTag>().Click();
        	ButtonTag monthheader = "/dom[@domain='fnclmobqa.easternbank.com:8543']//div[#'fromDateAutoPaymentCreate']/table/thead//tr//th/buttontag[@id~'datepicker-\\d+-\\d+-title']";
        	monthheader.Click();
			ButtonTag month = "/dom[@domain='fnclmobqa.easternbank.com:8543']//div[#'fromDateAutoPaymentCreate']/?/?/tbody//span[@innertext~'January']/..";
			month.Click();
			dateinfo.FindAdapter<ButtonTag>().Click();
        }
       
        public static void todaydate(RepoItemInfo inputtagInfo)
        {
            string today = System.DateTime.Today.Date.ToString("MM/dd/yyyy");
            
            Keyboard.Press(today);    
        }
        
        public static void futuredate(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "SetInputValue", "Set input value by clicking into it, clear existing and type value", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click(System.Windows.Forms.MouseButtons.Left);
            string today = System.DateTime.Today.DayOfWeek.ToString();
            Report.Info(System.DateTime.Today.DayOfWeek.ToString());
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'inputtagInfo'.", inputtagInfo);
            Keyboard.PrepareFocus(inputtagInfo.FindAdapter<InputTag>());
            Delay.Seconds(1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            if (today == "Friday") {
                string fromfriday = System.DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                inputtagInfo.FindAdapter<InputTag>().PressKeys(fromfriday);
            }
            else if (today == "Saturday") {
                string fromsaturday = System.DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                inputtagInfo.FindAdapter<InputTag>().PressKeys(fromsaturday);
            }
            else{
                string monday = System.DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                inputtagInfo.FindAdapter<InputTag>().PressKeys(monday);
            }
        }





            
  
        
        
    }
    }

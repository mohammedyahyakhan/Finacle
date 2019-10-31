/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/1/2019
 * Time: 10:25 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Data;
using Ranorex.Core.Testing;

namespace EasternBankRegression.Module_Recordings.MajorModules.TransfersTab
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class TransfersCodeCollection
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// this method will validate the ascending order of scheduled for column in scheduled transfers
        /// </summary>
        [UserCodeMethod]
        public static void ScheduledForinAscendingorder()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            var scheduleFor = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ScheduleFor;
            List<System.DateTime> ScheduledForList = new List<System.DateTime>();
            IList<Ranorex.TdTag> scheduleforcontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ScheduleForContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in scheduleforcontlist) {
            	string date = item.Element.GetAttributeValueText("innertext");
            	Report.Info(date);
            	var datetext =System.DateTime.ParseExact(date,"MMM dd, yyyy",null);
            	ScheduledForList.Add(datetext);
            }
            List<System.DateTime> ascending_list = ScheduledForList.OrderBy(x => x.Date).ToList<System.DateTime>();
            for (int i = 0; i < ScheduledForList.Count; i++) {
            	var equality = ScheduledForList[i].Equals(ascending_list[i]);
            	Report.Info(ScheduledForList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+ascending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }

            
        }
        
        /// <summary>
        ///  this method will validate the descending order of scheduled for column in scheduled transfers
        /// </summary>
        [UserCodeMethod]
        public static void ScheduledForinDescendingorder()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            var scheduleFor = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ScheduleFor;
            List<System.DateTime> ScheduledForList = new List<System.DateTime>();
            IList<Ranorex.TdTag> scheduleforcontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ScheduleForContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in scheduleforcontlist) {
            	string date = item.Element.GetAttributeValueText("innertext");
            	Report.Info(date);
            	var datetext =System.DateTime.ParseExact(date,"MMM dd, yyyy",null);
            	ScheduledForList.Add(datetext);
            }
            
            List<System.DateTime> descending_list = ScheduledForList.OrderBy(x => x.Date).Reverse<System.DateTime>().ToList();
            for (int i = 0; i < ScheduledForList.Count; i++) {
            	var equality = ScheduledForList[i].Equals(descending_list[i]);
            	Report.Info(ScheduledForList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+descending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// this method will validate the ascending order of From column in scheduled transfers
        /// </summary>
        [UserCodeMethod]
        public static void FromSortinginAscendingorder()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> FromList = new List<string>();
            IList<Ranorex.TdTag> fromcontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.FromContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in fromcontlist) {
            	string accname = item.Element.GetAttributeValueText("innertext");
            	Report.Info(accname);
            	FromList.Add(accname);
            }
            List<string> ascending_list = FromList.OrderBy(x => x).ToList();
            for (int i = 0; i < FromList.Count; i++) {
            	var equality = FromList[i].Equals(ascending_list[i]);
            	Report.Info(FromList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+ascending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// this method will validate the descending order of From column in scheduled transfers
        /// </summary>
        [UserCodeMethod]
        public static void FromSortinginDescendingorder()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> FromList = new List<string>();
            IList<Ranorex.TdTag> fromcontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.FromContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in fromcontlist) {
            	string accname = item.Element.GetAttributeValueText("innertext");
            	Report.Info(accname);
            	FromList.Add(accname);
            }
            List<string> descending_list = FromList.OrderBy(x => x).Reverse<string>().ToList();
            for (int i = 0; i < FromList.Count; i++) {
            	var equality = FromList[i].Equals(descending_list[i]);
            	Report.Info(FromList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+descending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// this method will validate the descending order of To column in scheduled transfers
        /// </summary>
        [UserCodeMethod]
        public static void ToSortinginAscending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> ToList = new List<string>();
            IList<Ranorex.TdTag> tocontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ToContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in tocontlist) {
            	string accname = item.Element.GetAttributeValueText("innertext");
            	Report.Info(accname);
            	ToList.Add(accname);
            }
            List<string> ascending_list = ToList.OrderBy(x => x).ToList();
            for (int i = 0; i < ToList.Count; i++) {
            	var equality = ToList[i].Equals(ascending_list[i]);
            	Report.Info(ToList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+ascending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// this method will validate the descending order of To column in scheduled transfers
        /// </summary>
        [UserCodeMethod]
        public static void ToSortinginDescending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> ToList = new List<string>();
            IList<Ranorex.TdTag> tocontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ToContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in tocontlist) {
            	string accname = item.Element.GetAttributeValueText("innertext");
            	Report.Info(accname);
            	ToList.Add(accname);
            }
            List<string> descending_list = ToList.OrderBy(x => x).Reverse<string>().ToList();
            for (int i = 0; i < ToList.Count; i++) {
            	var equality = ToList[i].Equals(descending_list[i]);
            	Report.Info(ToList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+descending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void AmountinAscending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> AmountList = new List<string>();
            IList<Ranorex.TdTag> amountcontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.AmountContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in amountcontlist) {
            	string amountvalue = item.Element.GetAttributeValueText("innertext");
            	Report.Info(amountvalue);
            	AmountList.Add(amountvalue);
            }
            List<string> ascending_list = AmountList.OrderBy(x => x).ToList();
            for (int i = 0; i < AmountList.Count; i++) {
            	var equality = AmountList[i].Equals(ascending_list[i]);
            	Report.Info(AmountList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+ascending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void AmountinDescending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> AmountList = new List<string>();
            IList<Ranorex.TdTag> amountcontlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.AmountContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in amountcontlist) {
            	string amountvalue = item.Element.GetAttributeValueText("innertext");
            	Report.Info(amountvalue);
            	AmountList.Add(amountvalue);
            }
            List<string> descending_list = AmountList.OrderBy(x => x).Reverse<string>().ToList();
            for (int i = 0; i < AmountList.Count; i++) {
            	var equality = AmountList[i].Equals(descending_list[i]);
            	Report.Info(AmountList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+descending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ConfirmationinAscending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> ConfirmationList = new List<string>();
            IList<Ranorex.TdTag> confirmationlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ConfirmationContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in confirmationlist) {
            	string value = item.Element.GetAttributeValueText("innertext");
            	Report.Info(value);
            	ConfirmationList.Add(value);
            }
            List<string> ascending_list = ConfirmationList.OrderBy(x => x).ToList();
            for (int i = 0; i < ConfirmationList.Count; i++) {
            	var equality = ConfirmationList[i].Equals(ascending_list[i]);
            	Report.Info(ConfirmationList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+ascending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ConfirmationinDescending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<string> ConfirmationList = new List<string>();
            IList<Ranorex.TdTag> confirmationlist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.ConfirmationContainerInfo.CreateAdapters<Ranorex.TdTag>();
            
            foreach (var item in confirmationlist) {
            	string value = item.Element.GetAttributeValueText("innertext");
            	Report.Info(value);
            	ConfirmationList.Add(value);
            }
            List<string> descending_list = ConfirmationList.OrderBy(x => x).Reverse<string>().ToList();
            for (int i = 0; i < ConfirmationList.Count; i++) {
            	var equality = ConfirmationList[i].Equals(descending_list[i]);
            	Report.Info(ConfirmationList[i].ToString()+"  has equality:  "+equality.ToString()+"  compared to:  "+descending_list[i].ToString());
            	if (equality.ToString() == "False") {
            		Report.Failure("CHECK THIS ERROR AGAIN");
            	}
            }
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void FrequencyinAscending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<KeyValuePair<int,string>> DefaultFrequencyList = new List<KeyValuePair<int,string>>(){
            		new KeyValuePair<int,string>(1,"One Time Now"),
            		new KeyValuePair<int,string>(2,"One Time, Scheduled"),
            		new KeyValuePair<int,string>(3,"Weekly"),
            		new KeyValuePair<int,string>(4,"Every 2 Weeks"),
            		new KeyValuePair<int,string>(5,"Monthly"),
            		new KeyValuePair<int,string>(6,"Every 3 Months"),
            		new KeyValuePair<int,string>(7,"Every 6 Months"),
            		new KeyValuePair<int,string>(8,"Annually"),
            };
        	List<string> FrequencyList = new List<string>();
        	IList<Ranorex.TdTag> frequencylist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.FrequencyContainerInfo.CreateAdapters<Ranorex.TdTag>();
        	foreach (var item in frequencylist) {
            	string value = item.Element.GetAttributeValueText("innertext");
            	Report.Info(value);
            	//FrequencyList.Add(DefaultFrequencyList[value.ToString()].Key.ToString());
            }
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void FrequencyinDescending()
        {
        	var repo = EasternBankRegressionRepository.Instance;
            List<KeyValuePair<int,string>> DefaultFrequencyList = new List<KeyValuePair<int,string>>(){
            		new KeyValuePair<int,string>(1,"One Time Now"),
            		new KeyValuePair<int,string>(2,"One Time, Scheduled"),
            		new KeyValuePair<int,string>(3,"Weekly"),
            		new KeyValuePair<int,string>(4,"Every 2 Weeks"),
            		new KeyValuePair<int,string>(5,"Monthly"),
            		new KeyValuePair<int,string>(6,"Every 3 Months"),
            		new KeyValuePair<int,string>(7,"Every 6 Months"),
            		new KeyValuePair<int,string>(8,"Annually"),
            };
        	List<string> FrequencyList = new List<string>();
        	IList<Ranorex.TdTag> frequencylist = repo.ApplicationUnderTest.MajorModules.Transfers_Sub.TransferBetweenMyEAsternBankAccoutns.ScheduleSorting.FrequencyContainerInfo.CreateAdapters<Ranorex.TdTag>();
        	foreach (var item in frequencylist) {
            	string value = item.Element.GetAttributeValueText("innertext");
            	Report.Info(value);
            	frequencylist.Add(value);
            }
        }
    }
}

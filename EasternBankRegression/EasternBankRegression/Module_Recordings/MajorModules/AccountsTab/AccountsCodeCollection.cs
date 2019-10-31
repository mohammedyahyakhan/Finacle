/*
 * Created by Ranorex
 * User: ykhan
 * Date: 4/8/2019
 * Time: 2:28 PM
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
using Ranorex.Core.Data;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace EasternBankRegression.Module_Recordings.MajorModules.AccountsTab
{
    
    [UserCodeCollection]
    public class AccountsCodeCollection
    {
        
        [UserCodeMethod]
        public static void ActivateeStatements()
        {
        	var repo = EasternBankRegressionRepository.Instance;

			
        	Report.Info("waiting for activate e statements container to check if it exists");
        	if (repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.acivatestatementscontainerInfo.Exists() ) {
        		
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Statement.ActivateEStatements.Start();
			}
        	else {
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Statement.ActivatePaperStatements.Start();
        		
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.ViewOnlineStatement.Start();
        		
        	}
        


        }
        
        
        [UserCodeMethod]
        public static void OpenPdfToValidate()
        {
        	var repo = EasternBankRegressionRepository.Instance;

			
        	Report.Info("waiting to check if PDF file's exists");
        	//
        
        		if (repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.StatementsTab.PDFInfo.Exists()){
        	
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Statement.ValidatePDF1.Start();
        	}
        	else if(repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Sub.acivatestatementscontainerInfo.Exists()){
        		
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Statement.ActivateEStatements.Start();
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Statement.ValidatePDF1.Start();


        	}
        	else {
        		
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Statement.ActivatePaperStatements.Start();
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Openestatement.Start();
        		
        	}
        	
       
        
    }
        
       [UserCodeMethod]
        public static void AddCategoryandDelete()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	Report.Info("waiting to check if Delete exists");
        	if (repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageCategoriessub.DeleteCategoryInfo.Exists()){

        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.DeleteA.Start();
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.Addcategory.Start();
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.DeleteA.Start();
        	}
        	else {
        		
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.DoneA.Start();
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.Addcategory.Start();
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.DeleteA.Start();
        		
        	}
        }
        [UserCodeMethod]
        public static void DeleteCategory()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	Report.Info("waiting to check if Delete exists");
        	if (repo.ApplicationUnderTest.MajorModules.Settings_Sub.ManageCategoriessub.DeleteCategoryInfo.Exists()){

        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.DeleteA.Start();
        		
        	}
        	else {
        		
        		EasternBankRegression.Module_Recordings.MajorModules.AccountsTab.Checking_7927.Category.DoneA.Start();
        		
        }
        
    } 
        
        /// <summary>
        /// Checking if Account 7927 Exist after login.
        /// </summary>
        [UserCodeMethod]
        public static void Check7927()
        {
        	var repo = EasternBankRegressionRepository.Instance;
        	Report.Info("waiting to check if Account 7927 exists");
        	if (repo.ApplicationUnderTest.MajorModules.Accounts_Sub.Checking7927Info.Exists()){
        		
        		

        		Report.Info("Checking 7927 Exist");
        		
        	}
        	else {
        		
        		EasternBankRegression.Module_Recordings.MajorModules.SettingsTab.AccountShown.Start();
        	}}
        
        }}
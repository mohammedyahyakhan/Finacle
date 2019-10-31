// <copyright file="Transfers.cs" company="Eastern Bank">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Ios
{
    using System;
    using System.Collections.Generic;
    using Ios.Pages;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.MultiTouch;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;

    [TestFixture("local", "iphone-se")]
    public class Accounts : BrowserStackNUnitTest 
    {
        public Accounts(string profile, string environment)
            : base(profile, environment)
        {
        }

        private AccountsPage accountsPage = null;
        private LoginPage loginPage = null;
        // Instance of extents reports
        public ExtentReports Extent;
        public ExtentTest Test;

        [OneTimeSetUp]
        public void StartReport()
        {
            // To obtain the current solution path/project path
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = pth.Substring(0, pth.LastIndexOf("bin", StringComparison.Ordinal));
            var projectPath = new Uri(actualPath).LocalPath;

            DateTime currentDate = DateTime.Now;

            string timestamp = currentDate.ToString("yyyy-MM-dd hhmmss");

            // Append the html report file to current project path
            var reportPath = projectPath + "Reports\\" + "EasternBank_Accounts" + timestamp + ".html";

            // Boolean value for replacing existing report
            this.Extent = new ExtentReports(reportPath, false);

            // this.extent = new ExtentReports(reportPath);

            // Add QA system info to html report
            this.Extent.AddSystemInfo("Host Name", "iOS Execution").AddSystemInfo("Environment", "QA").AddSystemInfo("Username", "iOSExecution");

            // Adding config.xml file
            this.Extent.LoadConfig(projectPath + "Extent-Config.xml"); // Get the config.xml file from http://extentreports.com
        }

        [TearDown]
        public void AfterClass()
        {
            // StackTrace details for failed Test-cases
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            // var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                this.Test.Log(LogStatus.Fail, status + errorMessage);
            }

            // End test report
            this.Extent.EndTest(this.Test);
        }

        [OneTimeTearDown]

        public void EndReport()
        {
            // End Report
            this.Extent.Flush();
            this.Extent.Close();
        }

        [Test]
        [Obsolete]
        [Description("validating home screen after login in application")]
        public void HomeScreen()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("HomeScreen");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);


            var checkingsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'CHECKING & SAVINGS')]")));
            Assert.AreEqual(true, checkingsavings.Displayed);

            var signout = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Sign Out')]")));
            Assert.AreEqual(true, signout.Displayed);

            var mobilesolution = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Finacle Mobile Solution')]")));

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var opennewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, opennewaccount.Displayed);

            var loan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'LOANS')]")));
            Assert.AreEqual(true, loan.Displayed);

            this.Test.Log(LogStatus.Pass, "Accounts home screen validated");
        }
               
        [Test]
        [Obsolete]
        public void Accountshomecheckingaccount()
        {
             this.accountsPage = new AccountsPage(this.Driver);
             this.loginPage = new LoginPage(this.Driver);

            // Start Report
             this.Test = this.Extent.StartTest("Accountshomecheckingaccount");
             this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");
             this.accountsPage.VerifyCheckingAccount();

             this.Test.Log(LogStatus.Pass, "Accounts home screen validated");
        }

        [Test]
        [Obsolete]
        public void Searchaccountssuccess()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Searchaccountssuccess");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, checkingaccount.Displayed);

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);

            this.Test.Log(LogStatus.Pass, "search accounts successful");
        }

        [Test]
        [Obsolete]
        public void Onecharacter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Onecharacter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("o");

            var revolvingcredit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Revolving')]")));
            Assert.AreEqual(true, revolvingcredit.Displayed);

            this.Test.Log(LogStatus.Pass, "search One character is success");
        }

        [Test]
        [Obsolete]
        public void Searchsymbol()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Searchsymbol");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("!");

            var noresultsfound = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'No Results Found')]")));
            Assert.AreEqual(true, noresultsfound.Displayed);

            this.Test.Log(LogStatus.Pass, "No Results Found");
        }

        [Test]
        [Obsolete]
        public void Maxchar()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Maxchar");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("abcdefghijklmnopqarstuvwxyz");

            var noresultsfound = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'No Results Found')]")));
            Assert.AreEqual(true, noresultsfound.Displayed);

            this.Test.Log(LogStatus.Pass, "No Results Found");
        }

        [Test]
        [Obsolete]
        public void Checkingaccountactivity()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Checkingaccountactivity");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var availablebalance = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(2)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeStaticText[contains(@name,'Available Balance')]")));
            Assert.AreEqual(true, availablebalance.Enabled);

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            Assert.AreEqual(true, searchtransactions.Displayed);

            this.Test.Log(LogStatus.Pass, "Checkingaccountactivity is verified");
        }

        [Test]
        [Obsolete]
        public void Verifystatementtab()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifystatementtab");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("////XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var statements = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("////XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Statements')]")));
            Assert.AreEqual(true, statements.Displayed);

            this.Test.Log(LogStatus.Pass, "statements tab verified");
        }

        [Test]
        [Obsolete]
        public void Verifystatementscreen()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifystatementtab");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("////XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var statements = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("////XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Statements')]")));
            Assert.AreEqual(true, statements.Displayed);
            statements.Click();

            var year = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'2019')]")));
            Assert.AreEqual(true, year.Displayed);

            this.Test.Log(LogStatus.Pass, "statement screen validated");
        }

        [Test]
        [Obsolete]
        public void Verifylast13months()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("verifylast13months");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var statements = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Statements')]")));
            Assert.AreEqual(true, statements.Displayed);
            statements.Click();

            var year = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'2019')]")));
            Assert.AreEqual(true, year.Displayed);

            if (year.Displayed)
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                var dec = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'DEC')]")));
                Assert.AreEqual(true, dec.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "up" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                var dec = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'DEC')]")));
                Assert.AreEqual(true, dec.Displayed);
            }

            var nov = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'NOV')]")));
            Assert.AreEqual(true, nov.Displayed);
            if (nov.Displayed)
            {
                Assert.AreEqual(true, nov.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("////XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'NOV')]");
                Assert.AreEqual(true, nov.Displayed);
            }
            this.Test.Log(LogStatus.Pass, "13 months screen validated");

            var oct = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'OCT')]")));
            Assert.AreEqual(true, oct.Displayed);
            if (oct.Displayed)
            {
                Assert.AreEqual(true, oct.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'OCT')]");
                Assert.AreEqual(true, oct.Displayed);
            }

            var sep = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'SEP')]")));
            Assert.AreEqual(true, sep.Displayed);
            if (sep.Displayed)
            {
                Assert.AreEqual(true, sep.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'SEP')]");
                Assert.AreEqual(true, sep.Displayed);
            }

            var aug = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'AUG')]")));
            Assert.AreEqual(true, aug.Displayed);
            if (aug.Displayed)
            {
                Assert.AreEqual(true, aug.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'AUG')]");
                Assert.AreEqual(true, aug.Displayed);
            }

            var jul = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'JUL')]")));
            Assert.AreEqual(true, jul.Displayed);
            if (jul.Displayed)
            {
                Assert.AreEqual(true, jul.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'JUL')]");
                Assert.AreEqual(true, jul.Displayed);
            }

            var jun = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'JUN')]")));
            Assert.AreEqual(true, jun.Displayed);
            if (jun.Displayed)
            {
                Assert.AreEqual(true, jun.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'JUN')]");
                Assert.AreEqual(true, jun.Displayed);
            }

            var may = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'MAY')]")));
            Assert.AreEqual(true, may.Displayed);
            if (may.Displayed)
            {
                Assert.AreEqual(true, jun.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'MAY')]");
                Assert.AreEqual(true, may.Displayed);
            }

            var apr = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'APR')]")));
            Assert.AreEqual(true, apr.Displayed);
            if (apr.Displayed)
            {
                Assert.AreEqual(true, apr.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'APR')]");
                Assert.AreEqual(true, apr.Displayed);
            }

            var mar = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'MAR')]")));
            Assert.AreEqual(true, mar.Displayed);
            if (mar.Displayed)
            {
                Assert.AreEqual(true, mar.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'MAR')]");
                Assert.AreEqual(true, mar.Displayed);
            }

            var feb = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'FEB')]")));
            Assert.AreEqual(true, feb.Displayed);
            if (feb.Displayed)
            {
                Assert.AreEqual(true, feb.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'FEB')]");
                Assert.AreEqual(true, feb.Displayed);
            }

            var jan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'JAN')]")));
            Assert.AreEqual(true, jan.Displayed);
            if (jan.Displayed)
            {
                Assert.AreEqual(true, jan.Displayed);
            }
            else
            {
                Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
                ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

                this.Driver.FindElementByXPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'JAN')]");
                Assert.AreEqual(true, jan.Displayed);
            }
        }

        [Test]
        [Obsolete]
        public void Verifyviewpdf()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyviewpdf");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var statements = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statements')]")));
            Assert.AreEqual(true, statements.Displayed);
            statements.Click();

            var month = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'SEP')]")));
            Assert.AreEqual(true, month.Displayed);

            if (month.Displayed)
            {
                month.Click();
            }
            else
            {
                this.Driver.FindElementByXPath("//XCUIElementTypeButton[contains(@name,'MAY')]").Click();
            }

            var pdfviewer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'PDF Viewer')]")));
            Assert.AreEqual(true, pdfviewer.Displayed);
            pdfviewer.Click();

            var pdfstatement = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Statement')]")));
            Assert.AreEqual(true, pdfstatement.Displayed);

             this.Test.Log(LogStatus.Pass, "pdf is validated");
        }

        [Test]
        [Obsolete]
        public void Verifydetails()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifydetails");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            details.Click();

            var accounttype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'ACCOUNT TYPE')]")));
            Assert.AreEqual(true, accounttype.Displayed);

            var accountname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'ACCOUNT NAME')]")));
            Assert.AreEqual(true, accountname.Displayed);

            var accountnumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'ACCOUNT NUMBER')]")));
            Assert.AreEqual(true, accountnumber.Displayed);

            var routingnumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'ROUTING NUMBER')]")));
            Assert.AreEqual(true, routingnumber.Displayed);

            this.Test.Log(LogStatus.Pass, "Details validated");
        }

        [Test]
        [Obsolete]
        public void Editaccountmodal()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Editaccountmodal");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            details.Click();

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            edit.Click();

            var rename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Rename')]")));
            Assert.AreEqual(true, rename.Displayed);

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            Assert.AreEqual(true, save.Displayed);

            var cancel = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Cancel')]")));
            Assert.AreEqual(true, cancel.Displayed);

            this.Test.Log(LogStatus.Pass, "Edit Account Modal Validated");
        }

        [Test]
        [Obsolete]
        public void Cancelafteredit()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);


            // Start Report
            this.Test = this.Extent.StartTest("Cancelafteredit");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            details.Click();

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            edit.Click();

            var rename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Rename')]")));
            Assert.AreEqual(true, rename.Displayed);

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            Assert.AreEqual(true, save.Displayed);

            var cancel = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Cancel')]")));
            Assert.AreEqual(true, cancel.Displayed);
            cancel.Click();

            details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            this.Test.Log(LogStatus.Pass, "Cancel brings back to details tab");
        }

        [Test]
        [Obsolete]
        public void Saveafteredit()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Saveafteredit");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            details.Click();

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            edit.Click();

            var rename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Rename')]")));
            Assert.AreEqual(true, rename.Displayed);

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            Assert.AreEqual(true, save.Displayed);
            save.Click();

            details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            this.Test.Log(LogStatus.Pass, "Save brings back to details tab");
        }

        [Test]
        [Obsolete]
        public void Editaccountname()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Editaccountname");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            details.Click();

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            edit.Click();

            var rename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Rename')]")));
            Assert.AreEqual(true, rename.Displayed);

            var textfield = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'SELECT INTEREST CHECKING ACCT')]")));
            Assert.AreEqual(true, textfield.Displayed);
            textfield.Click();
            textfield.SendKeys("a");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            Assert.AreEqual(true, save.Displayed);
            save.Click();

            edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            edit.Click();

            var textfield1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'SELECT INTEREST CHECKING ACCTa')]")));
            Assert.AreEqual(true, textfield1.Displayed);
            textfield1.Click();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeKey[contains(@name,'delete')]")));
            Assert.AreEqual(true, delete.Displayed);
            delete.Click();

            save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            Assert.AreEqual(true, save.Displayed);
            save.Click();

            this.Test.Log(LogStatus.Pass, "Account Name Edited");
        }

        [Test]
        [Obsolete]
        public void Canceleditaccountname()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);


            // Start Report
            this.Test = this.Extent.StartTest("Canceleditaccountname");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            details.Click();

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            edit.Click();

            var rename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Rename')]")));
            Assert.AreEqual(true, rename.Displayed);

            var textfield = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'SELECT INTEREST CHECKING ACCT')]")));
            Assert.AreEqual(true, textfield.Displayed);
            textfield.Click();
            textfield.SendKeys("a");

            var cancel = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Cancel')]")));
            Assert.AreEqual(true, cancel.Displayed);
            cancel.Click();

            details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            this.Test.Log(LogStatus.Pass, "Account Name Edited");
        }

        [Test]
        [Obsolete]
        public void Accountwithpaperstatements()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Accountwithpaperstatements");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("abcd");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));
            checkingaccount.Click();

            var statements = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statements')]")));
            Assert.AreEqual(true, statements.Displayed);
            statements.Click();

            var paperstatement = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Online statements Are Just A Tap Away')]")));
            Assert.AreEqual(true, paperstatement.Displayed);

            var gopaperless = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Go paperless')]")));
            Assert.AreEqual(true, gopaperless.Displayed);

            this.Test.Log(LogStatus.Pass, "validate account that currently has paper statements");
        }

        [Test]
        [Obsolete]
        public void Openestatement()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);


            // Start Report
            this.Test = this.Extent.StartTest("Openestatement");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var statements = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statements')]")));
            Assert.AreEqual(true, statements.Displayed);
            statements.Click();

            var year = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'AUG')]")));
            Assert.AreEqual(true, year.Displayed);
            year.Click();

            var pdfviewer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'PDF Viewer')]")));
            Assert.AreEqual(true, pdfviewer.Displayed);
            pdfviewer.Click();

            var pdfstatement = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Statement')]")));
            Assert.AreEqual(true, pdfstatement.Displayed);

            this.Test.Log(LogStatus.Pass, "E-Statement verified");
        }

        [Test]
        [Obsolete]
        public void Accountshowandhide()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);


            // Start Report
            this.Test = this.Extent.StartTest("Accountshowandhide");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);
            searchaccounts.Click();
            searchaccounts.SendKeys("checking acct");

            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            checkingaccount.Click();

            var details = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Details')]")));
            Assert.AreEqual(true, details.Displayed);
            details.Click();

            var shownumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Show Number')]")));
            Assert.AreEqual(true, shownumber.Displayed);
            shownumber.Click();

            var numbershow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'402097927')]")));
            Assert.AreEqual(true, numbershow.Displayed);

            var hidenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Hide Number')]")));
            Assert.AreEqual(true, hidenumber.Displayed);
            hidenumber.Click();

            var numberhidden = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Show Number')]")));
            Assert.AreEqual(true, numberhidden.Displayed);
            this.Test.Log(LogStatus.Pass, "show and hide validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify filter options")]
        public void Filteroptions()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Filteroptions");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            Assert.AreEqual(true, transactiontype.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Amount')]")));
            Assert.AreEqual(true, amount.Displayed);

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Check Number')]")));
            Assert.AreEqual(true, checknumber.Displayed);

            var threemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'3 Months')]")));
            Assert.AreEqual(true, threemonths.Displayed);

            var sixmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'6 Months')]")));
            Assert.AreEqual(true, sixmonths.Displayed);

            var twelvemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'12 Months')]")));
            Assert.AreEqual(true, twelvemonths.Displayed);

            this.Test.Log(LogStatus.Pass, "show and hide validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify All transactions")]
        public void Alltransaction()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Alltransaction");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            Assert.AreEqual(true, transactiontype.Displayed);
            

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var advancedsearch1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            Assert.AreEqual(true, advancedsearch1.Displayed);

            this.Test.Log(LogStatus.Pass, "filter options validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify all deposits filter")]
        public void Depositfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Depositfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            var alldeposits = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'All Deposits')]")));
            alldeposits.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "deposit filter is validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify all withdrawals filter")]
        public void Withdrawalsfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Withdrawalsfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            var allwithdrawals = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'All Withdrawals')]")));
            allwithdrawals.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "withdrawals filter is validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify ATM filter")]
        public void Atmfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Atmfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            var atm = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'ATM')]")));
            atm.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "ATM filter validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify checks filter")]
        public void Checks()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Checks");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            var checks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Checks')]")));
            checks.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Checks filter validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify debit card filter")]
        public void Debitcardfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Debitcardfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            var debitcard = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Debit Card')]")));
            debitcard.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Debit Card filter validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify Direct Deposits filter")]
        public void Directdeposits()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Directdeposits");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            var directdeposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Direct Deposits')]")));
            directdeposit.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Direct Deposit filter validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify Electronic payments filter")]
        public void Electronicpayments()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Electronicpayments");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var electronicpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Electronic Payments')]")));
            electronicpayments.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Electronic payments filter validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify transfers payments filter")]
        public void Transfers()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Transfers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var transfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfers')]")));
            transfers.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Transfers payments filter validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify wires payments filter")]
        public void Wires()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Wires");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var transactiontype = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transaction Type')]")));
            transactiontype.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var wire = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Wires')]")));
            wire.Click();


            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Wires payments filter validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify last 3 months filter")]
        public void Threemonthsfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Threemonthsfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var threemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'3 Months')]")));
            Assert.AreEqual(true, threemonths.Displayed);

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var advancedsearch1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            Assert.AreEqual(true, advancedsearch1.Displayed);

            this.Test.Log(LogStatus.Pass, "last three months validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify last 6 months filter")]
        public void Sixmonthsfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Sixmonthsfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var sixmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'6 Months')]")));
            Assert.AreEqual(true, sixmonths.Displayed);
            sixmonths.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "six months validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify last 12 months filter")]
        public void Twelvemonthsfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Twelvemonthsfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var choosedate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Choose Dates')]")));
            Assert.AreEqual(true, choosedate.Displayed);
            choosedate.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var enddate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'END DATE Select End Date')]")));
            enddate.Click();

            var done1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done1.Click();

            var done3 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done3.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Custom date validated");
        }

        [Test]
        [Obsolete]
        [Description("verify custom date start date and end date")]
        public void Customstartend()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Customstartend");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var choosedate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Choose Dates')]")));
            Assert.AreEqual(true, choosedate.Displayed);
            choosedate.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var enddate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'END DATE Select End Date')]")));
            enddate.Click();

            var wheel = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypePickerWheel[3]")));
            wheel.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "up" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);


            wheel.GetAttribute("2020");

            var done1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done1.Click();

            var done3 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done3.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Alert')]")));
            Assert.AreEqual(true, alert.Displayed);

            this.Test.Log(LogStatus.Pass, "Custom date start date and end date alert validated");
        }

        [Test]
        [Obsolete]
        [Description("verify all amounts filter")]
        public void Amountsfilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Amountsfilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Amount All')]")));
            amount.Click();

            var all = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'All')]")));
            all.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var advancedsearch1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            Assert.AreEqual(true, advancedsearch1.Displayed);

            this.Test.Log(LogStatus.Pass, "All Amounts Filter Verified");
        }

        [Test]
        [Obsolete]
        [Description("verify Single amounts filter")]
        public void Singlefilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Singlefilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Amount All')]")));
            amount.Click();

            var single = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Single')]")));
            single.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Single Filter Verified");
        }

        [Test]
        [Obsolete]
        [Description("verify range amounts filter")]
        public void Rangefilter()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Rangefilter");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var checkingaccount7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, checkingaccount7927.Displayed);
            checkingaccount7927.Click();

            var searchtransactions = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Search Transactions')]")));
            searchtransactions.Click();

            var advancedsearch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Advanced Search')]")));
            advancedsearch.Click();

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Amount All')]")));
            amount.Click();

            var range = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Range')]")));
            range.Click();

            var min = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeSecureTextField[1]")));
            min.Click();
            min.SendKeys("1");

            var max = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeSecureTextField[2]")));
            max.Click();
            max.SendKeys("123456789");

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var onefilterapplied = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'1 Filter Applied')]")));
            Assert.AreEqual(true, onefilterapplied.Displayed);

            this.Test.Log(LogStatus.Pass, "Range Filter Verified");
        }

        [Test]
        [Obsolete]
        [Description("verify open a new account button")]
        public void Openanewaccount()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Openanewaccount");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);

            this.Test.Log(LogStatus.Pass, "open account button is displayed");
        }

        [Test]
        [Obsolete]
        [Description("verify intro page")]
        public void Intropage()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Intropage");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var premierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Premier Checking')]")));
            Assert.AreEqual(true, premierchecking.Displayed);

            var freechecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Free Checking')]")));
            Assert.AreEqual(true, freechecking.Displayed);

            var statementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statement Savings')]")));
            Assert.AreEqual(true, statementsavings.Displayed);

            this.Test.Log(LogStatus.Pass, "intro page is displayed");
        }

        [Test]
        [Obsolete]
        [Description("verify return arrow returns to the account page")]
        public void Returnarrow()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Returnarrow");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var premierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Premier Checking')]")));
            Assert.AreEqual(true, premierchecking.Displayed);

            var freechecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Free Checking')]")));
            Assert.AreEqual(true, freechecking.Displayed);

            var statementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statement Savings')]")));
            Assert.AreEqual(true, statementsavings.Displayed);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            back.Click();

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Accounts')]")));
            Assert.AreEqual(true, searchaccounts.Displayed);

            this.Test.Log(LogStatus.Pass, "return arrow is verified");
        }

        [Test]
        [Obsolete]
        [Description("intro pages for account opening")]
        public void Intropageaccountopening()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Intropageaccountopening");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var premierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Premier Checking')]")));
            Assert.AreEqual(true, premierchecking.Displayed);
            premierchecking.Click();

            var easternpremierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Premier Checking')]")));
            Assert.AreEqual(true, easternpremierchecking.Displayed);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            back.Click();

            var freechecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Free Checking')]")));
            Assert.AreEqual(true, freechecking.Displayed);
            freechecking.Click();

            var easternfreechecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Free Checking')]")));
            Assert.AreEqual(true, easternfreechecking.Displayed);

            back.Click();

            var statementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statement Savings')]")));
            Assert.AreEqual(true, statementsavings.Displayed);
            statementsavings.Click();

            var easternstatementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Statement Savings')]")));
            Assert.AreEqual(true, easternstatementsavings.Displayed);

            this.Test.Log(LogStatus.Pass, "Intro page for account opening is verified");
        }

        [Test]
        [Obsolete]
        [Description("personal deposit account fees link opens")]
        public void Depositaccountlink()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Depositaccountlink");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var premierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Premier Checking')]")));
            Assert.AreEqual(true, premierchecking.Displayed);
            premierchecking.Click();

            var easternpremierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Premier Checking')]")));
            Assert.AreEqual(true, easternpremierchecking.Displayed);

            var openpremiercheckingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open Premier Checking Account')]")));
            openpremiercheckingaccount.Click();

            var yescontinue = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes, Continue')]")));
            yescontinue.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var transferfundsfrom = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Available Balance')]")));
            transferfundsfrom.Click();


            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'7927')]")));
            acct7927.Click();

            var contin = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            contin.Click();

            var reviewdisclosure = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please review and agree to the disclosure to open an account.')]")));
            Assert.AreEqual(true, reviewdisclosure.Displayed);

            this.Test.Log(LogStatus.Pass, "personal deposit account fees link opens");
        }

        [Test]
        [Obsolete]
        [Description("Open a premier checking account - verify fund account screen option")]
        public void Fundacctscreen()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Fundacctscreen");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var premierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Premier Checking')]")));
            Assert.AreEqual(true, premierchecking.Displayed);
            premierchecking.Click();

            var easternpremierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Premier Checking')]")));
            Assert.AreEqual(true, easternpremierchecking.Displayed);

            var openpremiercheckingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open Premier Checking Account')]")));
            openpremiercheckingaccount.Click();

            var yescontinue = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes, Continue')]")));
            yescontinue.Click();

            var fivehundred = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$500')]")));
            Assert.AreEqual(true, fivehundred.Displayed);

            var thousand = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$1000')]")));
            Assert.AreEqual(true, thousand.Displayed);

            var fifteenhundred = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$1500')]")));
            Assert.AreEqual(true, fifteenhundred.Displayed);

            var twothousand = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$2000')]")));
            Assert.AreEqual(true, twothousand.Displayed);

            var threethousand = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$3000')]")));
            Assert.AreEqual(true, threethousand.Displayed);

            var customamount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Custom Amount')]")));
            Assert.AreEqual(true, customamount.Displayed);

            var contin = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            contin.Click();

            var oops = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Your deposit amount is more than the available balance in your funding account.')]")));
            Assert.AreEqual(true, oops.Displayed);

            this.Test.Log(LogStatus.Pass, "fund account screen options verified");
        }

        [Test]
        [Obsolete]
        [Description("Open a statement savings account - verify fund account screen option")]
        public void Statementsavings()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Statementsavings");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var statementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statement Savings')]")));
            Assert.AreEqual(true, statementsavings.Displayed);
            statementsavings.Click();

            var easternstatementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Statement Savings')]")));
            Assert.AreEqual(true, easternstatementsavings.Displayed);

            var openstatementsavingsaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open Statement Savings Account')]")));
            openstatementsavingsaccount.Click();

            var ten = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$10')]")));
            Assert.AreEqual(true, ten.Displayed);

            var twenty = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$20')]")));
            Assert.AreEqual(true, twenty.Displayed);

            var fifty = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$50')]")));
            Assert.AreEqual(true, fifty.Displayed);

            var hundred = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$100')]")));
            Assert.AreEqual(true, hundred.Displayed);

            var twohundred = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'$200')]")));
            Assert.AreEqual(true, twohundred.Displayed);

            var customamount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Custom Amount')]")));
            Assert.AreEqual(true, customamount.Displayed);

            customamount.Click();

            var customamountdepo = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            customamountdepo.SendKeys("1");

            var fundyouraccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Fund Your Account')]")));
            fundyouraccount.Click();

            var contin = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            contin.Click();

            var oops = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please enter an amount of at least $10.00 to fund your new account.')]")));
            Assert.AreEqual(true, oops.Displayed);

            this.Test.Log(LogStatus.Pass, "statement savings account screen options verified");
        }

        [Test]
        [Obsolete]
        [Description("Review Disclosure")]
        public void Reviewdisclosure()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Reviewdisclosure");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var statementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Statement Savings')]")));
            Assert.AreEqual(true, statementsavings.Displayed);
            statementsavings.Click();

            var easternstatementsavings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Statement Savings')]")));
            Assert.AreEqual(true, easternstatementsavings.Displayed);

            var openstatementsavingsaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open Statement Savings Account')]")));
            openstatementsavingsaccount.Click();

            var contin = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            contin.Click();

            var pleasereview = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please review and agree to the disclosure to open an account.')]")));
            Assert.AreEqual(true, pleasereview.Displayed);

            this.Test.Log(LogStatus.Pass, "reviewed disclosure");
        }

        [Test]
        [Obsolete]
        [Description("Verify Debit Card Setup Options")]
        public void Debitcardsetup()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Debitcardsetup");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var openanewaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open A New Account')]")));
            Assert.AreEqual(true, openanewaccount.Enabled);
            openanewaccount.Click();

            var premierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Premier Checking')]")));
            Assert.AreEqual(true, premierchecking.Displayed);
            premierchecking.Click();

            var easternpremierchecking = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Premier Checking')]")));
            Assert.AreEqual(true, easternpremierchecking.Displayed);

            var openpremiercheckingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Open Premier Checking Account')]")));
            openpremiercheckingaccount.Click();

            var yescontinue = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes, Continue')]")));
            yescontinue.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var transferfundsfrom = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Available Balance')]")));
            transferfundsfrom.Click();


            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'7927')]")));
            acct7927.Click();

            var contin = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            contin.Click();

            var reviewdisclosure = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please review and agree to the disclosure to open an account.')]")));
            Assert.AreEqual(true, reviewdisclosure.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var nocontinue = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'No, Continue')]")));
            nocontinue.Click();

            var nodebit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[14]/XCUIElementTypeOther[contains(@name,'No')]")));
            nodebit.Click();

            contin.Click();

            var reviewandsubmit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Review and Submit')]")));
            Assert.AreEqual(true, reviewandsubmit.Displayed);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            back.Click();

            var yesdebit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[13]")));
            yesdebit.Click();

            var nomail = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[18]")));
            nomail.Click();

            contin.Click();

            Assert.AreEqual(true, reviewdisclosure.Displayed);

            back.Click();

            var yesmail = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[17]")));
            yesmail.Click();

            contin.Click();

            var error = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Error: Please enter a 4 digit PIN. Swipe backwards to enter')]")));
            Assert.AreEqual(true, error.Displayed);

            var fourdigit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypeSecureTextField[1]")));
            fourdigit.Click();
            fourdigit.SendKeys("1111");

            var confirmfourdigit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypeSecureTextField[2]")));
            fourdigit.Click();
            confirmfourdigit.SendKeys("1112");

            var debitcard = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Debit Card')]")));
            debitcard.Click();

            contin.Click();

            var error1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Error: Your PINs must match. Swipe backwards to enter')]")));
            Assert.AreEqual(true, error1.Displayed);

            fourdigit.Click();
            confirmfourdigit.SendKeys("1111");
            debitcard.Click();
            contin.Click();
            Assert.AreEqual(true, reviewdisclosure.Displayed);

            this.Test.Log(LogStatus.Pass, "reviewed disclosure");
        }

        [Test]
        [Obsolete]
        [Description("verify deposit tab")]
        public void Deposittab()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Deposittab");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchdeposit = new TouchAction(this.Driver);

            var deposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit')]")));
            Assert.IsTrue(deposit.Enabled);

            touchdeposit.LongPress(deposit);
            touchdeposit.Perform();

            var makecheckdeposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Check Deposit')]")));
            Assert.AreEqual(true, makecheckdeposit.Displayed);

            var checkdeposithistory = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Check Deposit History')]")));
            Assert.AreEqual(true, checkdeposithistory.Displayed);

            this.Test.Log(LogStatus.Pass, "verify depostit tab");
        }

        [Test]
        [Obsolete]
        [Description("check pictures not sufficient errors")]
        public void Picturenotsufficienterrors()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Picturenotsufficienterrors");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchdeposit = new TouchAction(this.Driver);

            var deposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit')]")));
            Assert.IsTrue(deposit.Enabled);

            touchdeposit.LongPress(deposit);
            touchdeposit.Perform();

            var makecheckdeposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Check Deposit')]")));
            Assert.AreEqual(true, makecheckdeposit.Displayed);
            makecheckdeposit.Click();

            var front = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'FRONT')]")));
            Assert.AreEqual(true, front.Displayed);
            front.Click();

            var ok = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'OK')]")));
            Assert.AreEqual(true, ok.Displayed);
            ok.Click();

            var takeapicture = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Take a Picture')]")));
            Assert.AreEqual(true, takeapicture.Displayed);
            takeapicture.Click();

            var captureimage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage.Displayed);
            captureimage.Click();

           var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'BACK')]")));
            Assert.AreEqual(true, back.Displayed);
            back.Click();

            var captureimage2 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage2.Displayed);
            captureimage2.Click();

            var checkamount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Check Amount')]")));
            checkamount.Click();
            checkamount.SendKeys("1111");

            var chooseaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit To Choose Account')]")));
            Assert.AreEqual(true, chooseaccount.Displayed);
            chooseaccount.Click();

            var acc7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'7927')]")));
            acc7927.Click();

            var continueto = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            continueto.Click();

            var depositcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit Check')]")));
            depositcheck.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypeOther/XCUIElementTypeStaticText[contains(@name,'Alert')]")));
            Assert.AreEqual(true, alert.Displayed);

            this.Test.Log(LogStatus.Pass, "check deposit errors verified");
        }

        [Test]
        [Obsolete]
        [Description("Verify Check Deposit Errors")]
        public void Depositerror()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Depositerror");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchdeposit = new TouchAction(this.Driver);

            var deposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit')]")));
            Assert.IsTrue(deposit.Enabled);

            touchdeposit.LongPress(deposit);
            touchdeposit.Perform();

            var makecheckdeposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Check Deposit')]")));
            Assert.AreEqual(true, makecheckdeposit.Displayed);
            makecheckdeposit.Click();

            var checkamount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Check Amount')]")));
            checkamount.Click();
            checkamount.SendKeys("1111");

            var front = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'FRONT')]")));
            Assert.AreEqual(true, front.Displayed);
            front.Click();

            var ok = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'OK')]")));
            Assert.AreEqual(true, ok.Displayed);
            ok.Click();

            var takeapicture = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Take a Picture')]")));
            Assert.AreEqual(true, takeapicture.Displayed);
            takeapicture.Click();

            var captureimage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage.Displayed);
            captureimage.Click();

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'BACK')]")));
            Assert.AreEqual(true, back.Displayed);
            back.Click();

            var captureimage2 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage2.Displayed);
            captureimage2.Click();

           

            var continueto = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            continueto.Click();

            

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypeOther/XCUIElementTypeStaticText[contains(@name,'Please choose an account.')]")));
            Assert.AreEqual(true, alert.Displayed);

            this.Test.Log(LogStatus.Pass, "check deposit errors verified");
        }

        [Test]
        [Obsolete]
        [Description("Verify back button confirmation popup")]
        public void Backbuttonconfirmation()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Backbuttonconfirmation");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchdeposit = new TouchAction(this.Driver);

            var deposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit')]")));
            Assert.IsTrue(deposit.Enabled);

            touchdeposit.LongPress(deposit);
            touchdeposit.Perform();

            var makecheckdeposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Check Deposit')]")));
            Assert.AreEqual(true, makecheckdeposit.Displayed);
            makecheckdeposit.Click();

            var front = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'FRONT')]")));
            Assert.AreEqual(true, front.Displayed);
            front.Click();

            var ok = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'OK')]")));
            Assert.AreEqual(true, ok.Displayed);
            ok.Click();

            var takeapicture = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Take a Picture')]")));
            Assert.AreEqual(true, takeapicture.Displayed);
            takeapicture.Click();

            var captureimage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage.Displayed);
            captureimage.Click();

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'BACK')]")));
            Assert.AreEqual(true, back.Displayed);
            back.Click();

            var captureimage2 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage2.Displayed);
            captureimage2.Click();

            var checkamount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Check Amount')]")));
            checkamount.Click();
            checkamount.SendKeys("1111");

            var chooseaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit To Choose Account')]")));
            Assert.AreEqual(true, chooseaccount.Displayed);
            chooseaccount.Click();

            var acc7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'7927')]")));
            acc7927.Click();

            var cancel = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            cancel.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Cancel Deposit?')]")));
            Assert.AreEqual(true, alert.Displayed);

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes')]")));
            yes.Click();

            
            
            makecheckdeposit.Click();


            this.Test.Log(LogStatus.Pass, "Back button confirmed");
        }

        [Test]
        [Obsolete]
        [Description("Make a mobile check deposit and confirm error for daily limit consumer")]
        public void Dailylimit()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Dailylimit");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchdeposit = new TouchAction(this.Driver);

            var deposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit')]")));
            Assert.IsTrue(deposit.Enabled);

            touchdeposit.LongPress(deposit);
            touchdeposit.Perform();

            var makecheckdeposit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Check Deposit')]")));
            Assert.AreEqual(true, makecheckdeposit.Displayed);
            makecheckdeposit.Click();

            var front = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'FRONT')]")));
            Assert.AreEqual(true, front.Displayed);
            front.Click();

            var ok = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'OK')]")));
            Assert.AreEqual(true, ok.Displayed);
            ok.Click();

            var takeapicture = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Take a Picture')]")));
            Assert.AreEqual(true, takeapicture.Displayed);
            takeapicture.Click();

            var captureimage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage.Displayed);
            captureimage.Click();

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'BACK')]")));
            Assert.AreEqual(true, back.Displayed);
            back.Click();

            var captureimage2 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Capture image')]")));
            Assert.AreEqual(true, captureimage2.Displayed);
            captureimage2.Click();

            var checkamount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Check Amount')]")));
            checkamount.Click();
            checkamount.SendKeys("300001");

            var chooseaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Deposit To Choose Account')]")));
            Assert.AreEqual(true, chooseaccount.Displayed);
            chooseaccount.Click();

            var acc7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'7927')]")));
            acc7927.Click();

            var continueto = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            continueto.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypeOther/XCUIElementTypeStaticText[contains(@name,'Alert')]")));
            Assert.AreEqual(true, alert.Displayed);

            this.Test.Log(LogStatus.Pass, "daily limit validated");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen")]
        public void Whoisapplying()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Whoisapplying");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            Assert.AreEqual(true, justme.Displayed);

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            this.Test.Log(LogStatus.Pass, "verified loan screen");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- verify exit application button")]
        public void Exitapplicationbutton()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Exitapplicationbutton");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var cancel = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Cancel')]")));
            cancel.Click();

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();



            this.Test.Log(LogStatus.Pass, "Exit Application Button Verified");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- verify exit application button with usa patriot act selected")]
        public void Exitwithussapatriotact()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Exitwithussapatriotact");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            back.Click();

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            this.Test.Log(LogStatus.Pass, "Exit Application button with usa patriot act notice selected is verified");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- verify easternbank.com link")]
        public void Verifyeasternbanklink()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyeasternbanklink");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            var easternbankpersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Eastern Bank Personal Loan')]")));
            Assert.AreEqual(true, easternbankpersonalloan.Displayed);

            this.Test.Log(LogStatus.Pass, "eassternbank.com link is verified");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- verify just me")]
        public void Verifyjustme()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyjustme");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var awesome = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeStaticText[contains(@name,'Awesome!')]")));
            Assert.AreEqual(true, awesome.Displayed);

            this.Test.Log(LogStatus.Pass, "just me verified");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- Verify Two of us button")]
        public void Verifytwoofus()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifytwoofus");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            var tellusaboutthejointapplicant = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about the joint applicant')]")));
            Assert.AreEqual(true, tellusaboutthejointapplicant.Displayed);

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var birthday = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypeButton[contains(@name,'Birthday')]")));
            Assert.AreEqual(true, birthday.Displayed);

            this.Test.Log(LogStatus.Pass, "Two us button is verified");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- Verify Two of us button - verify secondary applicant name with alphanumeric characters only")]
        public void Verifyalphanumericcharecters()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyalphanumericcharecters");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            var tellusaboutthejointapplicant = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about the joint applicant')]")));
            Assert.AreEqual(true, tellusaboutthejointapplicant.Displayed);

            var joinapplicantsfirstname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            joinapplicantsfirstname.Click();
            joinapplicantsfirstname.SendKeys("hello123");

            var joinapplicantslastname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[2]")));
            joinapplicantslastname.Click();
            joinapplicantslastname.SendKeys("east123");

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var birthday = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Birthday')]")));
            Assert.AreEqual(true, birthday.Displayed);

            this.Test.Log(LogStatus.Pass, "Alphanumeric characters verified for second applicant");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- Verify Two of us button - verify secondary applicant with symbols")]
        public void Verifysymbols()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifysymbols");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            var tellusaboutthejointapplicant = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about the joint applicant')]")));
            Assert.AreEqual(true, tellusaboutthejointapplicant.Displayed);

            var joinapplicantsfirstname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            joinapplicantsfirstname.Click();
            joinapplicantsfirstname.SendKeys("@@@!!!");

            var joinapplicantslastname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[2]")));
            joinapplicantslastname.Click();
            joinapplicantslastname.SendKeys("@@@!!!");

            tellusaboutthejointapplicant.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var birthday = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Birthday')]")));
            Assert.AreEqual(true, birthday.Displayed);

            this.Test.Log(LogStatus.Pass, "symbols verified for second applicant");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- Verify Two of us button - verify secondary applicant social security number with numeric characters")]
        public void Ssnwithnumeric()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Ssnwithnumeric");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            var tellusaboutthejointapplicant = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about the joint applicant')]")));
            Assert.AreEqual(true, tellusaboutthejointapplicant.Displayed);

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var ssn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeSecureTextField[1]")));
            ssn.Click();
            ssn.SendKeys("123@@##123");

            var ssn1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeSecureTextField[contains(@value,'••••••')]")));
            Assert.AreEqual(true, ssn1.Displayed);

            this.Test.Log(LogStatus.Pass, "symbols verified for second applicant");
        }

        [Test]
        [Obsolete]
        [Description("Verify who is applying for this loan screen- Apply as Just Me/Two of Us - Verify Continue Button Takes to How Much Would You Like to Borrrow Screen")]
        public void Sowmuchwouldyouliketoborrow()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Sowmuchwouldyouliketoborrow");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            Assert.AreEqual(true, oneyear.Displayed);

            var twoyears = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'2 Years')]")));
            Assert.AreEqual(true, twoyears.Displayed);

            var threeyears = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'3 Years')]")));
            Assert.AreEqual(true, threeyears.Displayed);

            var fouryears = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'4 Years')]")));
            Assert.AreEqual(true, fouryears.Displayed);

            var fiveyears = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'5 Years')]")));
            Assert.AreEqual(true, fiveyears.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - How Much Would You Like to Borrrow Screen - Verify Back Button")]
        public void Verifyback()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyback");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            back.Click();

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - How Much Would You Like to Borrrow Screen - Verify Continue Button with Empty/Blank Fields - Failed")]
        public void Verifycontinuebuttonwithemptyblankfields()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifycontinuebuttonwithemptyblankfields");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var error = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Error: Please enter the loan amount.')]")));
            Assert.AreEqual(true, error.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - How Much Would You Like to Borrrow Screen - Verify Amount Text Box Do Not Accept Less Than the Min/ More Than Max Amount")]
        public void Maxmin()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Maxmin");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("1999");

            howmuch.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var error = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please select any one loan pay off duration.')]")));
            Assert.AreEqual(true, error.Displayed);

            var ok = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Ok')]")));
            ok.Click();

            amount.Click();
            amount.SendKeys("9");

            howmuch.Click();

            next1.Click();

            var error1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please select any one loan pay off duration.')]")));
            Assert.AreEqual(true, error1.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - How Much Would You Like to Borrrow Screen - Verify Amount Text Box with Numeric Characters Only - Success")]
        public void Amounttextboxnumericcharacteronly()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Amounttextboxnumericcharacteronly");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("1999ab##");

            howmuch.Click();


            var amount1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'1999')]")));
            Assert.AreEqual(true, amount1.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - How Much Would You Like to Borrrow Screen - Verify Amount Text Box with Maximum of Numbers of Characters")]
        public void Maximumofnumbersaccepted()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Maximumofnumbersaccepted");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("1234567");

            howmuch.Click();


            var amount1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'12345')]")));
            Assert.AreEqual(true, amount1.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me - How Much Would You Like to Borrrow Screen - Verify Continue Button Takes to How Can We Reach You Screen")]
        public void Howcanwereachyou()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Howcanwereachyou");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var email = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Email Address')]")));
            Assert.AreEqual(true, email.Displayed);

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Two of Us - How Much Would You Like to Borrrow Screen - Verify Continue Button Takes to How Can We Reach You Screen")]
        public void Howcanwereachyou2()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Howcanwereachyou2");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            var tellusaboutthejointapplicant = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about the joint applicant')]")));
            Assert.AreEqual(true, tellusaboutthejointapplicant.Displayed);

            var joinapplicantsfirstname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            joinapplicantsfirstname.Click();
            joinapplicantsfirstname.SendKeys("abcd");

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var joinapplicantslastname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[2]")));
            joinapplicantslastname.Click();
            joinapplicantslastname.SendKeys("efgh");

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var ssn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeSecureTextField[1]")));
            ssn.Click();
            ssn.SendKeys("123456789");

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);


            var birthday = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Birthday')]")));
            Assert.AreEqual(true, birthday.Displayed);
            birthday.Click();

            var year = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypePickerWheel[3]")));
            Assert.AreEqual(true, year.Displayed);
            year.Click();

            Dictionary<string, string> scrollObject1 = new Dictionary<string, string>
            {
                { "direction", "up" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject1);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject1);

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var next2 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next2.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var email = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Email Address')]")));
            Assert.AreEqual(true, email.Displayed);

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me- Verify Contact Information Screen")]
        public void Verifycontactinformation()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifycontactinformation");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var email = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Email Address')]")));
            Assert.AreEqual(true, email.Displayed);

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply Two of Us - Verify Contact Information Screen")]
        public void Verifycontactinformation2()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifycontactinformation2");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var twoofus = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Two of Us')]")));
            Assert.AreEqual(true, twoofus.Displayed);
            twoofus.Click();

            var tellusaboutthejointapplicant = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about the joint applicant')]")));
            Assert.AreEqual(true, tellusaboutthejointapplicant.Displayed);

            var joinapplicantsfirstname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            joinapplicantsfirstname.Click();
            joinapplicantsfirstname.SendKeys("abcd");

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var joinapplicantslastname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[2]")));
            joinapplicantslastname.Click();
            joinapplicantslastname.SendKeys("efgh");

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var ssn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeSecureTextField[1]")));
            ssn.Click();
            ssn.SendKeys("123456789");

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);


            var birthday = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Birthday')]")));
            Assert.AreEqual(true, birthday.Displayed);
            birthday.Click();

            var year = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//	XCUIElementTypePickerWheel[3]")));
            Assert.AreEqual(true, year.Displayed);
            year.Click();

            Dictionary<string, string> scrollObject1 = new Dictionary<string, string>
            {
                { "direction", "up" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject1);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject1);

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var next2 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next2.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var email = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Email Address')]")));
            Assert.AreEqual(true, email.Displayed);

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - Contact Information Screen - Verify Back Button")]
        public void contactinfoverifybackbutton()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("contactinfoverifybackbutton");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            back.Click();



            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - Contact Information Screen - Verify Continue Button with Empty/Blank Fields")]
        public void Continuewithemptyfield()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("ontinuewithemptyfield");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            



            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - Contact Information - Verify Email Address with Alphanumeric and Special Characters")]
        public void EmailAddresswithAlphanumericandspecial()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("EmailAddresswithAlphanumericandspecial");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var email = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Email Address')]")));
            Assert.AreEqual(true, email.Displayed);
            email.Click();
            email.SendKeys("");

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - Contact Information - Verify Home Phone Number with Symbols")]
        public void Verifyhomephonenumberwithsymbols()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyhomephonenumberwithsymbols");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);
            phonenumber.Click();
            phonenumber.SendKeys("");

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - Contact Information - Verify Home Phone Number with Maximum of Numbers of Characters")]
        public void phonenumberwithmaxchar()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("phonenumberwithmaxchar");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);
            phonenumber.Click();
            phonenumber.SendKeys("");

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - Contact Information - Verify Home Phone Number with 1 character only")]
        public void phonenumberwithonechar()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("phonenumberwithonechar");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var phonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Phone Number')]")));
            Assert.AreEqual(true, phonenumber.Displayed);
            phonenumber.Click();
            phonenumber.SendKeys("");

            this.Test.Log(LogStatus.Pass, "verified");
        }

        [Test]
        [Obsolete]
        [Description("Apply as Just Me/Two of Us - Contact Information - Verify Mailing Address with Symbols")]
        public void Mailingaddresswithsymbols()
        {
            this.accountsPage = new AccountsPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Mailingaddresswithsymbols");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var needapersonalloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Need a Personal Loan? See If You Qualify In Less Than 5 Minutes.')]")));
            needapersonalloan.Click();

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var applynow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Apply Now!')]")));
            applynow.Click();

            var whoisapplying = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Who is applying for this loan?')]")));
            Assert.AreEqual(true, whoisapplying.Displayed);

            var justme = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Just Me')]")));
            justme.Click();

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var uspatriotactnotice = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'USA Patriot Act Notice')]")));
            Assert.AreEqual(true, uspatriotactnotice.Displayed);

            var agree = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Agree')]")));
            agree.Click();

            var tellusaboutyourloan = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Tell us about your loan')]")));
            Assert.AreEqual(true, tellusaboutyourloan.Displayed);

            var howmuch = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How much would you like to borrow?')]")));
            Assert.AreEqual(true, howmuch.Displayed);

            var amount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            amount.Click();
            amount.SendKeys("2000");

            howmuch.Click();

            var oneyear = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'1 Year')]")));
            oneyear.Click();

            var next1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next1.Click();

            var howcanwereachyou = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
          ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'How can we reach you?')]")));
            Assert.AreEqual(true, howcanwereachyou.Displayed);

            var email = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
         ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Email Address')]")));
            Assert.AreEqual(true, email.Displayed);
            email.Click();
            email.SendKeys("");

            this.Test.Log(LogStatus.Pass, "verified");
        }
    }
}
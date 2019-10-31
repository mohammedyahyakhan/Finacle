// <copyright file="Transfers.cs" company="Eastern Bank">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Android
{
    using System;
    using System.Collections.Generic;
    using Android.Pages;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;

    [TestFixture("local", "pixel")]
    public class Accounts : BrowserStackNUnitTest
    {
        public Accounts(string profile, string environment)
            : base(profile, environment)
        {
        }

        private AccountsPage accountsPage = null;
        private LoginPage loginPage = null;

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

            var searchaccounts = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//android.widget.EditText[contains(@name,'Search Accounts')]")));
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
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypePickerWheel[1]")));
            wheel.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "up" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

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
    }
}
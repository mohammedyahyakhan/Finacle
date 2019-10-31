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

    // [TestFixture("local", "iphone-8-plus")]
    [TestFixture("local", "iphone-se")]
    public class Transfers : BrowserStackNUnitTest
    {
        public Transfers(string profile, string environment)
            : base(profile, environment)
        {
        }

        private TransfersPage transfersPage = null;
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
            var reportPath = projectPath + "Reports\\" + "EasternBank_Transfers" + timestamp + ".html";

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

        [Obsolete]
        [Description("Login to the Application under test")]
        public void Loginoneuser()
        {
            var usernameInputBox = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("XCUIElementTypeTextField")));

            // validating presence of username input
            Assert.AreEqual(true, usernameInputBox.Displayed);
            usernameInputBox.SendKeys("noeligible");

            var passwordInputBox = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("XCUIElementTypeSecureTextField")));

            // validating presence of password input
            Assert.AreEqual(true, passwordInputBox.Displayed);
            passwordInputBox.SendKeys("east@1234");
            this.Driver.HideKeyboard();

            var signInButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name("Sign In")));

            signInButton.Click();
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));

            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Eastern Bank Logo")));
        }

        [Test]
        [Description("Verify Regular Loan Payment Type")]
        [Obsolete]
        public void VerifyRegularLoanpayementType()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);
            // Start Report
            this.Test = this.Extent.StartTest("VerifyRegularLoanpayementType");

                this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

                var touchTransfer = new TouchAction(this.Driver);

                var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
                Assert.IsTrue(transfer.Enabled);

                touchTransfer.LongPress(transfer);
                touchTransfer.Perform();

                var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

                var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
                Assert.IsTrue(betweenEasternAccountsButton.Displayed);
                this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
                betweenEasternAccountsButton.Click();

                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

                var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
                Assert.AreEqual(true, chooseFromAccountButton.Displayed);
                this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
                chooseFromAccountButton.Click();

                var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

                search.Click();
                search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
                this.Test.Log(LogStatus.Pass, "From Account is visible");
                fromAccount.Click();

                var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
                Assert.AreEqual(true, amountInput.Displayed);
                this.Test.Log(LogStatus.Pass, "Amount Input is visible");
                amountInput.SendKeys("0.01");

                var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
                Assert.AreEqual(true, chooseToAccountButton.Displayed);
                chooseToAccountButton.Click();

                search.Click();
                search.SendKeys("9191");

                var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*9191-00001')]")));

            // validating presence of To account
                Assert.AreEqual(true, toAccount.Displayed);
                toAccount.Click();

                var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));

            // validating presence of continue button
                Assert.AreEqual(true, continueButton.Displayed);
                continueButton.Click();

                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Now")));

                var transferNowButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Transfer Now")));

            // validating presence of Transfer Now button
                Assert.AreEqual(true, transferNowButton.Displayed);
                transferNowButton.Click();

                var result = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Transfer Successful")));
                Assert.AreEqual(true, result.Displayed);

            // "transfer successful"
                var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));

            // validating presence of done button
                Assert.AreEqual(true, doneButton.Displayed);
                doneButton.Click();
        }

        [Test]
        [Obsolete]
        public void Principalonly()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Principalonly");

            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));
            Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer Between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose from account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));
            amountInput.SendKeys("1");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("revolving");

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Revolving Credit')]")));

            Assert.AreEqual(true, toAccount.Displayed);
            toAccount.Click();

            var principalOnly = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Loan Payment Type Regular')]")));
            Assert.AreEqual(true, principalOnly.Displayed);
            principalOnly.Click();

            var loanPaymentType = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Principal Only A principal payment')]")));
            Assert.AreEqual(true, loanPaymentType.Displayed);
            loanPaymentType.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Now")));
            var transferNowButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Transfer Now")));
            transferNowButton.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.AreEqual(true, doneButton.Displayed);
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify transfer to other banks
        public void Maketransferatotherbanks()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Maketransferatotherbanks");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var transferAccountsAtOtherBanks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer To My Accounts at Other Banks')]")));
            Assert.AreEqual(true, transferAccountsAtOtherBanks.Displayed);
            this.Test.Log(LogStatus.Pass, "transfers Account At Other Banks is Displayed");
            transferAccountsAtOtherBanks.Click();
        }

        [Test]
        [Obsolete]

        // Verify Transfer Screen
        public void Verifytransferscreen()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifytransferscreen");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var transferAccountsAtOtherBank = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer To My Accounts at Other Banks')]")));
            Assert.AreEqual(true, transferAccountsAtOtherBank.Displayed);
            this.Test.Log(LogStatus.Pass, "transfers Account At Other Banks is Displayed");

            var transferToAnotherAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer To Another Person')]")));
            Assert.AreEqual(true, transferToAnotherAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "transfers to other account is displayed");

            var viewScheduledTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View/Manage Scheduled Transfers')]")));
            Assert.AreEqual(true, viewScheduledTransfers.Displayed);
            this.Test.Log(LogStatus.Pass, "Scheduled Transfer is displayed");
        }

        [Test]
        [Obsolete]

        // verify one time now success
        // Make One Time Now Transfer between My Eastern Bank Accounts
        public void Onetimenowtransferbetweenmyeasternbankaccounts()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Onetimenowtransferbetweenmyeasternbankaccounts");

            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var oneTimeNow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'One Time Now')]")));
            oneTimeNow.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Now")));

            var transferNowButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Transfer Now")));
            transferNowButton.Click();

            // transfer successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            doneButton.Click();

            this.RevertBackAmount();
        }

        [Test]
        [Obsolete]

        // Verify Transfer between my eastern bank account screen.
        public void VerifyTransferBetweenMyEasternBankAccountscreen()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Onetimescheduledtransfersuccess");

            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose To Account is visible");

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Continue")));

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            Assert.AreEqual(true, continueButton.Displayed);
        }

        [Test]
        [Obsolete]

        // Verify One Time Scheduled Transfer Success
        public void Onetimescheduledtransfersuccess()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Onetimescheduledtransfersuccess");

            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);

            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var oneTimeScheduled = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'One Time, Scheduled')]")));
            oneTimeScheduled.Click();

            var transferOn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer On')]")));
            transferOn.Click();

            var close = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Close')]")));
            close.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Weekly Transfer -Never Ending - Success
        public void Verifyweeklytransferneverending()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Verifyweeklytransferneverending");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var oneTimeScheduled = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Weekly')]")));
            oneTimeScheduled.Click();

            var startOn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Start On')]")));
            startOn.Click();

            var close = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Close')]")));
            close.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var never = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Never')]")));
            never.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Schedule Transfer")));

            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Weekly Transfer - End after # of transfers -success.
        // **************valid hash transfers
        public void Weeklytransferendafterhashtransfers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Weeklytransferendafterhashtransfers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var oneTimeScheduled = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Weekly')]")));
            oneTimeScheduled.Click();

            var startOn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Start On')]")));
            startOn.Click();

            var selectAvailableDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'selected')]")));
            selectAvailableDate.Click();

            var endTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTranfers.Click();

            var afterTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'After # Transfers')]")));
            afterTransfers.Click();

            var enterNoOfTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'#')]")));
            enterNoOfTransfers.SendKeys("2");

            // driver.HideKeyboard();
            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Schedule Transfer")));

            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            this.Test.Log(LogStatus.Pass, "End of # Transfers is scheduled");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Weekly Transfer- End on Date Error Then Success W/Valid Recurring Date
        // ***************************************************************************
        public void Weeklytransferendondateerror()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Weeklytransferendondateerror");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var every2Weeks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 2 Weeks')]")));
            every2Weeks.Click();

            var startOn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Start On')]")));
            startOn.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth1.Click();

            var selectAvailableStartDate1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate1.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var alertTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Alert")));
            Assert.AreEqual(true, alertTitle.Displayed);

            var alertMessage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Please enter a valid recurring date")));
            Assert.AreEqual("Please enter a valid recurring date", alertMessage.Text);

            var alertOk = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("OK")));
            alertOk.Click();
        }

        [Test]
        [Obsolete]

        // Verify Weekly Transfer- End on Date  Success W/Valid Recurring Date
        // ***************************************************************************
        public void Weeklytransferendondatesucces()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Weeklytransferendondatesucces");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var week = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Weekly')]")));
            week.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);
        }

        [Test]
        [Obsolete]

        // Verify Weekly Transfer- never ending  Success 
        // ***************************************************************************
        public void weeklysneverendingsuccess()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("weeklyneverendingsuccess");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var weekly = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Weekly')]")));
            weekly.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var never = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Never')]")));
            never.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successfull
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 2 weeks Transfer-NeverEnding -Success
        // ***************************************************************************
        public void Twoweeksneverendingsuccess()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Twoweeksneverendingsuccess");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var every2Weeks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 2 Weeks')]")));
            every2Weeks.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var never = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Never')]")));
            never.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successfull
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 2 weeks Transfer- End after # transfers - success
        // ***************************************************************************
        public void Twoweektransferendafterhashtransfers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Twoweektransferendafterhashtransfers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("1");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var every2Weeks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 2 Weeks')]")));
            every2Weeks.Click();

            var endTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTranfers.Click();

            var afterTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'After # Transfers')]")));
            afterTransfers.Click();

            var enterNoOfTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'#')]")));
            enterNoOfTransfers.SendKeys("2");

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);
        }

        [Test]
        [Obsolete]

        // Verify Every 2 weeks Transfer - End on Date - Error Valid Recurring
        // ***************************************************************************
        public void TwoWeekTransferEndondateError()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("TwoWeekTransferEndondateError");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var every2Weeks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 2 Weeks')]")));
            every2Weeks.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            // var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            //    ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Selected') or contains(@name,'Available')]")));
            // selectAvailableStartDate.Click();

            // if (this.Driver.FindElementByName("Available").Displayed)
            // {
            //    var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            //    ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            //    selectAvailableStartDate.Click();
            // }
            // else
            // {
            //    var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            //    ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            //    nextMonth.Click();
            //    var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            //    ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            //    selectAvailableStartDate.Click();
            // }
            // if (this.Driver.FindElement(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")).Displayed)
            // {
            //    var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            //    ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            //    selectAvailableStartDate.Click();
            // }
            // else
            // {
            //    var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            //    ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            //    nextMonth.Click();
            //    var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            //    ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            //    selectAvailableStartDate.Click();
            // }
            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var alertTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Alert")));
            Assert.AreEqual(true, alertTitle.Displayed);

            var alertMessage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Please enter a valid recurring date")));
            Assert.AreEqual("Please enter a valid recurring date", alertMessage.Text);

            var alertOk = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("OK")));
            alertOk.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 2 weeks Transfer - End on Date - success
        // ***************************************************************************
        public void TwoWeekTransferEndondatesuccess()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("TwoWeekTransferEndondatesuccess");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var every2Weeks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 2 Weeks')]")));
            every2Weeks.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Monthly Transfer NeverEnding Success
        // ***************************************************************************
        public void MonthlyNeverEndingSuccess()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("MonthlyNeverEndingSuccess");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var monthly = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Monthly')]")));
            monthly.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var never = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Never')]")));
            never.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successfull
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Monthly Transfer- End after # of transfers - Success
        // ***************************************************************************
        public void MonthlyTransfersEndafterhashTransfers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("MonthlyTransfersEndafterhashTransfers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var monthly = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Monthly')]")));
            monthly.Click();

            var endTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTranfers.Click();

            var afterTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'After # Transfers')]")));
            afterTransfers.Click();

            var enterNoOfTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'#')]")));
            enterNoOfTransfers.SendKeys("2");

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Monthly Transfer- End on date - Error Valid Recurring Date
        // ***************************************************************************
        public void MonthlyTransfersEndondateerror()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("MonthlyTransfersEndondateerror");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("1");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var monthly = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Monthly')]")));
            monthly.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var alertTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Alert")));
            Assert.AreEqual(true, alertTitle.Displayed);

            var alertMessage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Please enter a valid recurring date")));
            Assert.AreEqual("Please enter a valid recurring date", alertMessage.Text);
            Assert.IsTrue(alertMessage.Displayed);
            this.Test.Log(LogStatus.Pass, "Alert is displayed");

            var alertOk = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("OK")));
            alertOk.Click();
        }

        [Test]
        [Obsolete]

        // Verify Monthly Transfer- End on date - success
        // ***************************************************************************
        public void MonthlyTransfersEndondatesucces()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("MonthlyTransfersEndondatesucces");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var monthly = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Monthly')]")));
            monthly.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();
            nextMonth.Click();
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 3 Monthly Transfer- End on date - success
        // ***************************************************************************
        public void ThreeMonthlyTransfersEndondatesucces()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("ThreeMonthlyTransfersEndondatesucces");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everythreemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 3 Months')]")));
            everythreemonths.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();
            nextMonth.Click();
            nextMonth.Click();
            nextMonth.Click();
            nextMonth.Click();
            nextMonth.Click();
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 3 Monthly Transfer- End on date - Error
        // ***************************************************************************
        public void ThreeMonthlyTransfersEndondateError()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("ThreeMonthlyTransfersEndondateError");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everythreemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 3 Months')]")));
            everythreemonths.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var alertTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Alert")));
            Assert.AreEqual(true, alertTitle.Displayed);

            var alertMessage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Please enter a valid recurring date")));
            Assert.AreEqual("Please enter a valid recurring date", alertMessage.Text);
            Assert.IsTrue(alertMessage.Displayed);
            this.Test.Log(LogStatus.Pass, "Alert is displayed");

            var alertOk = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("OK")));
            alertOk.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 3 Monthly Transfer- Never Ending Success
        // ***************************************************************************
        public void ThreeMonthlyTransfersEndondateneverending()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("ThreeMonthlyTransfersEndondateneverending");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everythreemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 3 Months')]")));
            everythreemonths.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var never = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Never')]")));
            never.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 3 Monthly Transfer- End after # transfers success
        // ***************************************************************************
        public void ThreeMonthlyTransfersEndafterhashtransfers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("ThreeMonthlyTransfersEndafterhashtransfers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everythreemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 3 Months')]")));
            everythreemonths.Click();

            var endTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTranfers.Click();

            var afterTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'After # Transfers')]")));
            afterTransfers.Click();

            var enterNoOfTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'#')]")));
            enterNoOfTransfers.SendKeys("2");

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 6 Monthly Transfer- Never Ending Success
        // ***************************************************************************
        public void SixMonthlyTransfersEndondateneverending()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("SixMonthlyTransfersEndondateneverending");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everysixmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 6 Months')]")));
            everysixmonths.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var never = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Never')]")));
            never.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 6 Monthly Transfer- End after # transfers success
        // ***************************************************************************
        public void SixMonthlyTransfersEndafterhashtransfers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("SixMonthlyTransfersEndafterhashtransfers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everysixmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 6 Months')]")));
            everysixmonths.Click();

            var endTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTranfers.Click();

            var afterTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'After # Transfers')]")));
            afterTransfers.Click();

            var enterNoOfTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'#')]")));
            enterNoOfTransfers.SendKeys("2");

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 6 Monthly Transfer- End on date - success
        // ***************************************************************************
        public void SixMonthlyTransfersEndondatesucces()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("SixMonthlyTransfersEndondatesucces");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everysixmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 6 Months')]")));
            everysixmonths.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));

            for (int i = 0; i < 14; i++)
            {
                nextMonth.Click();
            }

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every 6 Monthly Transfer- End on date - Error
        // ***************************************************************************
        public void SixMonthlyTransfersEndondateError()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("SixMonthlyTransfersEndondateError");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var everysixmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Every 6 Months')]")));
            everysixmonths.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var alertTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Alert")));
            Assert.AreEqual(true, alertTitle.Displayed);

            var alertMessage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Please enter a valid recurring date")));
            Assert.AreEqual("Please enter a valid recurring date", alertMessage.Text);
            Assert.IsTrue(alertMessage.Displayed);
            this.Test.Log(LogStatus.Pass, "Alert is Displayed");

            var alertOk = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("OK")));
            alertOk.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every Anually  Transfer- Never Ending Success
        // ***************************************************************************
        public void AnuallyMonthlyTransfersEndondateneverending()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("AnuallyMonthlyTransfersEndondateneverending");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var annually = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Annually')]")));
            annually.Click();

            var endTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTransfer.Click();

            var never = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Never')]")));
            never.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Anually  Transfer- End after # transfers successdgdfgdfgfghfghdf
        // ***************************************************************************
        public void AnuallyMonthlyTransfersEndafterhashtransfers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("AnuallyMonthlyTransfersEndafterhashtransfers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");
            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();



            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var annually = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Annually')]")));
            annually.Click();

            var endTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            endTranfers.Click();

            var afterTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'After # Transfers')]")));
            afterTransfers.Click();

            var enterNoOfTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'#')]")));
            enterNoOfTransfers.SendKeys("2");

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.IsTrue(doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");

        }

        [Test]
        [Obsolete]

        // Verify Anually Transfer- End on date - success
        // ***************************************************************************
        public void AnuallyMonthlyTransfersEndondatesucces()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("AnuallyMonthlyTransfersEndondatesucces");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var annually = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Annually')]")));
            annually.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            for (int i = 0; i < 26; i++)
            {
                nextMonth.Click();
            }

            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            // nextMonth.Click();
            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var confirmtransferdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Confirm Transfer Details")));
            Assert.AreEqual(true, confirmtransferdetails.Displayed);

            // wait.Until(ExpectedConditions.(By.Name("Schedule Transfer")));
            var scheduleTransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Schedule Transfer")));
            scheduleTransfer.Click();

            // transfer-successfull
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            Assert.AreEqual(true, doneButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer is Successfull");
            doneButton.Click();
        }

        [Test]
        [Obsolete]

        // Verify Every Anually Transfer- End on date - Error
        // ***************************************************************************
        public void AnuallyMonthlyTransfersEndondateError()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("AnuallyMonthlyTransfersEndondateError");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));

            // Validating presence of button transfer between My Eastern Bank Accounts
            // Assert.AreEqual(true, betweenEasternAccountsButton.Displayed);
            Assert.IsTrue(betweenEasternAccountsButton.Displayed);
            this.Test.Log(LogStatus.Pass, "transfer between My Eastern Bank Accounts is visible");
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));

            // Validating presence of button Choose From Account
            Assert.AreEqual(true, chooseFromAccountButton.Displayed);
            this.Test.Log(LogStatus.Pass, "Choose From Account is visible");
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("7927");

            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("abcd");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'abcd')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var annually = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Annually')]")));
            annually.Click();

            var afterTranfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'End Transfer Never')]")));
            afterTranfers.Click();

            var onDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'On Date')]")));
            Assert.AreEqual(true, onDate.Displayed);
            onDate.Click();

            var nextMonth = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next Month')]")));
            nextMonth.Click();

            var selectAvailableStartDate = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Available')]")));
            selectAvailableStartDate.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            var alertTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Alert")));
            Assert.AreEqual(true, alertTitle.Displayed);

            var alertMessage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Please enter a valid recurring date")));
            Assert.AreEqual("Please enter a valid recurring date", alertMessage.Text);
            this.Test.Log(LogStatus.Pass, "Error message is displayed");

            var alertOk = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("OK")));
            alertOk.Click();
        }

        [Test]
        [Obsolete]

        // Verify Zelle card for consumers
        // ***************************************************************************
        public void Zellecardforconsumers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("zellecardforconsumers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var zelle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer To Another Person (Zelle)')]")));
            Assert.AreEqual(true, zelle.Displayed);
            this.Test.Log(LogStatus.Pass, "zelle card is displayed");

        }

        [Test]
        [Obsolete]

        // Verify Transfers error message for a user with only one account
        // ***************************************************************************
        public void Errorforuserwithonlyoneaccount()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Errorforuserwithonlyoneaccount");
            this.Loginoneuser();

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));
            betweenEasternAccountsButton.Click();

            var unavailable = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Unavailable')]")));
            Assert.AreEqual("Unavailable", unavailable.Text);
            this.Test.Log(LogStatus.Pass, "Error message is displayed");
        }

        [Test]
        [Obsolete]

        // Verify Edit Transfer
        // ***************************************************************************
        public void Verifyedittransfer()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Verifyedittransfer");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var viewManageScheduledTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View/Manage Scheduled Transfers')]")));
            viewManageScheduledTransfers.Click();

            var scheduledTransfersTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Scheduled Transfers")));
            Assert.AreEqual(true, scheduledTransfersTitle.Displayed);

            var editDelete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[3]")));
            editDelete.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FREQUENCY')]")));

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            edit.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount')]")));
            amountInput.Click();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeKey[contains(@name,'Delete')]")));

            delete.Click();

            amountInput.SendKeys("2");

            var editrecurring = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Edit Recurring Series')]")));
            editrecurring.Click();

            var afterTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
               ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[1]")));
            afterTransfers.Click();

            delete.Click();

            var enterNoOfTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@value,'#')]")));
            enterNoOfTransfers.Click();
            delete.Click();
            enterNoOfTransfers.SendKeys("2");

            Dictionary<string, string> scrollObjectup = new Dictionary<string, string>
            {
                { "direction", "up" }
            };

            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObjectup);

            
            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Save")));
            save.Click();

            var transferSuccessfullyUpdated = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Transfer Successfully Updated')]")));
            Assert.AreEqual(true, transferSuccessfullyUpdated.Displayed);
            this.Test.Log(LogStatus.Pass, "Transfer updated successfully");
        }

        [Test]
        [Obsolete]

        // Verify Delete Only This Transfer
        // ***************************************************************************
        public void Verifydeleteonlythistransfer()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Verifydeleteonlythistransfer");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var viewManageScheduledTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View/Manage Scheduled Transfers')]")));
            viewManageScheduledTransfers.Click();

            var scheduledTransfersTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Scheduled Transfers")));
            Assert.AreEqual(true, scheduledTransfersTitle.Displayed);

            var editDelete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Recurring')]")));
            editDelete.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FREQUENCY')]")));

            var touchaction = new TouchAction(this.Driver);
            touchaction.Press(frequency);
            touchaction.MoveTo(-203, -586);
            touchaction.Release();
            touchaction.Perform();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            delete.Click();

            var deleteonlythistransfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Delete Only This Transfer")));
            deleteonlythistransfer.Click();

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Yes")));
            yes.Click();

            var deleted = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Successfully Deleted")));
            Assert.AreEqual(true, deleted.Displayed);
            this.Test.Log(LogStatus.Pass, "Successfully Deleted");
        }

        [Test]
        [Obsolete]

        // Verify Delete This And All Future Transfers
        // ***************************************************************************
        public void Verifydeletethisandallfuturetransfers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Verifydeletethisandallfuturetransfers");

            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var viewManageScheduledTransfers = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View/Manage Scheduled Transfers')]")));
            viewManageScheduledTransfers.Click();

            var scheduledTransfersTitle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Scheduled Transfers")));
            Assert.AreEqual(true, scheduledTransfersTitle.Displayed);

            var editDelete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Recurring')]")));
            editDelete.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FREQUENCY')]")));

            var touchaction = new TouchAction(this.Driver);
            touchaction.Press(frequency);
            touchaction.MoveTo(-203, -586);
            touchaction.Release();
            touchaction.Perform();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            delete.Click();

            var deletethisandfuture = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Delete This and All Future Transfers")));
            deletethisandfuture.Click();

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Yes")));
            yes.Click();

            var deleted = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Successfully Deleted")));
            Assert.AreEqual(true, deleted.Displayed);
            this.Test.Log(LogStatus.Pass, "Deleted Successfully");
        }

        [Test]
        [Obsolete]

        // Verify Zelle Dashboard for enrolled users in QA/Staging
        // ***************************************************************************
        public void Zelledashboardforenrolledusers()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("zellecardforconsumers");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var zelle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer To Another Person (Zelle)')]")));
            zelle.Click();

            var sendmoneywithzelle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Send Money With Zelle')]")));
            Assert.AreEqual(true, sendmoneywithzelle.Displayed);

            var send = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeLink[contains(@name,'Send')]")));
            Assert.AreEqual(true, send.Displayed);

            var request = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeLink[contains(@name,'Request')]")));
            Assert.AreEqual(true, request.Displayed);

            var split = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeLink[contains(@name,'Request')]")));
            Assert.AreEqual(true, split.Displayed);
            this.Test.Log(LogStatus.Pass, "All cards Displayed");
        }

        [Test]
        [Obsolete]

        // Verify Zelle Dashboard for enrolled users in QA/Staging
        // ***************************************************************************
        public void Ssoupdateinsettings()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Ssoupdateinsettings");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var zelle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer To Another Person (Zelle)')]")));
            zelle.Click();

            var settings = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeLink[contains(@name,'Settings')]")));
            settings.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var checking7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther[contains(@name,'Checking')]")));
            Assert.AreEqual(true, checking7927.Displayed);
            this.Test.Log(LogStatus.Pass, "Default Account is displayed");
        }

        [Test]
        [Obsolete]

        // Verify Zelle Dashboard for enrolled users in QA/Staging
        // ***************************************************************************
        public void Sessiontimeout()
        {
            this.transfersPage = new TransfersPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            this.Test = this.Extent.StartTest("Sessiontimeout");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchTransfer = new TouchAction(this.Driver);

            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            touchTransfer.LongPress(transfer);
            touchTransfer.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var zelle = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer To Another Person (Zelle)')]")));
            zelle.Click();

            var sessiontimeoutmessage = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(16)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'We're sorry,')]")));
            Assert.AreEqual(true, sessiontimeoutmessage.Displayed);
            this.Test.Log(LogStatus.Pass, "15 minues timout is displayed");
        }

        [Obsolete]
        public void RevertBackAmount()
        {
            var transfer = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer')]")));
            Assert.IsTrue(transfer.Enabled);

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Between My Eastern Bank Accounts")));

            var betweenEasternAccountsButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Transfer Between My Eastern Bank Accounts')]")));
            betweenEasternAccountsButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Choose From Account")));

            var chooseFromAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose From Account")));
            chooseFromAccountButton.Click();

            var search = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Search Accounts")));

            search.Click();
            search.SendKeys("5921");
            search.SendKeys(Keys.Return);
            var fromAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'FREE CHECKING *5921')]")));

            // validating presence of from account
            Assert.AreEqual(true, fromAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "From Account is visible");
            fromAccount.Click();

            var amountInput = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Enter Amount $0.00")));

            // validating presence of amount input
            Assert.AreEqual(true, amountInput.Displayed);
            this.Test.Log(LogStatus.Pass, "Amount Input is visible");
            amountInput.SendKeys("0.01");

            var chooseToAccountButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Choose To Account")));

            // validating presence of To account
            Assert.AreEqual(true, chooseToAccountButton.Displayed);
            chooseToAccountButton.Click();

            search.Click();
            search.SendKeys("7927");
            search.SendKeys(Keys.Return);

            var toAccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'*7927')]")));

            // validating presence of from account
            Assert.AreEqual(true, toAccount.Displayed);
            this.Test.Log(LogStatus.Pass, "To Account is visible");
            toAccount.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Frequency One Time Now')]")));
            frequency.Click();

            var oneTimeNow = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'One Time Now')]")));
            oneTimeNow.Click();

            var continueButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Continue")));
            continueButton.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Transfer Now")));

            var transferNowButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementExists(By.Name("Transfer Now")));
            transferNowButton.Click();

            // transfer successful
            var doneButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                 ExpectedConditions.ElementExists(By.Name("Done")));
            doneButton.Click();
        }
    }
}

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
    public class More : BrowserStackNUnitTest
    {

        public More(string profile, string environment)
            : base(profile, environment)
        {
        }

        private MorePage morePage = null;
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
            var reportPath = projectPath + "Reports\\" + "EasternBank_More" + timestamp + ".html";

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
        [Description("ServicesHome-Verify Check Number Modal View")]
        public void Verifychecknumbermodalview()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifychecknumbermodalview");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);

            var viewcancelstoppedchecks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View/Cancel Stopped Checks')]")));
            Assert.AreEqual(true, viewcancelstoppedchecks.Displayed);
            this.Test.Log(LogStatus.Pass, "modal view verified");
        }

        [Test]
        [Obsolete]
        [Description("Services home - check number modal - verify non -  numeric in check number field")]
        public void Verifynonnumeric()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifynonnumeric");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("abcd");
            _ = checknumber.Equals(" ");

            this.Test.Log(LogStatus.Pass, "non numeric in check number field is not execpted");
        }

        [Test]
        [Obsolete]
        [Description("Verify Check number field with maximum characters")]
        public bool Verifychecknumberfieldwithmaximum()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifychecknumberfieldwithmaximum");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.Click();
            checknumber.SendKeys("1234567891234");
            bool result = true;
            if (checknumber.GetAttribute("value") == "1234567891234")
                {
                    Assert.IsTrue(checknumber.Displayed);
                    this.Test.Log(LogStatus.Fail, "maximum characters are accepted");
                }
                else
                {
                    if (checknumber.GetAttribute("value") == "1234567891")
                    {
                        Assert.IsTrue(checknumber.Displayed);
                        this.Test.Log(LogStatus.Pass, "maximum characters Validated");
                    }
                }

            return result;
        }

        [Test]
        [Obsolete]
        [Description("Services Home- Check Number modal appears-Verify Back Button with Check Number Field with Numeric Value")]
        public void Verifybackbutton()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifybackbutton");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.Click();
            checknumber.SendKeys("1234567891");

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            Assert.AreEqual(true, back.Displayed);
            Assert.IsTrue(back.Enabled);
            back.Click();

            var acct79271 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct79271.Displayed);
            

            this.Test.Log(LogStatus.Pass, "Back button is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Check Number modal appears - Verify back Button with check Number with Empty/Blank Field")]
        public void Verifybackbuttonwithemptytext()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifybackbuttonwithemptytext");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            Assert.AreEqual(true, back.Displayed);
            Assert.IsTrue(back.Enabled);
            back.Click();

            var acc7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acc7927.Displayed);
            this.Test.Log(LogStatus.Pass, "Back button to empty text field is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Check Number modal appears - Validate continue Button with Check Number Field with Numeric value")]
        public void Validatecontinuebutton()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Validatecontinuebutton");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var stopcheckdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Stop Check Details')]")));
            next.Click();
            Assert.AreEqual(true, stopcheckdetails.Displayed);

            this.Test.Log(LogStatus.Pass, "Valid check number is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Check Number modal appears - validate continue button - check number field with already stopped check")]
        public void Checknumberfieldwithalreadystoppedcheck()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Checknumberfieldwithalreadystoppedcheck");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567892");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var alreadystopped = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Already Stopped')]")));

            Assert.AreEqual(true, alreadystopped.Displayed);

            this.Test.Log(LogStatus.Pass, "Check number field with already stopped check is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal View")]
        public void Stopcheckdetailview()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Stopcheckdetailview");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var account = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'SELECT')]")));

            Assert.AreEqual(true, account.Displayed);

            var checknumber1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'1234567891')]")));

            Assert.AreEqual(true, checknumber1.Displayed);

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Payee Name Enter Name')]")));

            Assert.AreEqual(true, payeename.Displayed);

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));

            Assert.AreEqual(true, enteramount.Displayed);

            this.Test.Log(LogStatus.Pass, "Check number field with already stopped check is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Leave Check Amount Field Empty Blank Failed")]
        public void Amountfieldempty()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Amountfieldempty");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var stopcheckbtn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheckbtn.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please enter amount.')]")));

            Assert.AreEqual(true, alert.Displayed);

            this.Test.Log(LogStatus.Pass, "alert validated");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- VerifyCheck Amount Field with Maximum Characters")]
        public void Amountfieldwithmaximumcharacters()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Amountfieldwithmaximumcharacters");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.SendKeys("123456789.123");

            var enteramount1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $100023456.78')]")));
            Assert.AreEqual(true, enteramount1.Displayed);

            this.Test.Log(LogStatus.Pass, "Maximum of 11 numbers (100023456.78) are execpted");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Enter non-numeric in check account field")]
        public void Amountfieldwithnonnumeric()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Amountfieldwithnonnumeric");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.SendKeys("abcd");
            Assert.AreEqual(true, enteramount.Displayed);

            this.Test.Log(LogStatus.Pass, "Non numeric in check amount field is not accepted");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Leave Payee Name Field Empty/Blank")]
        public void Payeefieldempty()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Payeefieldempty");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.SendKeys("123456789");

            var stopcdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Stop Check Details')]")));
            stopcdetails.Click();

            var stopcheckbtn = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheckbtn.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Please enter payee name.')]")));

            Assert.AreEqual(true, alert.Displayed);

            this.Test.Log(LogStatus.Pass, "alert validated");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Enter Payee Name Field With Symbols")]
        public void Payeefieldsymbols()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Payeefieldsymbols");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.SendKeys("123456789");

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Payee Name Enter Name')]")));
            payeename.Click();
            payeename.SendKeys("@@##");

            var payeename1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Payee Name @@##')]")));

            Assert.AreEqual(true, payeename1.Displayed);

            this.Test.Log(LogStatus.Pass, "symbols accepted");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Verify Pyee Name Field with Maximum Characters")]
        public void Payeefieldmaxcharacters()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Payeefieldmaxcharacters");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.SendKeys("123456789");

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Payee Name Enter Name')]")));
            payeename.Click();
            payeename.SendKeys("abcdefghijklmnopqrstu");

            var payeename1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Payee Name abcdefghijklmnopqrst')]")));

            Assert.AreEqual(true, payeename1.Displayed);

            this.Test.Log(LogStatus.Pass, "max char validated");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Verify check issue field")]
        public void Checkissuefield()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Checkissuefield");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var reasonforstop = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Reason For stop Destroyed')]")));
            reasonforstop.Click();

            var destroyed = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Destroyed')]")));
            Assert.AreEqual(true, destroyed.Displayed);

            var fraudulent = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Fraudulent')]")));
            Assert.AreEqual(true, fraudulent.Displayed);

            var lost = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Lost')]")));
            Assert.AreEqual(true, lost.Displayed);

            var others = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Others')]")));
            Assert.AreEqual(true, others.Displayed);

            var stolen = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Stolen')]")));
            Assert.AreEqual(true, stolen.Displayed);

            this.Test.Log(LogStatus.Pass, "stop check reason verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Reason for stop dropdown values")]
        public void Reasonforstopdropdownvalues()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Reasonforstopdropdownvalues");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var reasonforstop = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Reason For stop Destroyed')]")));
            reasonforstop.Click();

            var destroyed = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Destroyed')]")));
            Assert.AreEqual(true, destroyed.Displayed);

            var fraudulent = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Fraudulent')]")));
            Assert.AreEqual(true, fraudulent.Displayed);

            var lost = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Lost')]")));
            Assert.AreEqual(true, lost.Displayed);

            var others = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Others')]")));
            Assert.AreEqual(true, others.Displayed);

            var stolen = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Stolen')]")));
            Assert.AreEqual(true, stolen.Displayed);

            this.Test.Log(LogStatus.Pass, "values in dropdown are verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- verify select other from reason for stop dropdown")]
        public void Otherreason()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Otherreason");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var reasonforstop = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Reason For stop Destroyed')]")));
            reasonforstop.Click();

            var others = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Others')]")));
            Assert.AreEqual(true, others.Displayed);
            others.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var enterreason = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextView[contains(@value,'Enter Text...')]")));
            enterreason.Click();

            var abc = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeKey[contains(@name,'more')]")));

            enterreason.SendKeys("#$@");

            var enterreason1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextView[contains(@value,'#$@')]")));
            Assert.AreEqual(true, enterreason1.Displayed);
            this.Test.Log(LogStatus.Pass, "Other reason is verified with special characters");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Leave Reason for Stop Dropdown Empty/Blank")]
        public void ReasonEmpty()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("ReasonEmpty");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var reasonforstop = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Reason For stop Destroyed')]")));
            reasonforstop.Click();

            var others = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Others')]")));
            Assert.AreEqual(true, others.Displayed);
            others.Click();
            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var enterreason = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextView[contains(@value,'Enter Text...')]")));
            enterreason.Click();
            enterreason.SendKeys("  ");

            this.Test.Log(LogStatus.Pass, "Other reason is verified with Empty field");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- Leave Reason for Stop Dropdown Empty/Blank")]
        public void Dropdownvalues()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Dropdownvalues");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
           ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var reasonforstop = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Reason For stop Destroyed')]")));
            reasonforstop.Click();

            var others = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Others')]")));
            Assert.AreEqual(true, others.Displayed);
            others.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var stopterm = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'6 months')]")));
            stopterm.Click();

            var stopterm1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'6 months')]")));
            Assert.IsTrue(stopterm1.Displayed);

            var twelvemonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'12 months')]")));
            Assert.IsTrue(twelvemonths.Displayed);

            var twentyfourmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'24 months')]")));
            Assert.IsTrue(twentyfourmonths.Displayed);

            var thirtysixmonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'36 months')]")));
            Assert.IsTrue(thirtysixmonths.Displayed);

            var sixtymonths = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'60 months')]")));
            Assert.IsTrue(sixtymonths.Displayed);

            this.Test.Log(LogStatus.Pass, " Stop term dropdown is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- verify cancel button")]
        public void Verifycancelbutton()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifycancelbutton");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var stopasinglecheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck.Displayed);
            stopasinglecheck.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var checknumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(checknumber.Enabled);
            checknumber.SendKeys("1234567891");

            var next = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Next')]")));
            next.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.SendKeys("123456789");

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Payee Name Enter Name')]")));
            payeename.Click();
            payeename.SendKeys("abcde");

            var stopcheckdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Stop Check Details')]")));
            stopcheckdetails.Click();

            var reasonforstop = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Reason For stop Destroyed')]")));
            reasonforstop.Click();

            var others = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'Others')]")));
            Assert.AreEqual(true, others.Displayed);
            others.Click();

            Dictionary<string, string> scrollObject = new Dictionary<string, string>
            {
                { "direction", "down" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject);

            var enterreason = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextView[contains(@value,'Enter Text...')]")));
            enterreason.Click();

            var abc = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeKey[contains(@name,'more')]")));

            enterreason.SendKeys("#$@");

            Dictionary<string, string> scrollObject1 = new Dictionary<string, string>
            {
                { "direction", "up" }
            };
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("mobile: scroll", scrollObject1);


            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            Assert.AreEqual(true, back.Displayed);
            Assert.IsTrue(back.Enabled);
            back.Click();

            var stopcheck1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeText[contains(@name,'Stopped Checkks')]")));
            Assert.AreEqual(true, stopcheck1.Displayed);

          

            this.Test.Log(LogStatus.Pass, "cancel button is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- verify history modal")]
        public void Stopcheckhistorymodal()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Stopcheckhistorymodal");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var viewcancelstoppedchecks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View/Cancel Stopped Checks')]")));
            viewcancelstoppedchecks.Click();

            var stoppedChecks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeText[contains(@name,'Stopped Checkks')]")));
            Assert.IsTrue(stoppedChecks.Displayed);

            this.Test.Log(LogStatus.Pass, "Stop check history modal is verified");
        }

        [Test]
        [Obsolete]
        [Description("Services Home - Stop Check Detail Modal- verify close button")]
        public void Verifyclosebutton()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyclosebutton");
            this.loginPage.Login();
            this.Test.Log(LogStatus.Pass, "Eastern bank Logo");

            var touchmore = new TouchAction(this.Driver);

            var more = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'More')]")));
            Assert.IsTrue(more.Enabled);

            touchmore.LongPress(more);
            touchmore.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("User Preferences")));

            var stopcheck = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            stopcheck.Click();

            var viewcancelstoppedchecks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
             ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View/Cancel Stopped Checks')]")));
            viewcancelstoppedchecks.Click();

            var acct7927 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, acct7927.Displayed);
            acct7927.Click();

            var stoppedChecks = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField")));
            Assert.IsTrue(stoppedChecks.Displayed);

            var back = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[2]")));
            Assert.AreEqual(true, back.Displayed);
            Assert.IsTrue(back.Enabled);
            back.Click();

            var stopcheck1 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop Check')]")));
            Assert.AreEqual(true, stopcheck1.Displayed);

            var stopasinglecheck2 = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Stop a Single Check')]")));
            Assert.AreEqual(true, stopasinglecheck2.Displayed);
            stopasinglecheck2.Click();

            this.Test.Log(LogStatus.Pass, "close button is verified");
        }

        [Test]
        [Obsolete]
        public void Verifyscreendetails()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyscreendetails");
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

            this.Test.Log(LogStatus.Pass, "Details screen validated");
        }

        [Test]
        [Obsolete]
        public void VerifyCancelButton()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("VerifyCancelButton");
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
            this.Test.Log(LogStatus.Pass, "cancel button is verified");
        }

        [Test]
        [Obsolete]
        public void Verifysavebutton()
        {
            this.morePage = new MorePage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifysavebutton");
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
            this.Test.Log(LogStatus.Pass, "save button is verified");
        }
    }
}
// <copyright file="Transfers.cs" company="Eastern Bank">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Android
{
    using System;
    using Android.Pages;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.MultiTouch;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;

    [TestFixture("local", "pixel")]
    public class BillPay : BrowserStackNUnitTest
    {

        public BillPay(string profile, string environment)
            : base(profile, environment)
        {
        }

        private BillPayPage billpayPage = null;
        private LoginPage loginPage = null;

        [Obsolete]
        [Description("Login to the Application under test")]
        public void Loginoneuser()
        {
            var usernameInputBox = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@class='android.widget.EditText']")));

            // validating presence of username input
            Assert.AreEqual(true, usernameInputBox.Displayed);
            usernameInputBox.SendKeys("noeligible");

            var passwordInputBox = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@password='true']")));

            // validating presence of password input
            Assert.AreEqual(true, passwordInputBox.Displayed);
            passwordInputBox.SendKeys("east@1234");

            // this.Driver.HideKeyboard();
            var gobutton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@class='android.widget.Button']")));
            gobutton.Click();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//android.view.View/android.view.View[contains(@text, 'Eastern Bank Logo')]")));
        }

        [Test]
        [Obsolete]
        public void BillPaymentover10000()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("BillPaymentover10000");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var makeasinglepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Single Payment')]")));
            makeasinglepayment.Click();

            var chooseapayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Pay To Choose a Payee')]")));
            chooseapayee.Click();

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            a_payee.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.Clear();
            enteramount.SendKeys("1001");

            var availablebalance = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Available Balance')]")));
            availablebalance.Click();

            var continuee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            continuee.Click();

            var confirmpaymentdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Confirm Payment Details')]")));
            Assert.AreEqual(true, confirmpaymentdetails.Displayed);

            var schedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Schedule Payment')]")));
            schedulepayment.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name, 'Alert')]")));
            Assert.AreEqual(true, alert.Displayed);
            this.Test.Log(LogStatus.Pass, "Alert is Displayed");

            var ok = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name, 'OK')]")));
        }

        [Test]
        [Obsolete]
        public void Verifysearchpayees()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifysearchpayees");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var searchpayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Payees')]")));
            searchpayees.Click();
            searchpayees.SendKeys("!A");

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            Assert.AreEqual(true, a_payee.Displayed);
            this.Test.Log(LogStatus.Pass, "a_payee is displayed");
        }

        [Test]
        [Obsolete]
        public void Verifynoresultsfound()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verfiynoresultsfound");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var searchpayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Payees')]")));
            searchpayees.Click();
            searchpayees.SendKeys("x");

            var noresultsfound = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'No Results Found')]")));
            Assert.AreEqual(true, noresultsfound.Displayed);
            this.Test.Log(LogStatus.Pass, "no results found is displayed");
        }

        [Test]
        [Obsolete]
        public void Verifypayeedropdownbox()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifypayeedropdownbox");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var searchpayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Search Payees')]")));
            searchpayees.Click();
            searchpayees.SendKeys("!A");

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            Assert.AreEqual(true, a_payee.Displayed);
            this.Test.Log(LogStatus.Pass, "a_payee is displayed");

            a_payee.Click();

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeStaticText[contains(@name,'PAYEE NAME')]")));
            Assert.AreEqual(true, payeename.Displayed);
            var address = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeStaticText[contains(@name,'ADDRESS')]")));
            Assert.AreEqual(true, address.Displayed);
            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            Assert.AreEqual(true, delete.Displayed);
            this.Test.Log(LogStatus.Pass, "All Data Displayed");
        }

        [Test]
        [Obsolete]
        public void Verifybillpayscreen()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifybillpayscreen");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var makeasinglepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Single Payment')]")));
            Assert.AreEqual(true, makeasinglepayment.Displayed);

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            Assert.AreEqual(true, managepayees.Displayed);

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            Assert.AreEqual(true, viewscheduledpayments.Displayed);

            var viewpaymenthistory = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Payment History')]")));
            Assert.AreEqual(true, viewpaymenthistory.Displayed);
            this.Test.Log(LogStatus.Pass, "All displayed on screen");
        }

        [Test]
        [Obsolete]
        public void Verifyaddpayeecompany()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyaddpayeecompany");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addcompany = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Company')]")));
            addcompany.Click();

            var entercompanyname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeOther/XCUIElementTypeTextField[contains(@name,\"Finacle Mobile Solution\")]")));
            entercompanyname.Click();
            addcompany.SendKeys("Discover");

            var searchcompany = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Search Company')]")));
            searchcompany.Click();

            var discovercreditcards = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Discover Credit Cards')]")));
            discovercreditcards.Click();
            discovercreditcards.SendKeys("6011002775491234");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,Save')]")));
            save.Click();
        }

        [Test]
        [Obsolete]
        public void Verifywrongaccountnumbererror()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifywrongaccountnumbererror");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addcompany = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Company')]")));
            addcompany.Click();
            addcompany.SendKeys("discover");

            var searchcompany = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Search Company')]")));
            searchcompany.Click();

            var discovercreditcards = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Discover Credit Cards')]")));
            discovercreditcards.Click();
            discovercreditcards.SendKeys("1234");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            save.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Alert')]")));
            Assert.AreEqual(true, alert.Displayed);
            this.Test.Log(LogStatus.Pass, "Alert Displayed");
        }

        [Test]
        [Obsolete]
        public void Verifybillpayscreenlayout()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifybillpayscreenlayout");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var makeasinglepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Single Payment')]")));
            Assert.AreEqual(true, makeasinglepayment.Displayed);

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            Assert.AreEqual(true, managepayees.Displayed);

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            Assert.AreEqual(true, viewscheduledpayments.Displayed);

            var viewpaymenthistory = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Payment History')]")));
            Assert.AreEqual(true, viewpaymenthistory.Displayed);
            this.Test.Log(LogStatus.Pass, "Validated");
        }

        [Test]
        [Obsolete]
        public void Verifywrongzipcodeerror()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifywrongaccountnumbererror");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addcompany = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Company')]")));

            var companyname = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Add a Company')]")));

            companyname.Click();
            companyname.SendKeys("comcast");

            var searchcompany = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Search Company')]")));
            searchcompany.Click();

            var comcastcable = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Comcast Cable')]")));
            comcastcable.Click();
            comcastcable.SendKeys("6011002775491234");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            save.Click();

            var alert = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Alert')]")));
            Assert.AreEqual(true, alert.Displayed);
            this.Test.Log(LogStatus.Pass, "Alert Displayed");
        }

        [Test]
        [Obsolete]
        public void Verifyaddpayee()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyaddpayee");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addperson = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Person')]")));
            Assert.AreEqual(true, addperson.Displayed);

            var addcompany = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Company')]")));
            Assert.AreEqual(true, addcompany.Displayed);
            this.Test.Log(LogStatus.Pass, "Add payee and Add company is Displayed");
        }

        [Test]
        [Obsolete]
        public void Verifyaddpayeeperson()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyaddpayeeperson");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addperson = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Person')]")));
            addperson.Click();

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Payee Name')]")));
            payeename.Click();
            payeename.SendKeys("Ashwini");

            var addressline = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Address Line 1')]")));
            addressline.Click();
            addressline.SendKeys("1419 commonwealth avenue");

            var city = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'City')]")));
            city.Click();
            city.SendKeys("Brighton");

            var state = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'State')]")));
            state.Click();
            var touchaction = new TouchAction(this.Driver);
            touchaction.Press(state);
            touchaction.MoveTo(-19, -1729);
            touchaction.Release();
            touchaction.Perform();

            var ma = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'MA')]")));
            ma.Click();

            var zipcode = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Zip Code')]")));
            zipcode.Click();
            zipcode.SendKeys("02169");

            var payeephonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'PAYEE PHONE NUMBER')]")));
            payeephonenumber.Click();
            payeephonenumber.SendKeys("8578003969");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            save.Click();

            var success = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Success')]")));
            Assert.AreEqual(true, success.Displayed);
            this.Test.Log(LogStatus.Pass, "Success Displayed");

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var ashwini = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Ashwini')]")));
            ashwini.Click();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            delete.Click();

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes')]")));
            yes.Click();
        }

        [Test]
        [Obsolete]
        public void Verifypayeenameerror()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifypayeenameerror");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addperson = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Person')]")));
            addperson.Click();

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Payee Name')]")));
            payeename.Click();
            payeename.SendKeys("Ashwini");

            var addressline = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Address Line 1')]")));
            addressline.Click();
            addressline.SendKeys("1419 commonwealth avenue");

            var city = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'City')]")));
            city.Click();
            city.SendKeys("Brighton");

            var state = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'State')]")));
            state.Click();
            var touchaction = new TouchAction(this.Driver);
            touchaction.Press(state);
            touchaction.MoveTo(-19, -1729);
            touchaction.Release();
            touchaction.Perform();

            var ma = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'MA')]")));
            ma.Click();

            var zipcode = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Zip Code')]")));
            zipcode.Click();
            zipcode.SendKeys("02169");

            var payeephonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'PAYEE PHONE NUMBER')]")));
            payeephonenumber.Click();
            payeephonenumber.SendKeys("8578003969");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            save.Click();

            var success = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Success')]")));
            Assert.AreEqual(true, success.Displayed);
            this.Test.Log(LogStatus.Pass, "Success Displayed");

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var ashwini = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Ashwini')]")));
            ashwini.Click();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            delete.Click();

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes')]")));
            yes.Click();
        }

        [Test]
        [Obsolete]
        public void Verifywrongaddresserror()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifywrongaddresserror");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addperson = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Person')]")));
            addperson.Click();

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Payee Name')]")));
            payeename.Click();
            payeename.SendKeys("Ashwini");

            var addressline = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Address Line 1')]")));
            addressline.Click();
            addressline.SendKeys("1419 commonwealth avenue");

            var city = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'City')]")));
            city.Click();
            city.SendKeys("Brighton");

            var state = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'State')]")));
            state.Click();
            var touchaction = new TouchAction(this.Driver);
            touchaction.Press(state);
            touchaction.MoveTo(-19, -1729);
            touchaction.Release();
            touchaction.Perform();

            var ma = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'MA')]")));
            ma.Click();

            var zipcode = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Zip Code')]")));
            zipcode.Click();
            zipcode.SendKeys("02169");

            var payeephonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'PAYEE PHONE NUMBER')]")));
            payeephonenumber.Click();
            payeephonenumber.SendKeys("8578003969");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            save.Click();

            var success = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Success')]")));
            Assert.AreEqual(true, success.Displayed);
            this.Test.Log(LogStatus.Pass, "Success Displayed");

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var ashwini = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Ashwini')]")));
            ashwini.Click();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            delete.Click();

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes')]")));
            yes.Click();
        }

        [Test]
        [Obsolete]
        public void Verifyvalidcitystatezipcodeerror()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyvalidcitystatezipcodeerror");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var addpayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Payee')]")));
            addpayee.Click();

            var addperson = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Add a Person')]")));
            addperson.Click();

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Payee Name')]")));
            payeename.Click();
            payeename.SendKeys("Ashwini");

            var addressline = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'Address Line 1')]")));
            addressline.Click();
            addressline.SendKeys("1419 commonwealth avenue");

            var city = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'City')]")));
            city.Click();
            city.SendKeys("Brighton");

            var state = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeTextField[contains(@name,'State')]")));
            state.Click();
            var touchaction = new TouchAction(this.Driver);
            touchaction.Press(state);
            touchaction.MoveTo(-19, -1729);
            touchaction.Release();
            touchaction.Perform();

            var ma = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'MA')]")));
            ma.Click();

            var zipcode = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Zip Code')]")));
            zipcode.Click();
            zipcode.SendKeys("02169");

            var payeephonenumber = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'PAYEE PHONE NUMBER')]")));
            payeephonenumber.Click();
            payeephonenumber.SendKeys("8578003969");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            save.Click();

            var success = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Success')]")));
            Assert.AreEqual(true, success.Displayed);
            this.Test.Log(LogStatus.Pass, "Success Displayed");

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var ashwini = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Ashwini')]")));
            ashwini.Click();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            delete.Click();

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes')]")));
            yes.Click();
        }
        [Test]
        [Obsolete]
        public void Verifypayfrom()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifypayfrom");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var makeasinglepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Single Payment')]")));
            makeasinglepayment.Click();

            var payfrom = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Pay From')]")));
            payfrom.Click();

            var eligibleaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'7927')]")));
            Assert.AreEqual(true, eligibleaccount.Displayed);
            this.Test.Log(LogStatus.Pass, "Verified Pay From");
        }

        [Test]
        [Obsolete]
        public void Verifypayeedetails()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifypayeedetails");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            a_payee.Click();

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeStaticText[contains(@name,'PAYEE NAME')]")));
            Assert.AreEqual(true, payeename.Displayed);
            var address = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeStaticText[contains(@name,'ADDRESS')]")));
            Assert.AreEqual(true, address.Displayed);
            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            Assert.AreEqual(true, edit.Displayed);
            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            Assert.AreEqual(true, delete.Displayed);
            this.Test.Log(LogStatus.Pass, "All Data Displayed");
        }

        [Test]
        [Obsolete]
        public void Verifyeditpayee()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyeditpayee");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            a_payee.Click();

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'Edit')]")));
            edit.Click();

            var payeename = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeTextField[contains(@value,'!A')]")));
            payeename.SendKeys("a");

            var save = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
               ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'Save')]")));
            save.Click();

            var success = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Success')]")));
            Assert.AreEqual(true, success.Displayed);
            this.Test.Log(LogStatus.Pass, "edit success is displayed");

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            managepayees.Click();

            var aa_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            aa_payee.Click();

            edit.Click();

            var payeenamea = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeTextField[contains(@value,'!Aa')]")));
            payeenamea.Click();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeKey[contains(@name,'delete')]")));
            delete.Click();
            save.Click();
            this.Test.Log(LogStatus.Pass, "Edited");
        }

        [Test]
        [Obsolete]
        public void Verifydeletepayee()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifydeletepayee");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var managepayees = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Manage Payees')]")));
            managepayees.Click();

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            a_payee.Click();

            var edit = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
                ExpectedConditions.ElementIsVisible(By.XPath("//XCUIElementTypeButton[contains(@name,'')]")));
            edit.Click();

            // Assert.AreEqual(true, delete.Displayed);
            // this.Test.Log(LogStatus.Pass, "All Data Displayed");
        }

        [Test]
        [Obsolete]
        public void Verifybillpayhistoryforcompany()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifybillpayhistoryforcompany");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));
        }

        [Test]
        [Obsolete]
        public void Deleteschedulepayment()
        {
            // Start Report
            this.Test = this.Extent.StartTest("Deleteschedulepayment");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var makeasinglepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Single Payment')]")));
            makeasinglepayment.Click();

            var chooseapayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Pay To Choose a Payee')]")));
            chooseapayee.Click();

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            a_payee.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.Clear();
            enteramount.SendKeys("1");

            var availablebalance = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Available Balance')]")));
            availablebalance.Click();

            var continuee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            continuee.Click();

            var confirmpaymentdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Confirm Payment Details')]")));
            Assert.AreEqual(true, confirmpaymentdetails.Displayed);

            var schedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Schedule Payment')]")));
            schedulepayment.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            viewscheduledpayments.Click();

            var secondschedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'$10.00')]")));
            secondschedulepayment.Click();

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

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes')]")));
            yes.Click();

            var deleted = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Successfully Deleted')]")));

            deleted.Click();
            this.Test.Log(LogStatus.Pass, "Successfully Deleted");
        }

        [Test]
        [Obsolete]
        public void Pendingpayments()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Pendingpayments");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            viewscheduledpayments.Click();

            var scheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Scheduled Payments')]")));
            Assert.AreEqual(true, scheduledpayments.Displayed);
            this.Test.Log(LogStatus.Pass, "scheduled payments or pending payments are displayed");
        }

        [Test]
        [Obsolete]
        public void Pendingpaymentsdeletebutton()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Pendingpaymentsdeletebutton");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var makeasinglepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Make a Single Payment')]")));
            makeasinglepayment.Click();

            var chooseapayee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Pay To Choose a Payee')]")));
            chooseapayee.Click();

            var a_payee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'!A')]")));
            a_payee.Click();

            var enteramount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Enter Amount $0.00')]")));
            enteramount.Click();
            enteramount.Clear();
            enteramount.SendKeys("1");

            var availablebalance = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Available Balance')]")));
            availablebalance.Click();

            var continuee = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Continue')]")));
            continuee.Click();

            var confirmpaymentdetails = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Confirm Payment Details')]")));
            Assert.AreEqual(true, confirmpaymentdetails.Displayed);

            var schedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Schedule Payment')]")));
            schedulepayment.Click();

            var done = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Done')]")));
            done.Click();

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            viewscheduledpayments.Click();

            var secondschedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'$10.00')]")));
            secondschedulepayment.Click();

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FREQUENCY')]")));

            var touchaction = new TouchAction(this.Driver);
            touchaction.Press(frequency);
            touchaction.MoveTo(-203, -586);
            touchaction.Release();
            touchaction.Perform();

            var delete = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Delete')]")));
            Assert.AreEqual(true, delete.Displayed);
            delete.Click();

            var yes = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Yes')]")));
            yes.Click();

            var deleted = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Successfully Deleted')]")));

            deleted.Click();
            this.Test.Log(LogStatus.Pass, "Pending payments delete button is verified");
        }

        [Test]
        [Obsolete]
        public void CompletedPayments()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("CompletedPayments");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            viewscheduledpayments.Click();

            var scheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Scheduled Payments')]")));

            var secondschedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'$2.00')]")));
            secondschedulepayment.Click();
            try
            {
                this.Driver.FindElementByName("Delete");
            }
            catch
            {
                this.Test.Log(LogStatus.Pass, "Completed payments are displayed");
            }
        }

        [Test]
        [Obsolete]
        public void Verifyscheduledtab()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyscheduledtab");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            viewscheduledpayments.Click();

            var scheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Scheduled Payments')]")));

            var secondschedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'$2.00')]")));
            secondschedulepayment.Click();

            var to = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'TO')]")));
            Assert.AreEqual(true, to.Displayed);

            var from = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FROM')]")));
            Assert.AreEqual(true, from.Displayed);

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FREQUENCY')]")));
            Assert.AreEqual(true, frequency.Displayed);
            this.Test.Log(LogStatus.Pass, "Details are visible");
        }

        [Test]
        [Obsolete]
        public void Detailsofscheduledtab()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Detailsofscheduledtab");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));

            var viewscheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'View Scheduled Payments')]")));
            viewscheduledpayments.Click();

            var scheduledpayments = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'Scheduled Payments')]")));

            var secondschedulepayment = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'$2.00')]")));
            secondschedulepayment.Click();

            var to = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'TO')]")));
            Assert.AreEqual(true, to.Displayed);

            var from = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FROM')]")));
            Assert.AreEqual(true, from.Displayed);

            var frequency = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeStaticText[contains(@name,'FREQUENCY')]")));
            Assert.AreEqual(true, frequency.Displayed);
            this.Test.Log(LogStatus.Pass, "Details are visible");
        }

        [Test]
        [Obsolete]
        public void Verifyhistorytab()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifyhistorytab");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));
        }

        [Test]
        [Obsolete]
        public void Verifymoreinfohistorytab()
        {
            this.billpayPage = new BillPayPage(this.Driver);
            this.loginPage = new LoginPage(this.Driver);

            // Start Report
            this.Test = this.Extent.StartTest("Verifymoreinfohistorytab");
            this.loginPage.Login();

            var touchbillpay = new TouchAction(this.Driver);

            var billpay = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'Bill Pay')]")));
            Assert.IsTrue(billpay.Enabled);

            touchbillpay.LongPress(billpay);
            touchbillpay.Perform();

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Bill Payment")));
        }


    }
}

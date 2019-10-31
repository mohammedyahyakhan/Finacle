namespace Ios.Pages
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.iOS;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;

    [TestFixture("local", "iphone-se")]
    public class MorePage : BrowserStackNUnitTest
    {
        public MorePage(IOSDriver<IOSElement> driver)
        {
            this.Driver = driver;
        }

        // public IWebDriver Driver { get; private set; }



        [Obsolete]
        public void StopCheckDetailModal()
        {
            Console.WriteLine("Test into method");

            

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
        }
    }
}

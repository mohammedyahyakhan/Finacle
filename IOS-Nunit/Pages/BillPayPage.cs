namespace Ios.Pages
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.iOS;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;

    [TestFixture("local", "iphone-se")]
    public class BillPayPage : BrowserStackNUnitTest
    {
        public BillPayPage(IOSDriver<IOSElement> driver)
        {
            this.Driver = driver;
        }

        // public IWebDriver Driver { get; private set; }



        [Obsolete]
        public void VerifyCheckingAccount()
        {
            Console.WriteLine("Test into method");
            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//XCUIElementTypeButton[contains(@name,'CHECKING ACCT')]")));
            Assert.AreEqual(true, checkingaccount.Displayed);
        }
    }
}

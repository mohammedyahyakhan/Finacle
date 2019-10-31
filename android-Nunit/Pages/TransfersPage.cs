namespace Android.Pages
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Android;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;

    [TestFixture("local", "pixel")]
    public class TransferPage : BrowserStackNUnitTest
    {
        public TransferPage(AndroidDriver<AndroidElement> driver)
        {
            this.Driver = driver;
        }

        // public IWebDriver Driver { get; private set; }

        // BrowserStackNUnitTest browserstack = new BrowserStackNUnitTest();
        [Obsolete]
        public void VerifyCheckingAccount()
        {
            Console.WriteLine("Test into method");
            var checkingaccount = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            ExpectedConditions.ElementExists(By.XPath("//android.widget.Button[contains(@text,'CHECKING ACCT')]")));
            Assert.AreEqual(true, checkingaccount.Displayed);
        }
    }
}

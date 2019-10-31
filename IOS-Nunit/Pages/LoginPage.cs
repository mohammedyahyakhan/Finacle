namespace Ios.Pages
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.iOS;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;

    [TestFixture("local", "iphone-se")]
    public class LoginPage : BrowserStackNUnitTest
    {
        public LoginPage(IOSDriver<IOSElement> driver)
        {
            this.Driver = driver;
        }



        [Description("Login to the Application under test")]
        [Obsolete]
        public void Login()
        {
            var usernameInputBox = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("XCUIElementTypeTextField")));

            // validating presence of username input
            Assert.AreEqual(true, usernameInputBox.Displayed);
            usernameInputBox.SendKeys("qacon1");

            var passwordInputBox = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("XCUIElementTypeSecureTextField")));

            // validating presence of password input
            Assert.AreEqual(true, passwordInputBox.Displayed);
            passwordInputBox.SendKeys("east@1234");

            // this.Driver.HideKeyboard();
            var gobutton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name("Go")));
            gobutton.Click();

            // var signInButton = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            // SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name("Sign In")));
            // signInButton.Click();
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1));

            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name("Eastern Bank Logo")));
            
        }
    }
}

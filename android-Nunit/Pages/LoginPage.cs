namespace Android.Pages
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Android;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;

    [TestFixture("local", "pixel")]
    public class LoginPage : BrowserStackNUnitTest
    {
        public LoginPage(AndroidDriver<AndroidElement> driver)
        {
            this.Driver = driver;
        }

        [Description("Login to the Application under test")]
        [Obsolete]
        public void Login()
        {
            var usernameInputBox = (RemoteWebElement)new WebDriverWait(this.Driver, TimeSpan.FromMinutes(1)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@class='android.widget.EditText']")));

            // validating presence of username input
            Assert.AreEqual(true, usernameInputBox.Displayed);
            usernameInputBox.SendKeys("qacon1");

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
    }
}

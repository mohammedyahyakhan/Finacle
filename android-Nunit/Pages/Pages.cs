using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android.Pages
{
    [TestFixture("local", "pixel")]
    public class Pages : BrowserStackNUnitTest
    {
        public Pages(string profile, string environment)
            : base(profile, environment)
        {
        }



        // public static IWebDriver _driver;
        [Obsolete]
        private static T GetPage<T>()
            where T : new()
        {
            var page = new T();
            // IWebDriver driver = BrowserStackNUnitTest.;
            // driver = this.

            // PageFactory.InitElements(BrowserStackNUnitTest., page);
            return page;
        }

        //public static AccountsPage Accountspage
        //{
        //    get { return GetPage<AccountsPage>(); }
        //}

        // public static BrowserStackNUnitTest Browserstack
        // {
        //    get { return GetPage<BrowserStackNUnitTest>(); }
        // }
    }
}

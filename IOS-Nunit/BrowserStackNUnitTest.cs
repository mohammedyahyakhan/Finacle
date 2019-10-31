﻿// <copyright file="BrowserStackNUnitTest.cs" company="Eastern Bank">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Ios
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using BrowserStack;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Appium.iOS;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Support.UI;
    using RelevantCodes.ExtentReports;

    public class BrowserStackNUnitTest
    {
        public IOSDriver<IOSElement> Driver;

        private readonly string profile;

        private readonly string device;
        private Local browserStackLocal;

        public BrowserStackNUnitTest(string profile, string device)
        {
            this.profile = profile;
            this.device = device;
        }

        public BrowserStackNUnitTest()
        {
        }

        [SetUp]
        [Obsolete]
        public void Init()
        {
            var capability = new DesiredCapabilities();

            if (ConfigurationManager.GetSection("capabilities/" + this.profile) is NameValueCollection caps)
            {
                foreach (var key in caps.AllKeys)
                {
                    capability.SetCapability(key, caps[key]);
                }
            }

            if (ConfigurationManager.GetSection("environments/" + this.device) is NameValueCollection devices)
            {
                foreach (var key in devices.AllKeys)
                {
                    capability.SetCapability(key, devices[key]);
                }
            }

            var username = Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME") ?? ConfigurationManager.AppSettings.Get("user");

            var accesskey = Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY") ?? ConfigurationManager.AppSettings.Get("key");

            capability.SetCapability("browserstack.user", username);
            capability.SetCapability("browserstack.key", accesskey);

            var appId = Environment.GetEnvironmentVariable("BROWSERSTACK_APP_ID");
            if (appId != null)
            {
                capability.SetCapability("app", appId);
            }

            var browserstackLocalArgs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("key", accesskey)
            };
            if ((capability.GetCapability("browserstack.local") != null) && (capability.GetCapability("browserstack.local").ToString() == "true"))
            {
                this.browserStackLocal = new Local();
                this.browserStackLocal.start(browserstackLocalArgs);
            }

            this.Driver = new IOSDriver<IOSElement>(new Uri("http://" + ConfigurationManager.AppSettings.Get("server") + "/wd/hub/"), capability);
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));

            try
            {
                wait.Until(ExpectedConditions.AlertIsPresent());
                this.Driver.SwitchTo().Alert().Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        [TearDown]
        public void Cleanup()
        {
            this.Driver.Quit();
            this.browserStackLocal?.stop();
        }

    }
}
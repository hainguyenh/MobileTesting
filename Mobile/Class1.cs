using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System;

namespace Mobile
{
    public class Class1
    {
        [Test]
        public void Connect()
        {
            AppiumOptions dc = new AppiumOptions();
            dc.AddAdditionalCapability("platformName", "Android");
            dc.AddAdditionalCapability("platformVersion", "9");
            dc.AddAdditionalCapability("deviceName", "device");
            dc.AddAdditionalCapability("noReset", "true");
            dc.AddAdditionalCapability("appPackage", "io.appium.android.apis");
            dc.AddAdditionalCapability("appActivity", "io.appium.android.apis.ApiDemos");

            IWebDriver driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), dc);

        }
    }
}

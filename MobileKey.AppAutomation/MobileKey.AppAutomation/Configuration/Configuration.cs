using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace MobileKey.Axeos.AppAutomation
{
    internal class ConfigurationClass : AppType
    {
        public static IWebDriver driver;
        //public string App = ConfigurationManager.;

        internal  ConfigurationClass()
        {
        }
        public void BrowserApp()
        {

            driver = new ChromeDriver();


        }

        public void Android()
        {

        }

        public void IOS()
        {

        }
        public void LaunchAndroidApp()
        {
            //var appium = new AppiumOptions();
            //driver = new AndroidDriver<AppiumWebElement>(new Uri(""),appium);
        }

        public void LanuchIOSApp()
        {
            //driver = new IOSDriver<IOSElement>();
        }
    }
}

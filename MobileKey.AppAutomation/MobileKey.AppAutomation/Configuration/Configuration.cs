using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace MobileKey.Axeos.AppAutomation
{
    internal class ConfigurationClass : AppType
    {
        string browser = "browserAppSettings";
        string mobile = "mobileAppSettings";
        string app = "apptype";
        string[] keys = null;
        internal AppTypeData application;
        public IWebDriver driver;
        internal string browserURL = null;
        internal bool isBrowser=false, isAndroid=false, isIOS=false;
        //public string App = ConfigurationManager.;

        internal  ConfigurationClass()
        {
    
            keys = valueCollection("apptype");
            foreach (var i in keys)
            {
                if (i.Equals("Browser", StringComparison.OrdinalIgnoreCase))
                {
                    application = AppTypeData.Browser;
                    isBrowser = true;
                    keys = valueCollection("browserAppSettings");
                    foreach (var a in keys)
                    {
                        if (a.Equals("Chrome", StringComparison.OrdinalIgnoreCase)
                            || a.Equals("Firefox", StringComparison.OrdinalIgnoreCase)
                            || a.Equals("IE", StringComparison.OrdinalIgnoreCase))
                        {
                            driver = BrowserApp(a);
                        }
                    }
                }
                else if(i.Equals("Mobile", StringComparison.OrdinalIgnoreCase))
                {
                    keys = valueCollection("mobileAppSettings");
                    foreach (var a in keys)
                    {
                        if (a.Equals("Android", StringComparison.OrdinalIgnoreCase))
                        {
                            application = AppTypeData.Android;
                            isAndroid = true;
                        }
                        else if (a.Equals("IOS", StringComparison.OrdinalIgnoreCase))
                        {
                            application = AppTypeData.IOS;
                            isIOS = true;
                        }

                    }
                }
            }

        }


        public string[] valueCollection(string val)
        {
            NameValueCollection collection=(NameValueCollection)ConfigurationManager.GetSection(val);
            return collection.AllKeys;
        }
        public IWebDriver BrowserApp(string value)
        {
            if (value.Contains("Chrome"))
            {
                driver = new ChromeDriver();
            }else if (value.Contains("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new InternetExplorerDriver();
            }

            return driver;
        }

        public void MobileApp(string value)
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

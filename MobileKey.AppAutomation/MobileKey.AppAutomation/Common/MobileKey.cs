using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace MobileKey.Axeos.AppAutomation
{
    enum AppTypeData
    {
        Browser,
        Android,
        IOS
    }
    internal class MobileKey
    {

        internal MobileKey()
        {

            new ConfigurationClass();
            
        }
    }
}

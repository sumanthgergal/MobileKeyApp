using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileKey.Axeos.AppAutomation
{
     interface AppType
    {
        IWebDriver BrowserApp(string value);
        void MobileApp(string value);

    }
}

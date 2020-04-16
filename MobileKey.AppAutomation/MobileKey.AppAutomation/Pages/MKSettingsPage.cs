using MobileKey.Axeos.AppAutomation.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileKey.Axeos.AppAutomation.Pages
{
    internal class MKSettingsPage : MKSettingsElements
    {
        IWebDriver iwebdriver;

        internal MKSettingsPage(ConfigurationClass configuration) : base(configuration)
        {
            this.iwebdriver = configuration.driver;

        }

    }
}

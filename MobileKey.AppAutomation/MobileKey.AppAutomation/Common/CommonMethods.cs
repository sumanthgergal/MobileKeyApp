using MobileKey.AppAutomation.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileKey.Axeos.AppAutomation
{
    internal class CommonMethods : MKCommonPageElements
    {
        IWebDriver driver;
        internal CommonMethods(ConfigurationClass configuration) : base(configuration)
        {
            this.driver = configuration.driver;
        }


    }
}

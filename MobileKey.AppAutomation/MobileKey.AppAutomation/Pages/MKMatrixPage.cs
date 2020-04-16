using MobileKey.Axeos.AppAutomation.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileKey.Axeos.AppAutomation.Pages
{
    internal class MKMatrixPage : MKMatrixElements
    {
        IWebDriver iwebdriver;

        internal MKMatrixPage(ConfigurationClass configuration) : base(configuration)
        {
            this.iwebdriver = configuration.driver;
        }





    }
}

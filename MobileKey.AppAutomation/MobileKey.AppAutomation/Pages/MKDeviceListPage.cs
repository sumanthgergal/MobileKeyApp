using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileKey.Axeos.AppAutomation
{
    internal class MKDeviceListPage : MKDeviceListELements
    {
        IWebDriver driver;

        internal MKDeviceListPage(ConfigurationClass configuration): base(configuration)
        {
            this.driver = configuration.driver;
            
        }

        internal void ClickSaveBtn()
        {
            //driver.FindElement();
        }

    }
}

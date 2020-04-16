using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MobileKey.Axeos.AppAutomation.Pages;

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
        MKDeviceListPage mKDeviceListPage;
        MKMatrixPage mKMatrixPage;
        MKSettingsPage mKSettingspage;
        ConfigurationClass configuration;

        internal MobileKey()
        {
            configuration = new ConfigurationClass();
            mKDeviceListPage = new MKDeviceListPage(configuration);
            mKMatrixPage = new MKMatrixPage(configuration);
            mKSettingspage = new MKSettingsPage(configuration);
        }

        public void LaunchApplication()
        {
            if (configuration.isBrowser)
            {

            }else if (configuration.isAndroid)
            {

            }else if (configuration.isIOS)
            {

            }
        }
        public void QuitApplication()
        {
            if (configuration.isBrowser)
            {

            }
            else if (configuration.isAndroid)
            {

            }
            else if (configuration.isIOS)
            {

            }

        }   
        
        


    }
}

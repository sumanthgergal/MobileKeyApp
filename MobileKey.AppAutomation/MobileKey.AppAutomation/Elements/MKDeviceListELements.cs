using System;
using System.Collections.Generic;
using System.Text;

namespace MobileKey.Axeos.AppAutomation
{
    internal class MKDeviceListELements
    {
        public MKDeviceListELements()
        {
        }

        internal MKDeviceListELements(ConfigurationClass configuration):base()
        {
            if (configuration.isBrowser)
            {

            }else if (configuration.isAndroid)
            {

            }
            else if (configuration.isIOS)
            {

            }
        }
    }
}

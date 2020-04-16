using System;
using System.Collections.Generic;
using System.Text;

namespace MobileKey.Axeos.AppAutomation.Elements
{
    internal class MKMatrixElements
    {

        public MKMatrixElements()
        {
        }

        internal MKMatrixElements(ConfigurationClass configuration) : base()
        {
            if (configuration.application.Equals(AppTypeData.Browser))
            {

            }
            else if (configuration.application.Equals(AppTypeData.Android))
            {

            }
            else if (configuration.application.Equals(AppTypeData.IOS))
            {

            }
        }
    }
}

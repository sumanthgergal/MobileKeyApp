using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace MobileKey.Axeos.AppAutomation
{
    internal class BaseSetUp
    {
        internal MobileKey mobileKey;

        [OneTimeSetUp]
        public void MainSetUp()
        {
            mobileKey = new MobileKey();

        }

        [OneTimeTearDown]
        public void CleanUpAtEnd()
        {

        }
    }
}

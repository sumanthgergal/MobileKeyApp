using System;
using NUnit.Framework;

namespace MobileKey.Axeos.AppAutomation
{
    [TestFixture]
    internal class SetUp : BaseSetUp
    {

        [SetUp]
        public void Login()
        {
            mobileKey.LaunchApplication();
            
        }

        [TearDown]
        public void EndClass()
        {
            mobileKey.QuitApplication();
        }



    }


}

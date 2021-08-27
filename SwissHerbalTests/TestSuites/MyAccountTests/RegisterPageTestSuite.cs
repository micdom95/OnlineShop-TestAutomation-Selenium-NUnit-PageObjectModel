using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects;
using SwissHerbalTests.PageObjects.MyAccountPage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.TestSuites.MyAccountTests
{
    [TestFixture]
    public class RegisterPageTestSuite
    {
        [Test]
        public void Register_RegisterWithCorrectData()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MyAccountPageActions myAccountPageActions = new MyAccountPageActions(_driver);
            }
        }
    }
}

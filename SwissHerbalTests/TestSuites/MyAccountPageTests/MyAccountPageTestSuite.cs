﻿using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects;
using SwissHerbalTests.PageObjects.MyAccountPage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SwissHerbalTests.TestSuites.MyAccountPageTests
{
    [TestFixture]
    public class MyAccountPageTestSuite
    {
        [Test]
        [Ignore("Test with Captcha")]
        public void Login_LoginWithCorrectData() 
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MyAccountPageActions myAccountPageActions = new MyAccountPageActions(_driver);
                myAccountPageActions.OpenMyAccountPage();
                myAccountPageActions.GiveUserLogin("swissherbal123");
                myAccountPageActions.GiveUserPassword("Testtest1234");
                myAccountPageActions.LoginCaptchaButtonClick();
                myAccountPageActions.LoginButtonClick();
            }
        }
        [Test]
        [Ignore("Test with Captcha")]
        public void Login_LoginWithIncorrectData_EmptyLoginField()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MyAccountPageActions myAccountPageActions = new MyAccountPageActions(_driver);
                myAccountPageActions.OpenMyAccountPage();
                myAccountPageActions.GiveUserLogin("");
                myAccountPageActions.GiveUserPassword("Testtest1234");
                myAccountPageActions.LoginCaptchaButtonClick();
                myAccountPageActions.LoginButtonClick();
            }
        }
        [Test]
        [Ignore("Test with Captcha")]
        public void Login_LoginWithIncorrectData_EmptyPasswordField()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MyAccountPageActions myAccountPageActions = new MyAccountPageActions(_driver);
                myAccountPageActions.OpenMyAccountPage();
                myAccountPageActions.GiveUserLogin("swissherbal123");
                myAccountPageActions.GiveUserPassword("");
                myAccountPageActions.LoginCaptchaButtonClick();
                myAccountPageActions.LoginButtonClick();
            }
        }
    }
}
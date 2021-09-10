using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.MyAccountPage
{
    public class MyAccountPageActions : MyAccountPageLocators
    {
        private IWebDriver _driver;

        public MyAccountPageActions(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        
        public void OpenMyAccountPage()
        {
            string myAccountPageUrl = "https://pl.swissherbal.eu/moje-konto/";
            _driver.Navigate().GoToUrl(myAccountPageUrl);
            _driver.Url.Should().Be(myAccountPageUrl);
        }
        
        public void GiveUserLogin(string userLogin)
        {
            UserNameField.Displayed.Should().BeTrue();
            UserNameField.SendKeys(userLogin);
        }
        
        public void GiveUserPassword(string userPassword)
        {
            UserPasswordField.Displayed.Should().BeTrue();
            UserPasswordField.SendKeys(userPassword);
        }
       
        public void LoginButtonClick()
        {
            LoginButton.Displayed.Should().BeTrue();
            LoginButton.Click();
        }
       
        public void GiveNewUserLogin(string newUserLogin)
        {
            RegisterUserNameField.Displayed.Should().BeTrue();
            RegisterUserNameField.SendKeys(newUserLogin);
        }
        
        public void GiveNewUserMailAddress(string newUserMailAddress)
        {
            RegisterUserMailAddressField.Displayed.Should().BeTrue();
            RegisterUserMailAddressField.SendKeys(newUserMailAddress);
        }
        
        public void GiveNewUserPassword(string newUserPassword)
        {
            RegisterUserPasswordField.Displayed.Should().BeTrue();
            RegisterUserPasswordField.SendKeys(newUserPassword);
        }
        
        public void RegisterButtonClick()
        {
            RegisterButton.Displayed.Should().BeTrue();
            RegisterButton.Click();
        }
        
        public void RemindUserPasswordButtonClick()
        {
            RemindUserPasswordButton.Displayed.Should().BeTrue();
            RemindUserPasswordButton.Click();
        }
        
        public void LoginCaptchaButtonClick()
        {
            LoginCaptchaButton.Displayed.Should().BeTrue();
            LoginCaptchaButton.Click();
        }
    }

}

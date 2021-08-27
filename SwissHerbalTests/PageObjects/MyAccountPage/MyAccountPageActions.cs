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
            string loginPageUrl = "https://pl.swissherbal.eu/moje-konto/";
            _driver.Navigate().GoToUrl(loginPageUrl);
        }
        
        public void GiveUserLogin(string userLogin)
        {
            UserNameField.SendKeys(userLogin);
        }
        
        public void GiveUserPassword(string userPassword)
        {
            UserPasswordField.SendKeys(userPassword);
        }
       
        public void LoginButtonClick()
        {
            LoginButton.Click();
        }
       
        public void GiveNewUserLogin(string newUserLogin)
        {
            RegisterUserNameField.SendKeys(newUserLogin);
        }
        
        public void GiveNewUserMailAddress(string newUserMailAddress)
        {
            RegisterUserMailAddressField.SendKeys(newUserMailAddress);
        }
        
        public void GiveNewUserPassword(string newUserPassword)
        {
            RegisterUserPasswordField.SendKeys(newUserPassword);
        }
        
        public void RegisterButtonClick()
        {
            RegisterButton.Click();
        }
        
        public void RemindUserPasswordButtonClick()
        {
            RemindUserPasswordButton.Click();
        }
        
        public void LoginCaptchaButtonClick()
        {
            LoginCaptchaButton.Click();
        }
    }

}

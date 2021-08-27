using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.MyAccountPage
{
    public class MyAccountPageLocators
    {
        private IWebDriver _driver;

        public MyAccountPageLocators(IWebDriver driver)
        {
            _driver = driver;
        }
        //LOGIN LOCATORS
        public IWebElement UserNameField => _driver.FindElement(By.Id("username"));
        public IWebElement UserPasswordField => _driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => _driver.FindElement(By.Name("login"));
        //REGISTER LOCATORS
        public IWebElement RegisterUserNameField => _driver.FindElement(By.Id("reg_username"));
        public IWebElement RegisterUserMailAddressField => _driver.FindElement(By.Id("reg_email"));
        public IWebElement RegisterUserPasswordField => _driver.FindElement(By.Id("reg_password"));
        public IWebElement RegisterButton => _driver.FindElement(By.Name("register"));
        public IWebElement RemindUserPasswordButton => _driver.FindElement(By.LinkText("Nie pamiętasz hasła?"));
        //CAPTCHA
        public IWebElement LoginCaptchaButton => _driver.FindElements(By.XPath(@"//iframe"))[0];
        //TODO
        public IWebElement EmptyLoginLabel => _driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/article/div/div/div[1]/ul/li"));
        public IWebElement EmptyPasswordLabel => _driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/article/div/div/div[1]/ul/li"));
        public IWebElement WrongLoginLabel => _driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/article/div/div/div[1]/ul/li"));
        public IWebElement WrongPasswordLabel => _driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/article/div/div/div[1]/ul/li"));

    }
}

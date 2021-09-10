using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.OrderPage
{
    public class OrderPageLocators
    {
        IWebDriver _driver;

        public OrderPageLocators(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement AcceptCookieButton => _driver.FindElement(By.CssSelector("a[id='cookie_action_close_header']"));
    }
}

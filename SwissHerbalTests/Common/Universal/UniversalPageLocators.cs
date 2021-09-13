using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.Common.Universal
{
    public class UniversalPageLocators
    {
        private IWebDriver _driver;

        public UniversalPageLocators(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement MyAccountButton => _driver.FindElement(By.LinkText("Moje konto"));
        public IWebElement BasketButton => _driver.FindElement(By.LinkText("Koszyk"));
        public IWebElement OrderButton => _driver.FindElement(By.LinkText("Zamówienie"));
        public IWebElement SuplementsTab => _driver.FindElement(By.CssSelector("a[title='SUPLEMENTY']"));
        public IWebElement SuplementsTabSubMenu => _driver.FindElement(By.LinkText("ENERGIA"));
        public IWebElement AcceptCookieButton => _driver.FindElement(By.CssSelector("a[id='cookie_action_close_header']"));
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.ShoppingBasket
{
    public class ShoppingBasketLocators
    {
        private IWebDriver _driver;

        public ShoppingBasketLocators(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

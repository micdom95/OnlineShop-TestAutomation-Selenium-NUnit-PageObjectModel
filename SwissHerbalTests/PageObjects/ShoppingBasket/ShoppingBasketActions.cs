using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.ShoppingBasket
{
    public class ShoppingBasketActions : ShoppingBasketLocators
    {
        private IWebDriver _driver;

        public ShoppingBasketActions(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
    }
}

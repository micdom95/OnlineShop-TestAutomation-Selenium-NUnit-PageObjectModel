using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.ShoppingBasket
{
    public class ShoppingBasketPageLocators
    {
        private IWebDriver _driver;

        public ShoppingBasketPageLocators(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement EmptyBasketLabel => _driver.FindElement(By.XPath("//p[@class='cart-empty woocommerce-info']"));
        public IWebElement BackwardToShopButton => _driver.FindElement(By.XPath("//a[@class='button wc-backward']"));
    }
}

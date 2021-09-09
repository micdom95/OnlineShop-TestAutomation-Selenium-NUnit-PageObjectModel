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
        public IWebElement GoToOrderPageButton => _driver.FindElement(By.XPath("//a[@class='checkout-button button alt wc-forward']"));
        public IWebElement InvalidCouponCodeLabel => _driver.FindElement(By.XPath("//ul[@class='woocommerce-error']"));
        public IWebElement EmptyCouponCodeLabel => _driver.FindElement(By.XPath("//ul[@class='woocommerce-error']"));
        public IWebElement DeletedProductLabel => _driver.FindElement(By.XPath("//div[@class='woocommerce-message']"));
        public IList<IWebElement> AddedItemTable => _driver.FindElement(By.XPath("//table[@class='shop_table shop_table_responsive cart woocommerce-cart-form__contents']")).FindElements(By.XPath("//tr[@class='woocommerce-cart-form__cart-item cart_item']"));
        public IWebElement CouponCodeTextbox => _driver.FindElement(By.Id("coupon_code"));
        public IWebElement RealiseCouponButton => _driver.FindElement(By.Name("apply_coupon"));
    }
}

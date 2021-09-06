using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.MainPage
{
    public class MainPageLocators
    {
        private IWebDriver _driver;

        public MainPageLocators(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement MyAccountButton => _driver.FindElement(By.LinkText("Moje konto"));
        public IWebElement BasketButton => _driver.FindElement(By.LinkText("Koszyk"));
        public IWebElement OrderButton => _driver.FindElement(By.LinkText("Zamówienie"));
        public IWebElement SuplementsTab => _driver.FindElement(By.CssSelector("a[title='SUPLEMENTY']"));
        public IWebElement SuplementsTabSubMenu => _driver.FindElement(By.LinkText("ENERGIA"));
        public IWebElement SearchIconButton => _driver.FindElement(By.CssSelector("[class='glyphicon  glyphicon-search  glyphicon-search--nav']"));
        public IWebElement SearchTextbox => _driver.FindElement(By.Name("s"));
        public IWebElement SearchResultLabel => _driver.FindElement(By.XPath("//span[@class='banners-text']"));
        public IList<IWebElement> ProductsTable => _driver.FindElement(By.XPath("//div[@class='products__single']/figure/a")).FindElements(By.XPath("//div[@class='product-overlay__stock']"));
        public IWebElement AddProductButton => _driver.FindElement(By.CssSelector("[class='product-overlay__cart add_to_cart_button product_type_variable']"));
        public IWebElement AcceptCookieButton => _driver.FindElement(By.CssSelector("a[id='cookie_action_close_header']"));
        public IWebElement BasketItemCounter => _driver.FindElement(By.XPath("//span[@class='header-cart__items-num']"));
    }
}

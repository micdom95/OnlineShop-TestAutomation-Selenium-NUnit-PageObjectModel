using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SwissHerbalTests.Common.Dictionaries;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissHerbalTests.PageObjects.MainPage
{
    public class MainPageActions : MainPageLocators
    {
        private IWebDriver _driver;

        public MainPageActions(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void OpenGivenPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Url.Should().Be(url);
        }

        public void OpenMainPage()
        {
            string mainPageUrl = "https://pl.swissherbal.eu/";
            _driver.Navigate().GoToUrl(mainPageUrl);
            _driver.Url.Should().Be(mainPageUrl);
        }

        public void OpenMyAccountPage()
        {
            MyAccountButton.Displayed.Should().BeTrue();
            MyAccountButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/moje-konto/");
        }

        public void OpenBasketPage()
        {
            BasketButton.Displayed.Should().BeTrue();
            BasketButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/koszyk/");
        }

        public void OpenOrderPage()
        {
            OrderButton.Displayed.Should().BeTrue();
            OrderButton.Click();
        }

        public void ClickAcceptCookieButton()
        {
            AcceptCookieButton.Displayed.Should().BeTrue();
            AcceptCookieButton.Click();
        }

        public void CheckBasketItemCounter()
        {
            string counter = BasketItemCounter.Text;
            BasketItemCounter.Text.Should().Be(counter);
        }

        public void SelectSuplementsTabHover(SuplementsTabs suplementsTab)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(SuplementsTab).Perform();
            //actions.MoveToElement((IWebElement)SuplementsTabSubMenu.Select(tab => tab.Text.Contains(suplementsTab.ToString().FirstOrDefault())));
            //SelectElement dropdown = new SelectElement(SuplementsTab);
            //dropdown.SelectByText(suplementsTab.ToString());
            //actions.Click().Build().Perform();
            
            string url = SuplementsTabDictionary.suplementsTabsUrls[suplementsTab];
            
            _driver.Url.Should().Be(url);
        }

        public void SelectTabFromSuplementsHover(int index)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(SuplementsTab).Perform();
            WaitForAction.WaitUntilElementVisible(_driver, By.XPath("//ul[@role='menu']"));
            SelectElement dropdown = new SelectElement(SuplementsTab);
            dropdown.SelectByIndex(index);
        }
        
        public void ClickSearchIconButton()
        {
            SearchIconButton.Displayed.Should().BeTrue();
            SearchIconButton.Click();
        }
        public void SearchTextboxInput(string text)
        {
            SearchTextbox.Clear();
            SearchTextbox.SendKeys(text);
        }

        public void ClickSearchEngineButton(string text)
        {
            SearchEngineButton.Click();
        }

        public void CheckSearchResultLabel(string text)
        {
            SearchResultLabel.Text.Should().Contain(text);
        }

        public void ClickAddProductButton()
        {
            AddProductButton.Click();
        }

        public void FindAllProductsOnPage()
        {
            ProductsTable.Count().Should().Be(20);
        }

        public void FindInStockProductsOnPage(int checkValue)
        {
            //TODO - SHOW ALL PRODUCTS ON PAGE
            ProductsTable.Select(p => p.FindElement(By.XPath("//span[@class='in-stock']"))).ToList().Count().Should().Be(checkValue);
        }

        public void SelectOutOfStockProduct()
        {
            //TODO - SELECT RANDOM FIRST OR DEFAULT AND OUT OF STOCK TOO
            ProductsTable.Select(p => p.FindElement(By.XPath("//span[@class='out-of-stock']"))).FirstOrDefault();
        }

        public void SelectInStockProduct()
        {
            ProductsTable.Select(p => p.FindElement(By.XPath("//span[@class='in-stock']"))).FirstOrDefault();
        }

        public void SelectInStockProductFromCollection()
        {
            CollectionInStockProducts.FirstOrDefault().FindElement(By.CssSelector("[class='product-overlay__cart add_to_cart_button product_type_variable']")).Click();
        }

        public void SelectOutOfStockProductFromCollection()
        {
            var singleProduct = CollectionOutOfStockProducts.FirstOrDefault();
            WaitForAction.WaitUntilElementVisible(_driver, (By.CssSelector("[class='product-overlay__cart add_to_cart_button product_type_variable']")));
            singleProduct.FindElement((By.CssSelector("[class='product-overlay__cart add_to_cart_button product_type_variable']")));
        }
    }
}

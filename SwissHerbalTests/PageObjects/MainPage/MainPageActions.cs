using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        public void OpenMainPage()
        {
            string mainPageUrl = "https://pl.swissherbal.eu/";
            _driver.Navigate().GoToUrl(mainPageUrl);
            _driver.Url.Should().Be(mainPageUrl);
        }

        public void OpenMyAccountPage()
        {
            OpenMainPage();
            MyAccountButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/moje-konto/");
        }

        public void OpenBasketPage()
        {
            OpenMainPage();
            BasketButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/koszyk/");
        }

        public void OpenOrderPage()
        {
            OpenMainPage();
            OrderButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/zamowienie/");
        }

        public void AcceptCookieButtonClick()
        {
            AcceptCookieButton.Click();
        }

        public void SuplementsTabHover()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(SuplementsTab).Perform();
            actions.MoveToElement(SuplementsTabSubMenu).Perform();
            actions.Click().Build().Perform();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/kategoria-produktu/energia/");
        }

        public void SearchIconButtonClick()
        {
            SearchIconButton.Click();
        }
        public void SearchTextboxInput(string text)
        {
            WaitForAction.WaitUntilElementVisible(_driver, By.Name("s"));
            SearchTextbox.SendKeys(text);
        }

        public void AddProductButtonClick()
        {
            AddProductButton.Click();
        }

        public void FindtAllProductsOnPage()
        {
            ProductsTable.Count().Should().Be(20);
        }

        public void FindInStockProductsOnPage()
        {
            //TODO - SHOW 20 PRODUCTS
            ProductsTable.Select(p => p.FindElement(By.XPath("//span[@class='in-stock']"))).ToList().Count().Should().Be(17);
        }

        public void SelectOutOfStockProduct()
        {
            ProductsTable.Select(p => p.FindElement(By.XPath("//span[@class='out-of-stock']"))).FirstOrDefault();
        }

        public void SelectInStockProduct()
        {
            ProductsTable.Select(p => p.FindElement(By.XPath("//span[@class='in-stock']"))).FirstOrDefault();
        }
    }
}

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
            OpenMainPage();
            MyAccountButton.Displayed.Should().BeTrue();
            MyAccountButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/moje-konto/");
        }

        public void OpenBasketPage()
        {
            OpenMainPage();
            BasketButton.Displayed.Should().BeTrue();
            BasketButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/koszyk/");
        }

        public void OpenOrderPage()
        {
            OpenMainPage();
            OrderButton.Displayed.Should().BeTrue();
            OrderButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/zamowienie/");
        }

        public void AcceptCookieButtonClick()
        {
            AcceptCookieButton.Displayed.Should().BeTrue();
            AcceptCookieButton.Click();
        }

        public void CheckBasketItemCounter()
        {
            string counter = BasketItemCounter.Text;
            BasketItemCounter.Text.Should().Be(counter);
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
            SearchIconButton.Displayed.Should().BeTrue();
            SearchIconButton.Click();
        }
        public void SearchTextboxInput(string text)
        {
            SearchTextbox.Clear();
            SearchTextbox.SendKeys(text);
        }

        public void SearchEngineButtonClick(string text)
        {
            SearchEngineButton.Click();
        }

        public void CheckSearchResultLabel(string text)
        {
            SearchResultLabel.Text.Should().Contain(text);
        }

        public void AddProductButtonClick()
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
    }
}

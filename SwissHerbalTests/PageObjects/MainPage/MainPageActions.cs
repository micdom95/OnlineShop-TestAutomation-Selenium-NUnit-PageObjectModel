using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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

        public void SuplementsTabHover(SuplementsTabs suplementsTab)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(SuplementsTab).Perform();
            //actions.MoveToElement((IWebElement)SuplementsTabSubMenu.Select(tab => tab.Text.Contains(suplementsTab.ToString())));
            SelectElement dropdown = new SelectElement(SuplementsTab);
            dropdown.SelectByText(suplementsTab.ToString());
            actions.Click().Build().Perform();
            string url = (@"https://pl.swissherbal.eu/kategoria-produktu/{suplementsTab.ToString/}");
            _driver.Url.Should().Be(url);
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

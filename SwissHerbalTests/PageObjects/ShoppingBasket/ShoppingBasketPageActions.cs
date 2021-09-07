using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.ShoppingBasket
{
    public class ShoppingBasketPageActions : ShoppingBasketPageLocators
    {
        private IWebDriver _driver;

        public ShoppingBasketPageActions(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void OpenShoppingBasketPage()
        {
            _driver.Navigate().GoToUrl("https://pl.swissherbal.eu/koszyk/");
            _driver.Url.Should().Be("https://pl.swissherbal.eu/koszyk/");
        }

        public void CheckEmptyBasketLabel()
        {
            EmptyBasketLabel.Displayed.Should().BeTrue();
            EmptyBasketLabel.Text.Should().Be("Twój koszyk jest pusty.");
        }

        public void BackwardToShopButtonClick()
        {
            BackwardToShopButton.Displayed.Should().BeTrue();
            BackwardToShopButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/sklep/");
        }
    }
}

using FluentAssertions;
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

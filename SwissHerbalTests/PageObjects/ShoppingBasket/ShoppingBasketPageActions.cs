using FluentAssertions;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Extensions;
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
            WaitForAction.WaitUntilElementVisible(_driver, By.XPath("//p[@class='cart-empty woocommerce-info']"));
            EmptyBasketLabel.Displayed.Should().BeTrue();
            EmptyBasketLabel.Text.Should().Be("Twój koszyk jest pusty.");
        }

        public void BackwardToShopButtonClick()
        {
            BackwardToShopButton.Displayed.Should().BeTrue();
            BackwardToShopButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/sklep/");
        }

        public void GoToOrderPageButtonClick()
        {
            GoToOrderPageButton.Displayed.Should().BeTrue();
            GoToOrderPageButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/zamowienie/");
        }

        public void CheckEmptyCouponCodeLabel()
        {
            WaitForAction.WaitUntilElementExists(_driver, (By.XPath("//ul[@class='woocommerce-error']")));
            EmptyCouponCodeLabel.Displayed.Should().BeTrue();
            EmptyCouponCodeLabel.Text.Should().Contain("Proszę wpisać kod kuponu.");
        }

        public void CheckInvalidCouponCodeLabel()
        {
            WaitForAction.WaitUntilElementExists(_driver, (By.XPath("//ul[@class='woocommerce-error']")));
            InvalidCouponCodeLabel.Displayed.Should().BeTrue();
            InvalidCouponCodeLabel.Text.Should().Contain("nie istnieje!");
        }

        public void CheckDeletedProductLabel()
        {
            DeletedProductLabel.Displayed.Should().BeTrue();
            DeletedProductLabel.Text.Should().Contain("Usunięto:");
        }

        public void CouponCodeTextboxInput(string couponCode)
        {
            CouponCodeTextbox.Displayed.Should().BeTrue();
            CouponCodeTextbox.Click();
            CouponCodeTextbox.SendKeys(couponCode);
        }

        public void RealiseCouponButtonClick()
        {
            RealiseCouponButton.Displayed.Should().BeTrue();
            RealiseCouponButton.Click();
        }

        public void DeleteSingleItemFromTable(int index)
        {
            AddedItemTable[index].FindElement(By.XPath("//a[@class='remove']")).Click();
            CheckDeletedProductLabel();
        }

        public void DeleteAllItemsFromTable()
        {
            foreach (var product in AddedItemTable)
            {
                product.FindElement(By.XPath("//a[@class='remove']")).Click();
                CheckDeletedProductLabel();
            }
            
        }
    }
}

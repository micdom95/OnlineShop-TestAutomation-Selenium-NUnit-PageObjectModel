using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects.ShoppingBasket;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.TestSuites.ShoppingBasketTests
{
    public class ShoppingBasketPageTestSuite
    {
        [Test]
        public void OpenShoppingBasketPage_PageOpenedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ShoppingBasketPageActions shoppingBasketPageActions = new ShoppingBasketPageActions(_driver);
                shoppingBasketPageActions.OpenShoppingBasketPage();
            }
        }

        [Test]
        public void CheckEmptyBasketLabel_WithoutItemsInBasket_LabelDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ShoppingBasketPageActions shoppingBasketPageActions = new ShoppingBasketPageActions(_driver);
                shoppingBasketPageActions.OpenShoppingBasketPage();
                shoppingBasketPageActions.CheckEmptyBasketLabel();
            }
        }

        [Test]
        public void CheckBackwardButton_ButtonIsDisplayed_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ShoppingBasketPageActions shoppingBasketPageActions = new ShoppingBasketPageActions(_driver);
                shoppingBasketPageActions.OpenShoppingBasketPage();
                shoppingBasketPageActions.BackwardToShopButtonClick();
            }
        }
    }
}

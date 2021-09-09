using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects.ItemPage;
using SwissHerbalTests.PageObjects.MainPage;
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

        [Test]
        public void CheckEmptyCouponCode_WithoutTypedCode_LabelDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
                itemPageActions.GoToBasketPageButtonClick();
                ShoppingBasketPageActions shoppingBasketPageActions = new ShoppingBasketPageActions(_driver);
                shoppingBasketPageActions.CouponCodeTextboxInput("");
                shoppingBasketPageActions.RealiseCouponButtonClick();
                shoppingBasketPageActions.CheckEmptyCouponCodeLabel();
            }
        }

        [Test]
        [TestCase("InvalidCode")]
        public void CheckInvalidCouponCode_WithTypedCode_LabelDisplayedProperly(string couponCode)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
                mainPageActions.CheckBasketItemCounter();
                itemPageActions.GoToBasketPageButtonClick();
                ShoppingBasketPageActions shoppingBasketPageActions = new ShoppingBasketPageActions(_driver);
                shoppingBasketPageActions.CouponCodeTextboxInput(couponCode);
                shoppingBasketPageActions.RealiseCouponButtonClick();
                shoppingBasketPageActions.CheckInvalidCouponCodeLabel();
            }
        }

        [Test]
        [TestCase(0)]
        public void DeleteProductFromTable_OneProductAddedToShoppingBasket_ProductDeletedProperly(int index)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
                itemPageActions.GoToBasketPageButtonClick();
                ShoppingBasketPageActions shoppingBasketPageActions = new ShoppingBasketPageActions(_driver);
                shoppingBasketPageActions.DeleteSingleItemFromTable(0);
                shoppingBasketPageActions.CheckEmptyBasketLabel();
            }
        }

        [Test]
        public void DeleteAllProductsFromTable_TwoProductsAddedToShoppingBasket_ProductsDeletedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
                mainPageActions.OpenMainPage();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
                itemPageActions.GoToBasketPageButtonClick();
                ShoppingBasketPageActions shoppingBasketPageActions = new ShoppingBasketPageActions(_driver);
                shoppingBasketPageActions.DeleteAllItemsFromTable();

            }
        }
    }
}

using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects;
using SwissHerbalTests.PageObjects.ItemPage;
using SwissHerbalTests.PageObjects.MainPage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SwissHerbalTests.TestSuites.MainPageTests
{
    [TestFixture]
    public class MainPageTestSuite
    {
        [Test]
        [Category("Smoke test")]
        public void OpenMainPage_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
            }
        }

        [Test]
        [Category("Smoke test")]
        public void OpenMyAccountPage_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.OpenMyAccountPage();
            }
        }

        [Test]
        [Category("Smoke test")]
        public void OpenBasketPage_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.OpenBasketPage();
            }
        }

        [Test]
        [Category("Smoke test")]
        public void CheckOrderPage_WithoutItemInBasket_BasketPageOpened()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.OpenOrderPage();
                _driver.Url.Should().Be("https://pl.swissherbal.eu/koszyk/");

            }
        }

        [TestCase("https://pl.swissherbal.eu/sklep/noopeptil-max/")]
        [TestCase("https://pl.swissherbal.eu/sklep/noopept/")]
        [TestCase("https://pl.swissherbal.eu/sklep/immuno-box-mushroom-synergy/")]
        [Category("Smoke test")]
        public void OpenGivenPage_PageOpenedProperly_CorrectUrlAddress(string url)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenGivenPage(url);
            }
        }
        
        [Test]
        public void CheckBasketItemCounter_ItemCounterShouldBeZero_CountedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.CheckBasketItemCounter();
            }
        }

        [Test]
        public void SearchItem_OpenSearchEngine_SearchEngineOpened()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.ClickSearchIconButton();
            }
        }

        [Test]
        public void SearchItem_SearchItemByText_SearchProcessWorkProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.ClickSearchIconButton();
                mainPageActions.ClickSearchEngineButton("");
            }
        }

        [Test]
        [TestCase(SuplementsTabs.ENERGIA)]
        public void SuplementsTab_ClickEnergyTab_TabOpenedProperly(SuplementsTabs suplementsTab)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.ClickAcceptCookieButton();
                mainPageActions.SuplementsTabHover(suplementsTab);
            }
        }

        [Test]
        [TestCase(3)]
        public void SuplementsTab_ClickTabWithIndex3_TabOpenedProperly(int index)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.ClickAcceptCookieButton();
                mainPageActions.SelectTabFromSuplementsHover(index);
                Thread.Sleep(5000);
            }

        }

        [Test]
        public void DisplayedProductCounter_ProductsCountedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.FindAllProductsOnPage();
            }
        }

        [Test]
        [TestCase(20)]
        public void DisplayedInStockProductCounter_ProductsCountedProperly(int checkValue)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.FindInStockProductsOnPage(checkValue);
            }
        }

        [Test]
        public void SelectProductFromPage_SelectFirstOrDefaultInStockProduct_ProductSelectedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                ProductPageActions itemPageActions = new ProductPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.ClickAcceptCookieButton();
                mainPageActions.SelectInStockProduct();
                mainPageActions.ClickAddProductButton();
                itemPageActions.ClickAddItemButton();
                mainPageActions.CheckBasketItemCounter();
            }
        }

        [Test]
        public void CheckOrderPage_AddItemToBasket_CorrectUrlAddress()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                ProductPageActions itemPageActions = new ProductPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.ClickAcceptCookieButton();
                mainPageActions.SelectInStockProduct();
                mainPageActions.ClickAddProductButton();
                itemPageActions.SelectPackageWith60Capsules();
                itemPageActions.ClickAddItemButton();
                itemPageActions.CheckAddItemLabelText();
                mainPageActions.CheckBasketItemCounter();
                mainPageActions.OpenOrderPage();
                _driver.Url.Should().Be("https://pl.swissherbal.eu/zamowienie/");
            }
        }

        [Test]
        public void SelectProductFromPage_SelectFirstOrDefaultOutOfStockProduct_ProductSelectedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.ClickAcceptCookieButton();
                mainPageActions.SelectOutOfStockProduct();
                mainPageActions.ClickAddProductButton();
            }
        }
    }
}

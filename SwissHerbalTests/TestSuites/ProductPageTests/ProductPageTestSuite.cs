using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects.ItemPage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SwissHerbalTests.TestSuites.ItemPageTests
{
    [TestFixture]
    public class ProductPageTestSuite
    {
        [Test]
        public void OpenItemPage_RandomItemPage_PageOpenedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenRandomAvailableProductPage();
            }
        }

        [Test]
        [TestCase("-1")]
        [TestCase("0")]
        [TestCase("1")]
        [TestCase("2.5")]
        public void CounterField_SetValue_ValueSetProperly(string value)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenRandomAvailableProductPage();
                productPageActions.ItemCounterFieldOperations(value);
            }
        }

        [Test]
        public void SelectPackageOption_WithoutChoosenPackage_OptionSelectedPackage()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenRandomAvailableProductPage();
                productPageActions.ClickSelectPackageField();
                productPageActions.SelectPackageWithoutChoosenOption();
            }
        }

        [Test]
        public void AddItemToBasket_ItemWith30Capsules_ItemAddedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenRandomAvailableProductPage();
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.ClickSelectPackageField();
                productPageActions.SelectPackageWith30Capsules();
                productPageActions.ClickAddItemButton();
                productPageActions.CheckAddItemLabelText();
            }
        }

        [Test]
        public void CheckItemAvailability_ItemNotAvailable_InformationDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenRandomUnavailableProductPage();
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.CheckOutOfStockItemLabel();
            }
        }

        [Test]
        public void CheckAllOptionsAvailability_AllOptionsUnavailable_InformationDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/adrafinil-dlpa/");
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.CheckTemporaryMissingLabel();
                productPageActions.ClickSelectPackageField();
                productPageActions.SelectPackageWith30Capsules();
                productPageActions.CheckOutOfStockItemLabel();
                productPageActions.CheckTemporaryMissingLabel();
                productPageActions.ClickSelectPackageField();
                productPageActions.SelectPackageWith60Capsules();
                productPageActions.CheckOutOfStockItemLabel();
                productPageActions.CheckTemporaryMissingLabel();
            }
        }

        [Test]
        [TestCase("IncorrectEmail")]
        public void CheckModalIncorrectEmailLabel_IncorrectEmail_ModalDisplayedProperly(string email)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/immuno-box-mushroom-synergy/");
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.CheckTemporaryMissingLabel();
                productPageActions.ClickAddToWaitingListButton();
                productPageActions.AddToWaitingListModalEmailTextboxInput(email);
                productPageActions.ClickAddToWaitingListModalNotificationButton();
                productPageActions.CheckModalIncorrectEmailErrorLabel();
            }
        }

        [Test]
        [TestCase("")]
        public void CheckModalEmptyEmailLabel_EmptyEmailTextbox_ModalDisplayedProperly(string email)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/immuno-box-mushroom-synergy/");
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.CheckTemporaryMissingLabel();
                productPageActions.ClickAddToWaitingListButton();
                productPageActions.AddToWaitingListModalEmailTextboxInput(email);
                productPageActions.ClickAddToWaitingListModalNotificationButton();
                productPageActions.CheckModalEmptyEmailErrorLabel();
            }
        }

        [Test]
        public void CheckOptionAlert_NotSelectedProductOption_AlertDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/neuridine/");
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.ClickClearPackageOptionButton();
                productPageActions.ClickAddItemWithoutSelectedOptionButton();
                productPageActions.AcceptOptionAlertButton();
            }
        }

        [Test]
        [TestCase("https://pl.swissherbal.eu/sklep/noopeptil/")]
        public void CheckOutOfStockAlert_AddUnavailableProduct_AlertDisplayedProperly(string productUrl)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenGivenPage(productUrl);
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.SelectPackageWith60Capsules();
                productPageActions.CheckOutOfStockItemLabel();
                productPageActions.ClickAddUnavailableItemButton();
                productPageActions.AcceptOutOfStockAlertButton();
            }
        }

        [Test]
        public void CheckOptionAlert_AddItemWithoutChoosenOption_AlertDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ProductPageActions productPageActions = new ProductPageActions(_driver);
                productPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/noopeptil/");
                productPageActions.ClickAcceptCookiesButton();
                productPageActions.SelectPackageWithoutChoosenOption();
                productPageActions.ClickAddItemWithoutSelectedOptionButton();
                productPageActions.AcceptOptionAlertButton();
            }
        }
    }
 
}

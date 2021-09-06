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
    public class ItemPageTestSuite
    {
        [Test]
        public void OpenItemPage_RandomItemPage_PageOpenedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenRandomAvailableProductPage();
            }
        }

        [Test]
        [TestCase("-1")]
        [TestCase("0")]
        [TestCase("1")]
        public void CounterField_SetValue_ValueSetProperly(string value)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenRandomAvailableProductPage();
                itemPageActions.ItemCounterFieldOperations(value);
            }
        }

        [Test]
        public void SelectPackageOption_WithoutChoosenPackage_OptionSelectedPackage()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenRandomAvailableProductPage();
                itemPageActions.SelectPackageFieldClick();
                itemPageActions.SelectPackageWithoutChoosenOption();
            }
        }

        [Test]
        public void AddItemToBasket_ItemWith30Capsules_ItemAddedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenRandomAvailableProductPage();
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.SelectPackageFieldClick();
                itemPageActions.SelectPackageWith30Capsules();
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
            }
        }

        [Test]
        public void CheckItemAvailability_ItemNotAvailable_InformationDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenRandomUnavailableProductPage();
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.CheckOutOfStockItemLabel();
            }
        }

        [Test]
        public void CheckAllOptionsAvailability_AllOptionsUnavailable_InformationDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/adrafinil-dlpa/");
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.CheckTemporaryMissingLabel();
                itemPageActions.SelectPackageFieldClick();
                itemPageActions.SelectPackageWith30Capsules();
                itemPageActions.CheckOutOfStockItemLabel();
                itemPageActions.CheckTemporaryMissingLabel();
                itemPageActions.SelectPackageFieldClick();
                itemPageActions.SelectPackageWith60Capsules();
                itemPageActions.CheckOutOfStockItemLabel();
                itemPageActions.CheckTemporaryMissingLabel();
            }
        }

        [Test]
        public void CheckModalFunctions_UnavailableProduct_ModalDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/memostim/");
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.CheckTemporaryMissingLabel();
                itemPageActions.AddToWaitingListButtonClick();
            }
        }

        [Test]
        public void CheckOptionAlert_NotSelectedProductOption_AlertDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/neuridine/");
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.ClearPackageOptionButtonClick();
                itemPageActions.AddItemWithoutSelectedOptionButtonClick();
                itemPageActions.AcceptOptionAlertButton();
            }
        }

        [Test]
        public void CheckOutOfStockAlert_AddUnavailableProduct_AlertDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/noopeptil/");
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.SelectPackageWith60Capsules();
                itemPageActions.CheckOutOfStockItemLabel();
                itemPageActions.AddUnavailableItemButtonClick();
                itemPageActions.AcceptOutOfStockAlertButton();
            }
        }

        [Test]
        public void CheckOptionAlert_AddItemWithoutChoosenOption_AlertDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/noopeptil/");
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.SelectPackageWithoutChoosenOption();
                itemPageActions.AddItemWithoutSelectedOptionButtonClick();
                itemPageActions.AcceptOptionAlertButton();
            }
        }
    }
 
}

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
    public class ItemPage
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
        public void AddItemToBasket_ItemWith30Capsules_ItemAddedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenRandomAvailableProductPage();
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.SelectPackageFieldClick();
                itemPageActions.SelectPackageWith30Capsules();
                itemPageActions.AddThisItemToShoppingBasketButtonClick();
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
                itemPageActions.CkechOutOfStockItemLabel();
            }
        }

        [Test]
        public void CheckAllOptionsAvailability_AllOptionsUnavailable_InformationDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                ItemPageActions itemPageActions = new ItemPageActions(_driver);
                itemPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/memostim/");
                itemPageActions.AcceptCookiesButtonClick();
                itemPageActions.CheckTemporaryMissingLabel();
                itemPageActions.SelectPackageFieldClick();
                itemPageActions.SelectPackageWith30Capsules();
                itemPageActions.CkechOutOfStockItemLabel();
                itemPageActions.CheckTemporaryMissingLabel();
                itemPageActions.SelectPackageFieldClick();
                itemPageActions.SelectPackageWith60Capsules();
                itemPageActions.CkechOutOfStockItemLabel();
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
                itemPageActions.OpenGivenPage("https://pl.swissherbal.eu/sklep/relatonic-max/");
                itemPageActions.AddToWaitingListButtonClick();
                itemPageActions.ClearPackageOptionButtonClick();
                itemPageActions.AddThisItemToShoppingBasketButtonClick();
                itemPageActions.AcceptOptionAlertButton();
            }
        }
    }
 
}

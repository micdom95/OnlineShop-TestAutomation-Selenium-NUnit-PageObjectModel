using NUnit.Framework;
using OpenQA.Selenium;
using SwissHerbalTests.Common.Enums;
using SwissHerbalTests.Common.Setup;
using SwissHerbalTests.PageObjects.ItemPage;
using SwissHerbalTests.PageObjects.MainPage;
using SwissHerbalTests.PageObjects.OrderPage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.TestSuites.OrderPageTests
{
    [TestFixture]
    public class OrderPageTestSuite
    {
        [Test]
        public void CheckErrorLabels_WithoutTypedDataInAllTextbox_LabelsDisplayedProperly()
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                ProductPageActions itemPageActions = new ProductPageActions(_driver);
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
                mainPageActions.OpenOrderPage();
                OrderPageActions orderPageActions = new OrderPageActions(_driver);
                orderPageActions.SummaryButtonClick();
                orderPageActions.CheckAllErrorLabels();
            }
        }

        [Test]
        [TestCase("InvalidEmailFormat")]
        public void CheckEmailErrorLabel_WithInvalidEmailFormat_LabelDispayedProperly(string invalidEmail)
        {
            using (IWebDriver _driver = TestSetup.ReturnDriver(DriverType.Chrome))
            {
                MainPageActions mainPageActions = new MainPageActions(_driver);
                mainPageActions.OpenMainPage();
                mainPageActions.AcceptCookieButtonClick();
                mainPageActions.SelectInStockProduct();
                mainPageActions.AddProductButtonClick();
                ProductPageActions itemPageActions = new ProductPageActions(_driver);
                itemPageActions.AddItemButtonClick();
                itemPageActions.CheckAddItemLabelText();
                mainPageActions.OpenOrderPage();
                OrderPageActions orderPageActions = new OrderPageActions(_driver);
                orderPageActions.BillingEmailInput(invalidEmail);
                orderPageActions.SummaryButtonClick();
                orderPageActions.CheckEmailFormatErrorLabel();
            }
        }
    }
}

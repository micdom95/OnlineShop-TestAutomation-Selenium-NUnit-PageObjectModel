using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.OrderPage
{
    public class OrderPageLocators
    {
        IWebDriver _driver;

        public OrderPageLocators(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement AcceptCookieButton => _driver.FindElement(By.CssSelector("a[id='cookie_action_close_header']"));
        public IWebElement BillingFirstName => _driver.FindElement(By.Id("billing_first_name"));
        public IWebElement BillingSurnameName => _driver.FindElement(By.Id("billing_last_name"));
        public IWebElement BillingCompany => _driver.FindElement(By.Id("billing_company"));
        public IWebElement BillingEmail => _driver.FindElement(By.Id("billing_email"));
        public IWebElement BillingPhone => _driver.FindElement(By.Id("billing_phone"));
        public IWebElement BillingCountryDropdown => _driver.FindElement(By.Id("select2-billing_country-container"));
        public IWebElement BillingStreetAddress => _driver.FindElement(By.Id("billing_address_1"));
        public IWebElement BillingHouseNumber => _driver.FindElement(By.Id("billing_address_2"));
        public IWebElement BillingCity => _driver.FindElement(By.Id("billing_city"));
        public IWebElement BillingPostcode => _driver.FindElement(By.Id("billing_city"));
        public IWebElement BillingNip => _driver.FindElement(By.Id("billing_nip"));
        public IWebElement CreateAccountCheckbox => _driver.FindElement(By.Id("createaccount"));
        public IWebElement AccountUsername => _driver.FindElement(By.Id("account_username"));
        public IWebElement AccountPassword => _driver.FindElement(By.Id("account_password"));
        public IWebElement ShipToDifferentAddressCheckbox => _driver.FindElement(By.Id("ship-to-different-address-checkbox"));
        public IWebElement ShippingFirstName => _driver.FindElement(By.Id("shipping_first_name"));
        public IWebElement ShippingSurname => _driver.FindElement(By.Id("shipping_last_name"));
        public IWebElement ShippingCompany => _driver.FindElement(By.Id("shipping_company"));
        public IWebElement ShippingCountryDropdown => _driver.FindElement(By.Id("select2-shipping_country-container"));
        public IWebElement ShippingStreetAddress => _driver.FindElement(By.Id("shipping_address_1"));
        public IWebElement ShippingHouseNumber => _driver.FindElement(By.Id("shipping_address_2"));
        public IWebElement ShippingCity => _driver.FindElement(By.Id("shipping_city"));
        public IWebElement ShippingPostcode => _driver.FindElement(By.Id("shipping_postcode"));
        public IWebElement OrderComments => _driver.FindElement(By.Id("order_comments"));
        public IWebElement CashOnDeliveryCheckbox => _driver.FindElement(By.Id("payment_method_cod"));
        public IWebElement RegularBankTransferCheckBox => _driver.FindElement(By.Id("payment_method_bacs"));
        public IWebElement TPayTransferCheckbox => _driver.FindElement(By.Id("payment_method_transferuj"));
        public IList<IWebElement> TPayBanksTable => _driver.FindElements(By.XPath("//div[@id='bank-selection-form']"));
        public IWebElement TPayAcceptTermsCheckbox => _driver.FindElement(By.XPath("//label[@class='tpay-info-label']"));
        public IWebElement PaypalCheckbox => _driver.FindElement(By.Id("payment_method_paypal"));
        public IWebElement AcceptTermsCheckbox => _driver.FindElement(By.Id("terms"));
        public IWebElement SummaryButton => _driver.FindElement(By.Id("place_order"));
        public IList<IWebElement> ErrorLabels => _driver.FindElements(By.XPath("//ul[@class='woocommerce-error']"));
    }
}

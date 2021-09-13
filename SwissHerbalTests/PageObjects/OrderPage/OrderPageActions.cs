using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwissHerbalTests.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissHerbalTests.PageObjects.OrderPage
{
    public class OrderPageActions : OrderPageLocators
    {
        IWebDriver _driver;

        public OrderPageActions(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void AcceptCookiesButtonClick()
        {
            AcceptCookieButton.Text.Should().Be("Rozumiem. Zamknij.");
            AcceptCookieButton.Click();
        }

        public void ClickForLogInButtonClick()
        {
            ClickForLogInButton.Displayed.Should().BeTrue();
            ClickForLogInButton.Click();
        }

        public void UserLoginTextboxInput(string userLogin)
        {
            UserLogin.Displayed.Should().BeTrue();
            UserLogin.Click();
            UserLogin.SendKeys(userLogin);
        }

        public void UserPasswordTextboxInput(string userPassword)
        {
            UserPassword.Displayed.Should().BeTrue();
            UserPassword.Click();
            UserPassword.SendKeys(userPassword);
        }

        public void RememberMeCheckBoxChecked()
        {
            RememberMeCheckbox.Displayed.Should().BeTrue();
            RememberMeCheckbox.Click();
        }

        public void LogInButtonClick()
        {
            LogInButton.Displayed.Should().BeTrue();
            LogInButton.Click();
        }

        public void ClickForAddCouponButtonClick()
        {
            ClickForAddCouponButton.Displayed.Should().BeTrue();
            ClickForAddCouponButton.Click();
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

        public void BillingFirstNameInput(string firstName)
        {
            BillingFirstName.Displayed.Should().BeTrue();
            BillingFirstName.Click();
            BillingFirstName.SendKeys(firstName);
        }

        public void BillingSurnameInput(string surname)
        {
            BillingSurname.Displayed.Should().BeTrue();
            BillingSurname.Click();
            BillingSurname.SendKeys(surname);
        }

        public void BillingCompanyInput(string company)
        {
            BillingCompany.Displayed.Should().BeTrue();
            BillingCompany.Click();
            BillingCompany.SendKeys(company);
        }

        public void BillingEmailInput(string email)
        {
            BillingEmail.Displayed.Should().BeTrue();
            BillingEmail.Click();
            BillingEmail.SendKeys(email);
        }

        public void BillingPhoneInut(string phoneNumber)
        {
            BillingPhone.Displayed.Should().BeTrue();
            BillingPhone.Click();
            BillingPhone.SendKeys(phoneNumber);
        }

        public void SelectBillingCountry(string value)
        {
            BillingCountryDropdown.Displayed.Should().BeTrue();
            BillingCountryDropdown.Click();
            SelectElement dropdown = new SelectElement(BillingCountryDropdown);
            dropdown.SelectByValue(value);
        }

        public void BillingStreetAddressInput(string streetAddress)
        {
            BillingStreetAddress.Displayed.Should().BeTrue();
            BillingStreetAddress.Click();
            BillingStreetAddress.SendKeys(streetAddress);
        }

        public void BillingHouseNumberInput(string houseNumber)
        {
            BillingHouseNumber.Displayed.Should().BeTrue();
            BillingHouseNumber.Click();
            BillingHouseNumber.SendKeys(houseNumber);
        }

        public void BillingCityInput(string city)
        {
            BillingCity.Displayed.Should().BeTrue();
            BillingCity.Click();
            BillingCity.SendKeys(city);
        }

        public void BillingPostcodeInput(string postcode)
        {
            BillingPostcode.Displayed.Should().BeTrue();
            BillingPostcode.Click();
            BillingPostcode.SendKeys(postcode);
        }

        public void BillingNipInput(string nip)
        {
            BillingNip.Displayed.Should().BeTrue();
            BillingNip.Click();
            BillingNip.SendKeys(nip);
        }

        public void CreateAccountCheckboxChecked()
        {
            CreateAccountCheckbox.Displayed.Should().BeTrue();
            CreateAccountCheckbox.Click();
        }

        public void AccountUsernameInput(string username)
        {
            AccountUsername.Displayed.Should().BeTrue();
            AccountUsername.Click();
            AccountUsername.SendKeys(username);
        }

        public void AccountUserPasswordInput(string userPassword)
        {
            AccountPassword.Displayed.Should().BeTrue();
            AccountPassword.Click();
            AccountPassword.SendKeys(userPassword);
        }

        public void ShipToDifferentAddressCheckboxChecked()
        {
            ShipToDifferentAddressCheckbox.Displayed.Should().BeTrue();
            ShipToDifferentAddressCheckbox.Click();
        }

        public void ShippingFirstNameInput(string firstName)
        {
            ShippingFirstName.Displayed.Should().BeTrue();
            ShippingFirstName.Click();
            ShippingFirstName.SendKeys(firstName);
        }

        public void ShippingSurnameInput(string surname)
        {
            ShippingSurname.Displayed.Should().BeTrue();
            ShippingSurname.Click();
            ShippingSurname.SendKeys(surname);
        }

        public void ShippingCompanyInput(string company)
        {
            ShippingCompany.Displayed.Should().BeTrue();
            ShippingCompany.Click();
            ShippingCompany.SendKeys(company);
        }

        public void SelectShippingCountry(string value)
        {
            ShippingCountryDropdown.Displayed.Should().BeTrue();
            ShippingCountryDropdown.Click();
            SelectElement dropdown = new SelectElement(ShippingCountryDropdown);
            dropdown.SelectByValue(value);
        }

        public void ShippingStreetAddressInput(string streetAddress)
        {
            ShippingStreetAddress.Displayed.Should().BeTrue();
            ShippingStreetAddress.Click();
            ShippingStreetAddress.SendKeys(streetAddress);
        }

        public void ShippingHouseNumberInput(string houseNumber)
        {
            ShippingHouseNumber.Displayed.Should().BeTrue();
            ShippingHouseNumber.Click();
            ShippingHouseNumber.SendKeys(houseNumber);
        }

        public void ShippingCityInput(string city)
        {
            ShippingCity.Displayed.Should().BeTrue();
            ShippingCity.Click();
            ShippingCity.SendKeys(city);
        }

        public void ShippingPostcodeInput(string postcode)
        {
            ShippingPostcode.Displayed.Should().BeTrue();
            ShippingPostcode.Click();
            ShippingPostcode.SendKeys(postcode);
        }

        public void OrderCommentsInput(string comment)
        {
            OrderComments.Displayed.Should().BeTrue();
            OrderComments.Click();
            OrderComments.SendKeys(comment);
        }

        public void CashOnDeliveryCheckboxChecked()
        {
            CashOnDeliveryCheckbox.Displayed.Should().BeTrue();
            CashOnDeliveryCheckbox.Click();
        }

        public void RegularBankTransferCheckboxChecked()
        {
            RegularBankTransferCheckBox.Displayed.Should().BeTrue();
            RegularBankTransferCheckBox.Click();
        }

        public void TPayTransferCheckboxChecked()
        {
            TPayTransferCheckbox.Displayed.Should().BeTrue();
            TPayTransferCheckbox.Click();
        }

        //TODO TPAY TABLE HANDLER
        
        public void TPayAcceptTermsCheckboxChecked()
        {
            TPayAcceptTermsCheckbox.Displayed.Should().BeTrue();
            TPayAcceptTermsCheckbox.Click();
        }

        public void PayPalCheckboxChecked()
        {
            PayPalCheckbox.Displayed.Should().BeTrue();
            PayPalCheckbox.Click();
        }

        public void AcceptTermsCheckboxChecked()
        {
            AcceptTermsCheckbox.Displayed.Should().BeTrue();
            AcceptTermsCheckbox.Click();
        }

        public void SummaryButtonClick()
        {
            SummaryButton.Displayed.Should().BeTrue();
            SummaryButton.Click();
        }

        public void CheckAllErrorLabels()
        {
            WaitForAction.WaitUntilElementVisible(_driver, By.XPath("//ul[@class='woocommerce-error']"));
            foreach (var label in ErrorLabels)
            {
                label.Displayed.Should().BeTrue();
            }
        }

        public void CheckEmailFormatErrorLabel()
        {
            //TODO
            WaitForAction.WaitUntilElementVisible(_driver, By.XPath("//ul[@class='woocommerce-error']"));
            IWebElement emailErrorLabel = (IWebElement)ErrorLabels.Select(item => item.Text.Contains("Nieprawidłowy adres e-mail płatności"));
            emailErrorLabel.Displayed.Should().BeTrue();
        }
    }
}

using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.PageObjects.ItemPage
{
    public class ItemPageActions : ItemPageLocators
    {
        IWebDriver _driver;

        public ItemPageActions(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void OpenGivenPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Url.Should().Be(url);
        }

        public void OpenRandomAvailableProductPage()
        {
            _driver.Navigate().GoToUrl("https://pl.swissherbal.eu/sklep/noopeptil/");
        }

        public void OpenRandomUnavailableProductPage()
        {
            _driver.Navigate().GoToUrl("https://pl.swissherbal.eu/sklep/comfortil-max/");
        }

        public void AcceptCookiesButtonClick()
        {
            AcceptCookieButton.Text.Should().Be("Rozumiem. Zamknij.");
            AcceptCookieButton.Click();
        }

        public void ItemCounterFieldOperations(string value)
        {
            ItemCounterField.Displayed.Should().BeTrue();
            ItemCounterField.Clear();
            ItemCounterField.SendKeys(value);
            //ItemCounterField.Text.Should().Be(value);
        }

        public void SelectPackageFieldClick()
        {
            SelectPackageField.Click();
        }

        public void ClearPackageOptionButtonClick()
        {
            ClearPackageOptionButton.Displayed.Should().BeTrue();
            ClearPackageOptionButton.Click();
        }

        public void SelectPackageWithoutChoosenOption()
        {
            SelectPackageOption.Click();
            SelectElement dropdown = new SelectElement(SelectPackageField);
            dropdown.SelectByValue("");
            //SelectPackageField.Text.Should().Be("WYBIERZ OPCJĘ");
        }

        public void SelectPackageWith30Capsules()
        {
            SelectPackageOption.Click();
            SelectElement dropdown = new SelectElement(SelectPackageField);
            dropdown.SelectByValue("30-kapsulek");
        }

        public void SelectPackageWith60Capsules()
        {
            SelectPackageOption.Click();
            SelectElement dropdown = new SelectElement(SelectPackageField);
            dropdown.SelectByValue("60-kapsulek");
        }

        public void AddThisItemToShoppingBasketButtonClick()
        {
            AddThisItemToShoppingBasketButton.Displayed.Should().BeTrue();
            AddThisItemToShoppingBasketButton.Text.Should().Be("DODAJ DO KOSZYKA");
            AddThisItemToShoppingBasketButton.Click();
        }

        public void AddThisItemWithoutSelectedOptionToShoppingBasketButtonClick()
        {
            AddThisItemWithoutSelectedOptionToShoppingBasketButton.Displayed.Should().BeTrue();
            AddThisItemWithoutSelectedOptionToShoppingBasketButton.Text.Should().Be("DODAJ DO KOSZYKA");
            AddThisItemWithoutSelectedOptionToShoppingBasketButton.Click();
        }

        public void AddThisUnavailableItemToShoppingBasketButtonClick()
        {
            AddThisUnavailableItemToShoppingBasketButton.Displayed.Should().BeTrue();
            AddThisUnavailableItemToShoppingBasketButton.Text.Should().Be("DODAJ DO KOSZYKA");
            AddThisUnavailableItemToShoppingBasketButton.Click();
        }

        public void CheckAddItemLabelText()
        {
            AddedItemLabel.Displayed.Should().BeTrue();
            AddedItemLabel.Text.Should().Contain("został dodany do koszyka.");
        }

        public void CheckOutOfStockItemLabel()
        {
            OutOfStockLabel.Displayed.Should().BeTrue();
            OutOfStockLabel.Text.Should().Be("Brak w magazynie");
        }

        public void CheckTemporaryMissingLabel()
        {
            TemporaryMissingLaber.Text.Should().Be("Chwilowo brak");
        }

        public void AddToWaitingListButtonClick()
        {
            AddToWaitingListButton.Displayed.Should().Be(true);
            AddToWaitingListButton.Click();
            AddToWaitingListModal.Displayed.Should().Be(true);
        }

        public void AddToWaitingListModalEmail(string email)
        {
            AddToWaitingListModalEmailTextbox.Click();
            AddToWaitingListModalEmailTextbox.SendKeys(email);
        }

        public void CheckModalEmptyEmailErrorLabel()
        {
            ModalEmptyEmailErrorLabel.Displayed.Should().BeTrue();
            ModalEmptyEmailErrorLabel.Text.Should().Be("Email address cannot be empty.");
        }

        public void AddToWaitingListModalNotificationButtonClick()
        {
            AddToWaitingListModalNotificationButton.Click();
        }

        public void AcceptOptionAlertButton()
        {
            OptionAlert.Text.Should().Be("Wybierz opcje produktu przed dodaniem go do koszyka.");
            OptionAlert.Accept();
        }

        public void AcceptOutOfStockAlertButton()
        {
            OutOfStockAlert.Text.Should().Be("Przepraszamy, ten produkt jest niedostępny. Prosimy wybrać inną kombinację.");
            OutOfStockAlert.Accept();
        }
    }
}

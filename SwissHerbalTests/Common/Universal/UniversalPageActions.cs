using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.Common.Universal
{
    public class UniversalPageActions : UniversalPageLocators
    {
        private IWebDriver _driver;

        public UniversalPageActions(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void OpenGivenPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Url.Should().Be(url);
        }

        public void OpenMyAccountPage()
        {
            MyAccountButton.Displayed.Should().BeTrue();
            MyAccountButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/moje-konto/");
        }

        public void OpenBasketPage()
        {
            BasketButton.Displayed.Should().BeTrue();
            BasketButton.Click();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/koszyk/");
        }

        public void OpenOrderPage()
        {
            OrderButton.Displayed.Should().BeTrue();
            OrderButton.Click();
        }

        public void SuplementsTabHover()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(SuplementsTab).Perform();
            actions.MoveToElement(SuplementsTabSubMenu).Perform();
            actions.Click().Build().Perform();
            _driver.Url.Should().Be("https://pl.swissherbal.eu/kategoria-produktu/energia/");
        }

        public void AcceptCookieButtonClick()
        {
            AcceptCookieButton.Displayed.Should().BeTrue();
            AcceptCookieButton.Click();
        }

    }
}

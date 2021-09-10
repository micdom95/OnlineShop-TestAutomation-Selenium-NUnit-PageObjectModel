using FluentAssertions;
using OpenQA.Selenium;
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

        public void AcceptCookieButtonClick()
        {
            AcceptCookieButton.Displayed.Should().BeTrue();
            AcceptCookieButton.Click();
        }
    }
}

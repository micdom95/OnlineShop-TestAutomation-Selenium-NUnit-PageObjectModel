using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
    }
}

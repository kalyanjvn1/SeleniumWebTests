using System.Collections.Generic;
using OpenQA.Selenium;

namespace Web.Test.Selenium.PageObjects
{
    public partial class CheckOut : PageObject
    {
        public CheckOut(SeleniumTestBase testBase) : base(testBase)
        { }
        
        private readonly By checkOutSubTotal = By.CssSelector(".yourtotal>.pricedisplay");
        private readonly By iPhone4s = By.PartialLinkText("Apple iPhone 4S 16GB SIM-Free - Black");
        private readonly By quantity = By.Name("quantity");
        private readonly By total = By.CssSelector(".wpsc_product_price.wpsc_product_price_0>.pricedisplay");
        private readonly By continueButton = By.ClassName("step2");
        private readonly By checkOut = By.ClassName("entry-title");

        private readonly By firstName = By.Id("wpsc_checkout_form_2");
        private readonly By lastName = By.Id("wpsc_checkout_form_3");
        private readonly By address = By.Id("wpsc_checkout_form_4");
        private readonly By city = By.Id("wpsc_checkout_form_5");
        private readonly By country = By.Id("wpsc_checkout_form_7");
        private readonly By postalCode = By.Id("wpsc_checkout_form_8");
        private readonly By phone = By.Id("wpsc_checkout_form_18");
        private readonly By email = By.Id("wpsc_checkout_form_9");
        private readonly By priceDisplay = By.CssSelector(".pricedisplay.checkout-shipping>.pricedisplay");
        private readonly By totalCheckOutPrice = By.Id("checkout_total");
        private readonly By submit = By.Name("submit");
        private readonly By purchaseTransactionLog = By.CssSelector(".wpsc-purchase-log-transaction-results");
        

        
        
        public IWebElement CheckOutSubTotal 
        {
            get { return driver.FindElement(checkOutSubTotal); }
        }

        public IWebElement IphoneName 
        {
            get { return driver.FindElement(iPhone4s); }
        }

        public IWebElement Quantity 
        {
            get { return driver.FindElement(quantity); }
        }

        public IWebElement Total
        {
            get { return driver.FindElement(total); }
        }

        public IWebElement ContinueButton
        {
            get { return driver.FindElement(continueButton); }
        }

        public IWebElement CheckOutLabel
        {
            get { return driver.FindElement(checkOut); }
        }

        public IWebElement FirstName
        {
            get { return driver.FindElement(firstName); }
        }

        public IWebElement LastName
        {
            get { return driver.FindElement(lastName); }
        }

        public IWebElement Address
        {
            get { return driver.FindElement(address); }
        }

        public IWebElement City
        {
            get { return driver.FindElement(city); }
        }

        public IWebElement Country
        {
            get { return driver.FindElement(country); }
        }

        public IWebElement PostalCode
        {
            get { return driver.FindElement(postalCode); }
        }

        public IWebElement Phone
        {
            get { return driver.FindElement(phone); }
        }
        public IWebElement Email
        {
            get { return driver.FindElement(email); }
        }

        public IReadOnlyCollection<IWebElement> PriceDisplay
        {
            get { return driver.FindElements(priceDisplay); }
        }
        public IWebElement TotalPrice
        {
            get { return driver.FindElement(totalCheckOutPrice); }
        }

        public IWebElement SubmitButton
        {
            get { return driver.FindElement(submit); }
        }

        public IWebElement PurchaseTransactionLog
        {
            get { return driver.FindElement(purchaseTransactionLog); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Web.Test.Selenium.PageObjects
{
    public partial class Phone : PageObject
    {
        public Phone(SeleniumTestBase testBase) : base(testBase)
        { }

        private readonly By iPhoneProducts = By.ClassName("wpsc_product_title");
        private readonly By iPhone4sLink = By.PartialLinkText("Apple iPhone 4S 16GB SIM-Free – Black");
        private readonly By addToCart = By.ClassName("wpsc_buy_button");
        private readonly By currentPrice = By.CssSelector(".currentprice.pricedisplay.product_price_96");
        private readonly By productName = By.ClassName("prodtitle");
        private readonly By notificationPopup = By.Id("fancy_notification_content");
        private readonly By checkOut = By.PartialLinkText("Go to Checkout");
        

        public IWebElement IPhone4s
        { 
            get { return driver.FindElement(iPhone4sLink); } 
        }

        public IWebElement CurrentPrice 
        {
            get { return driver.FindElement(currentPrice); }
        }

        public IWebElement AddToCartButton 
        {
            get { return driver.FindElement(addToCart); }
        }

        public IWebElement ProductNameText
        {
            get { return driver.FindElement(productName); }
        }

        public IWebElement CheckOutButton
        {
            get { return driver.FindElement(checkOut); }
        }
    }
}

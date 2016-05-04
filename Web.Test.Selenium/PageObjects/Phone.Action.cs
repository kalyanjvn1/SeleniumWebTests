using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Web.Test.Selenium.PageObjects
{
    public partial class Phone
    {
        public Phone NavigateToIphone4sBlack()
        {
            IPhone4s.Click();
            DoPageTransition();
            return this;
        }

        public Phone AddToCart()
        {
            AddToCartButton.Click();
            return this;
  
        }

        public Phone VerifyProductName(string expectedProductName)
        {
            string actualProductName = ProductNameText.Text;
            Assert.AreEqual(expectedProductName, actualProductName, "Product Name did not matched.");
            return this;
        }

        public Phone NavigateToCheckOut()
        {
            string currentPriceInCart = CurrentPrice.Text;
            IWebElement element = driver.FindElement(By.ClassName("wpsc_buy_button"));
            AddToCartButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, controlTimeOut);
            wait.Until((d) => driver.FindElement(notificationPopup).Displayed);
            CheckOutButton.Click();
            DoPageTransition();
            return this;
        }
    }
}

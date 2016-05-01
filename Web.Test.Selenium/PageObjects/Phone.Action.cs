using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void NavigateToCheckOut()
        {
            // Get the current window handle so you can switch back later.
            string currentHandle = driver.CurrentWindowHandle;

            // Find the element that triggers the popup when clicked on.
            IWebElement element = driver.FindElement(By.ClassName("wpsc_buy_button"));

            // The Click method of the PopupWindowFinder class will click
            // the desired element, wait for the popup to appear, and return
            // the window handle to the popped-up browser window. Note that
            // you still need to switch to the window to manipulate the page
            // displayed by the popup window.
            PopupWindowFinder finder = new PopupWindowFinder(driver,TimeSpan.FromSeconds(45));
            string popupWindowHandle = finder.Click(element);

            driver.SwitchTo().Window(popupWindowHandle);

            //WebDriverWait wait = new WebDriverWait(driver, controlTimeOut);
            //wait.Until((d) => d.FindElement(checkOut).Displayed);
            CheckOutButton.Click();
        }
    }
}

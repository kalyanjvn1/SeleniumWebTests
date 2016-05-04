using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Web.Test.Selenium.PageObjects
{
    public partial class CheckOut
    {
        public CheckOut VerifyProductQuantityAndTotalInCheckout(string expectedProductName,string expectedQuantity,string expectedSubTotal,string expectedTotal)
        {
            Assert.AreEqual(expectedProductName,IphoneName.Text,"Iphone 4s black product name is did not matched.");
            Assert.AreEqual(expectedQuantity, Quantity.GetAttribute("value"), "Quantity for the product at the checkout did not matched.");
            Assert.AreEqual(expectedSubTotal, CheckOutSubTotal.Text , "SubTotal at the checkout did not matched.");
            Assert.AreEqual(expectedTotal, Total.Text, "Total at the checkout did not matched.");
            ContinueButton.Click();
            DoPageTransition();
            return this;
        }

        public CheckOut EnterBillingDetails()
        {
            Email.SendKeys("testemail@gmail.com");
            FirstName.SendKeys("Kalyan");
            LastName.SendKeys("JVN");
            Address.SendKeys("1001 Richmond Ave ");
            City.SendKeys("Houston");
            Country.SendKeys("USA");
            PostalCode.SendKeys("77042");
            Phone.SendKeys("0123456789");
            
            return this;
        }

        public void ReviewPurchaseItems(string expectedShippingFee,string expectedItemCost,string expectedTotalPrice)
        {
            Assert.AreEqual(expectedShippingFee, PriceDisplay.ElementAt(0).Text,"Total Shipping fee did not matched.");
            Assert.AreEqual(expectedItemCost, PriceDisplay.ElementAt(1).Text, "Item Cost did not matched.");
            Assert.AreEqual(expectedTotalPrice, TotalPrice.Text, "Total Price did not matched.");
            Phone.SendKeys(Keys.Enter);
//            SubmitButton.Click();
            DoPageTransition();
            Assert.IsTrue(PurchaseTransactionLog.Displayed,"Transaction page is not displayed");
        }
    }
}

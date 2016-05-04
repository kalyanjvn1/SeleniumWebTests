using NUnit.Framework;
using Web.Test.Selenium.PageObjects;

namespace Web.Test.Selenium
{
    [TestFixture]
    public class OnlineStoreTests : SeleniumTestBase
    {
        [Test(Description = "Submit an order for an Apple iPhone4s 16GB SIM-Free – Black")]
        public void SubmitOrder()
        {
            string productName = "Apple iPhone 4S 16GB SIM-Free – Black";
            string productNameAtCheckout = "Apple iPhone 4S 16GB SIM-Free - Black";
            string quantity = "1";
            string subTotalAtCheckout = "$270.00";
            string totalAtCheckout = "$270.00";
            string shippingFee = "$10.00";
            string totalPrice = "$280.00";
            new HomePage(this).EnterSearchTest("IPhone 4s");

            new Phone(this).NavigateToIphone4sBlack()
                           .VerifyProductName(productName)
                            .NavigateToCheckOut();
            new CheckOut(this).VerifyProductQuantityAndTotalInCheckout(productNameAtCheckout, quantity, subTotalAtCheckout, totalAtCheckout)
                              .EnterBillingDetails()
                              .ReviewPurchaseItems(shippingFee, subTotalAtCheckout, totalPrice);                            
        }




        [SetUp]
        public override void TestSetUp()
        {
            IntialiseWebDriver();
        }

        [TearDown]
        public override void TestCleanUp()
        {
            CleanUp();
        }
               

    }

   
}

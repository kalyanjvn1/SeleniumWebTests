using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            new HomePage(this).EnterSearchTest("IPhone 4s");

            new Phone(this).NavigateToIphone4sBlack()
                           .VerifyProductName(productName)
                            .NavigateToCheckOut();
           

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

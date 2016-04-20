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
    public class OnlineStoreTests
    {
        [Test]
        public void SubmitOrder()
        {
           string productCategoryTitle =  new HomePage().NavigateToHomePage()
                          .SelectProductCategory();
            Assert.AreEqual("Product Category | ONLINE STORE",productCategoryTitle,"Product Category Title did not match.");
        }

               

    }

   
}

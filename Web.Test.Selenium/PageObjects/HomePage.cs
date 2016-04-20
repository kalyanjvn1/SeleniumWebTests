using OpenQA.Selenium;

namespace Web.Test.Selenium.PageObjects 
{
    public partial class HomePage : SeleniumTestBase
    {
        private readonly By productCategory = By.CssSelector("#menu-item-33>a");
        private readonly By iPad =  By.CssSelector("#menu-item-36>a");


        public IWebElement ProductCategoryMenu
        {
            get { return WebDriver.FindElement(productCategory); }
        }

        public IWebElement IPadMenu 
        {
            get { return WebDriver.FindElement(iPad); }
        }

    }
}

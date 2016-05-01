using OpenQA.Selenium;

namespace Web.Test.Selenium.PageObjects 
{
    public partial class HomePage : PageObject
    {
        public HomePage(SeleniumTestBase automationBase) : base(automationBase)
        { }
        
        private readonly By productCategory = By.CssSelector("#menu-item-33>a");
        private readonly By iPad =  By.CssSelector("#menu-item-36>a");
        private readonly By search = By.ClassName("search");


        public IWebElement ProductCategoryMenu
        {
            get { return driver.FindElement(productCategory); }
        }

        public IWebElement IPadMenu 
        {
            get { return driver.FindElement(iPad); }
        }

        public IWebElement SearchTextBox
        {
            get { return driver.FindElement(search); }
        }

    }
}

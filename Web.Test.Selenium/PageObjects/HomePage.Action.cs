using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Web.Test.Selenium.PageObjects
{
    public partial class HomePage
    {
        
        public HomePage NavigateToHomePage()
        {
            WebDriver.Navigate().GoToUrl(this.BaseAddress);
            WebDriver.Manage().Window.Maximize();
            return this;
        }

        public string SelectProductCategory()
        {
            ProductCategoryMenu.Click();
            WebDriverWait wait = new WebDriverWait(WebDriver, this.TimeOut);
            wait.Until(ExpectedConditions.TitleContains("Product Category"));
            return WebDriver.Title;
        }

        
    }
}

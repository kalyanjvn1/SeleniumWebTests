using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Web.Test.Selenium.PageObjects
{
    public partial class HomePage
    {
        
        
        public string SelectProductCategory()
        {
            ProductCategoryMenu.Click();
            WebDriverWait wait = new WebDriverWait(driver,controlTimeOut);
            wait.Until(ExpectedConditions.TitleContains("Product Category"));
            return driver.Title;
        }

        public HomePage EnterSearchTest(string product)
        {
            SearchTextBox.SendKeys(product);
            SearchTextBox.SendKeys(Keys.Enter);
            DoPageTransition();
            return this;
        }

        
    }
}

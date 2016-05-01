using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Web.Test.Selenium
{
    public class PageObject
    {
        public SeleniumTestBase seleniumTestBaseInstance { get; set; }
        public IWebDriver driver { get; set; }

        public TimeSpan controlTimeOut { get; set; } 

        public PageObject(SeleniumTestBase testBase)
        {
            seleniumTestBaseInstance = testBase;
            driver = seleniumTestBaseInstance.WebDriver;
            controlTimeOut = seleniumTestBaseInstance.TimeOut;
        }

        public void DoPageTransition()
        {
            WebDriverWait wait = new WebDriverWait(driver, controlTimeOut);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Func<IWebDriver, bool> readyCondition = webdriver => (bool)js.ExecuteScript("return (document.readyState == 'complete' && jQuery.active == 0)");
            wait.Until(readyCondition);
        }
    }
}

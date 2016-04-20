using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;


namespace Web.Test.Selenium
{
    public abstract class SeleniumTestBase
    {
        public IWebDriver WebDriver { get; set; }

        public SeleniumTestBase()
        {
            WebDriver = new FirefoxDriver();
        }

        public string BaseAddress 
        {
            get { return "http://store.demoqa.com/"; }
        }

        private TimeSpan _timeout;
        public TimeSpan TimeOut 
        {
            get { return _timeout; }
            set { _timeout = TimeSpan.FromSeconds(45); }
        }

        public void TestCleanUp()
        {
            if(WebDriver !=null)
            {
               WebDriver.Quit();
            }
            
        }
        
    }
}

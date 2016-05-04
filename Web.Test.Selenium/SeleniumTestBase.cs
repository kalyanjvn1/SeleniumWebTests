using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;



namespace Web.Test.Selenium
{
    public abstract class SeleniumTestBase
    {
        public IWebDriver WebDriver { get; set; }

        public SeleniumTestBase()
        {
            
        }

        public void IntialiseWebDriver()
        {
            //WebDriver = new FirefoxDriver();
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(1));
            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(45));
            WebDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromMinutes(1));
            WebDriver.Navigate().GoToUrl(BaseAddress);
            WebDriver.Manage().Window.Maximize();
            WaitForPageLoad();
        }

        public abstract void TestSetUp();
        public abstract void TestCleanUp();

        public void CleanUp()
        {
            if (WebDriver != null)
            {
                WebDriver.Quit();
            }
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

        public void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver,TimeOut);

            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver;
            Func<IWebDriver, bool> readyCondition = webdriver => (bool) js.ExecuteScript("return (document.readyState == 'complete' && jQuery.active == 0)");
            wait.Until(readyCondition);
        }

       
        
    }
}

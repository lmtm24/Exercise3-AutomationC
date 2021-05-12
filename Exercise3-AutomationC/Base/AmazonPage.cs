using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3_AutomationC.Base
{
    public class AmazonPage
    {
        protected static AmazonBrowser browser;
        protected static IWebDriver driver;
        
              
        public void InitPages()
        {
            PageFactory.InitElements(driver, this);
        }

        public void SetUpBrowser()
        {
            browser = new AmazonBrowser();
            driver = browser.CreateBrowser(AmazonBrowser.Browser.Chrome);
            browser.GoTo();
        }
    }
}

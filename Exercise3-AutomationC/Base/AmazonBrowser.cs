using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

namespace Exercise3_AutomationC.Base
{
    public class AmazonBrowser
    {
                
        public enum Browser
        {
            Chrome
        }

        public IWebDriver CreateBrowser(Browser browser)
        {
            var appSettings = ConfigurationManager.AppSettings["URL"];
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driver.Navigate().GoToUrl("http://www.amazon.com.mx");
           // driver.Navigate().GoToUrl(appSettings);
            // Console.WriteLine(url);
          // driver.Url = appSettings;
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();            
        }

        public void SendKeys(IWebElement element,String text)
        {
            element.SendKeys(text);

        }

    }
}

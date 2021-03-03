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
        private static String url = ConfigurationManager.AppSettings["URL"];
        public enum Browser
        {
            Chrome
        }

        public IWebDriver CreateBrowser(Browser browser)
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            //driver.Navigate().GoToUrl(url);
            Console.WriteLine(url);
            driver.Url = url;
            return driver;
        }


        public void Click(IWebElement element)
        {
            element.Click();
            
        }

    }
}

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

        IWebDriver driver;
        public enum Browser
        {
            Chrome
        }

        public IWebDriver CreateBrowser(Browser browser)
        {
            //var appSettings = ConfigurationManager.AppSettings["URL"];
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);            
            return driver;
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com.mx/");
        }

        public void Click(IWebElement element)
        {
            element.Click();            
        }

        public void SendKeys(IWebElement element,String text)
        {
            element.SendKeys(text);          

        }

        public void SendKeysEnter(IWebElement element, String text)
        {
            element.SendKeys(text);
            element.SendKeys(Keys.Enter);

        }

        public String GetText(IWebElement element)
        {
            String text = element.Text;
            return text;
        }

    }
}

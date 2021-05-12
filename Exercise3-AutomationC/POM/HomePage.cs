using Exercise3_AutomationC.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3_AutomationC.POM
{
    public class HomePage : AmazonPage
    {
        [FindsBy(How = How.XPath, Using = "//a[@id='nav-link-accountList']/span[@class='nav-line-2 nav-long-width']")]
        private IWebElement Identificate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='nav-signin-tooltip']//span[@class='nav-action-inner']")]        
        private IWebElement Identificarse { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#twotabsearchtextbox")]
        private IWebElement SearchField { get; set; }


        public HomePage() : base()
    {
            SetUpBrowser();
            InitPages();
    }    
  
    public HomePage ClickIdentficate()
    {
            browser.Click(Identificate);
            return this;
    }
        public HomePage ClickIdentficarse()
        {
            browser.Click(Identificarse);
            return this;
        }

        public HomePage SearchProduct(String text)
        {
            browser.SendKeysEnter(SearchField, text);            
            return this;
        }



    }
}

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
        private IWebElement identificate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='nav-signin-tooltip']//span[@class='nav-action-inner']")]        
        private IWebElement identificarse { get; set; }
        //div[@id='nav-signin-tooltip']//span[@class='nav-action-inner']


        public HomePage() : base()
    {

    }
    
    public HomePage InitBrowser()
        {
            StartAmazonBrowser();
            return this;
        }

    public HomePage ClickIdentficate()
    {
            browser.Click(identificate);
            return this;
    }
        public HomePage ClickIdentficarse()
        {
            browser.Click(identificate);
            return this;
        }



    }
}

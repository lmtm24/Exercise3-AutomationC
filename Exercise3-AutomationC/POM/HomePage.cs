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
        private IWebElement logInButton { get; set; }
    
    public HomePage() : base()
    {

    }
    public HomePage LogIn()
    {
            browser.Click(logInButton);
            return this;
    }

    }
}

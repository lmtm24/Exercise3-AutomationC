using Exercise3_AutomationC.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3_AutomationC.POM
{
    public class SignInPage : AmazonPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@type='email' and @name='email']")]
        private IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='continue' and @type='submit']")]
        private IWebElement continueButton { get; set; }
        

        public SignInPage() : base()
        {

        }
       
        
        public SignInPage SignIn(String text)
        {
            browser.SendKeys(email,text);
            return this;
        }

        public SignInPage ClickContinue()
        {
            browser.Click(continueButton);
            return this;
        }
    }
}

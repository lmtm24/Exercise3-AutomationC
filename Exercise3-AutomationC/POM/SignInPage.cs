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
        private IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='continue' and @type='submit']")]
        private IWebElement ContinueButton { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        private IWebElement SignInButton { get; set; }
        



        public SignInPage() : base()
        {
            InitPages();
        }
       
        
        public SignInPage TypeEmail(String text)
        {
            browser.SendKeys(EmailField, text);
            return this;
        }

        public SignInPage ClickContinue()
        {
            browser.Click(ContinueButton);
            return this;
        }

        public SignInPage TypePassword(String text)
        {
            browser.SendKeys(PasswordField, text);
            return this;
        }

        public SignInPage ClickSigninButton()
        {
            browser.Click(SignInButton);
            return this;
        }


    }
}

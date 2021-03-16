using Exercise3_AutomationC.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3_AutomationC.TestCases
{
    [TestClass]
    public class TestCase
    {
        HomePage homePage;
        SignInPage signInPage;

        [TestInitialize]
        public void BeforeTest()
        {
            
            homePage = new HomePage();
            signInPage = new SignInPage();
        }

        [TestMethod]
        public void amazon_LoginValidation()
        {
            homePage.ClickIdentficate();
         // homePage.ClickIdentficarse();            
            signInPage.SignIn("lmtm24@gmail.com");
            signInPage.ClickContinue();

        }

    }
}

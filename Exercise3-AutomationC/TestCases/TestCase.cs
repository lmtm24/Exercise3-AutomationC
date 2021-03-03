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

        [TestInitialize]
        public void BeforeTest()
        {
            
            homePage = new HomePage();
        }

        [TestMethod]
        public void amazon_LoginValidation()
        {          
            homePage.LogIn();
        }

    }
}

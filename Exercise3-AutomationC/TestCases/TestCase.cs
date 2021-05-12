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
        ResultsPage resultsPage;
        CartPage cartPage;

        [TestInitialize]
        public void BeforeTest()
        {
            
            homePage = new HomePage();
            signInPage = new SignInPage();
            resultsPage = new ResultsPage();
            cartPage = new CartPage();
            
        }

        [TestMethod]
        public void amazon_LoginValidation()
        {
            String email = "";
            string pass = "";
            String product = "Samsung Galaxy S9 64GB";
            String AlienProduct = "Alienware AW2521HFL";
            homePage.ClickIdentficate();         
            signInPage.TypeEmail(email);
            signInPage.ClickContinue();
            signInPage.TypePassword(pass);
            signInPage.ClickSigninButton();
            homePage.SearchProduct(product);
            resultsPage.GetFisrPrice();            
            resultsPage.ClickSamsung();
            resultsPage.GetDetailPrice();
            resultsPage.ValidatePrices();
            resultsPage.AddToCart();
            resultsPage.ClickCarritoButton();
            cartPage.GetPrice();
            cartPage.ValidatePrices();
            cartPage.ValidateItems();            
            cartPage.SearchNewItem(AlienProduct);
            cartPage.AddToCart();
            cartPage.ValidateNewItems();




        }

    }
}

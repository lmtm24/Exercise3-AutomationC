using Exercise3_AutomationC.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise3_AutomationC.POM
{
    class CartPage : AmazonPage
    {
       
        String TotalPrice;
        [FindsBy(How = How.CssSelector, Using = "#sc-subtotal-amount-activecart .sc-white-space-nowrap")]
        private IWebElement price { get; set; }
        [FindsBy(How = How.CssSelector, Using = "span#nav-cart-count")]
        private IWebElement CartItems { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#twotabsearchtextbox")]
        private IWebElement SearchField { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='s-main-slot s-result-list s-search-results sg-row']//div[@data-index='0']")]
        private IWebElement AlienItem { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#add-to-cart-button")]
        private IWebElement Add { get; set; }

        public CartPage() : base()
        {            
            InitPages();
        }


        public String GetPrice()
        {
            TotalPrice= browser.GetText(price);                      
            return TotalPrice;            
        }

        public CartPage ValidatePrices()
        {

            var path = "output.txt";
            string content = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine("Reading File: "+content);
            Assert.IsTrue(content.Contains(TotalPrice));
            return this;
        }

        public CartPage ValidateItems()
        {
            String items = browser.GetText(CartItems);
            Console.WriteLine("Items:" + items);
            Assert.IsTrue(items.Equals("1"));
            return this;
        }

        public CartPage SearchNewItem (String text)
        {
            browser.SendKeysEnter(SearchField, text);
            browser.Click(AlienItem);
            return this;
        }

        public CartPage AddToCart()
        {
            browser.Click(Add);
            return this;
        }


        public CartPage ValidateNewItems()
        {
            String items = browser.GetText(CartItems);
            Console.WriteLine("Items:" + items);
            Assert.IsTrue(items.Equals("2"));
            return this;
        }

    }
}

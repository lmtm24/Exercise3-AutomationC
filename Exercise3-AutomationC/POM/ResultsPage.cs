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
    public class ResultsPage : AmazonPage
    {
        public String DtlPrice, FtPrice;
        [FindsBy(How = How.XPath, Using = "//div[@class='s-main-slot s-result-list s-search-results sg-row']//div[@data-index='0']")]
        private IWebElement FirstItem { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='s-main-slot s-result-list s-search-results sg-row']//div[@data-index='0']//span[@class='a-price-whole']")]
        private IWebElement FirstPriceHole { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='s-main-slot s-result-list s-search-results sg-row']//div[@data-index='0']//span[@class='a-price-fraction']")]
        private IWebElement FirstPriceFraction { get; set; }
        [FindsBy(How = How.CssSelector, Using = "span#priceblock_ourprice")]
        private IWebElement DetailPrice { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input#add-to-cart-button")]
        private IWebElement Add { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a#hlb-view-cart-announce")]
        private IWebElement Carrito { get; set; }







        public ResultsPage() : base()
        {
            InitPages();
        }

        public String GetFisrPrice()
        {
            String FtPriceH = browser.GetText(FirstPriceHole);
            String FtPriceF = browser.GetText(FirstPriceFraction);
            FtPrice = "$"+FtPriceH + "." + FtPriceF;
            Console.WriteLine("First:"+ FtPriceH +"."+ FtPriceF);
            File.WriteAllText("output.txt", FtPrice);
            return FtPrice;
            
        }

        public String GetDetailPrice()
        {
            DtlPrice = browser.GetText(DetailPrice);
            Console.WriteLine(DtlPrice);
            return DtlPrice;
            
        }

        public ResultsPage ClickSamsung()
        {
            browser.Click(FirstItem);
            return this;
        }

        public ResultsPage ValidatePrices()
        {
            Assert.IsTrue(FtPrice.Contains(DtlPrice));
            return this;
            
        }

        public ResultsPage AddToCart()
        {
            browser.Click(Add);
            return this;
        }

        public ResultsPage ClickCarritoButton()
        {
            browser.Click(Carrito);
            return this;
        }

        


    }
}

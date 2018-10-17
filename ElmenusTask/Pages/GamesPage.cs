using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using AutomationFramework.Base;

namespace AutomationFramework.Pages
{
    class GamesPage: BasePage
    {
        // Initialize page 
        public GamesPage(IWebDriver driver): base(driver)
        {
            

        }


        //Objects for the games page
        [FindsBy(How = How.XPath, Using = "//*[@id='main-menu']/div/a[2]")]
        public IWebElement GamesTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='price-range-slider']/span[2]")]
        public IWebElement RangeSlider { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='item-overview']/div[2]/ul/li[2]/div/img")]
        public IWebElement Seconditem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='126atc-21']")]
        public IWebElement AddToCartView { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='shopping-cart']/span[2]")]
        public IWebElement MenuHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='shopping-cart-items']/div/div")]
        public IWebElement MenuHeadertxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='item-overview']/div[2]/ul/li[1]/div/a")]
        public IWebElement FirstElement { get; set; }


    }
}

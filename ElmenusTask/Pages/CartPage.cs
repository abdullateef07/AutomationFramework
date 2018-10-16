using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace ElmenusTask.Pages
{
    class CartPage
    {
        public CartPage(IWebDriver driver)

        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='AddToCartForm']/div[6]/a")]
        public IWebElement AddToCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='shopping-cart']/span[2]")]
        public IWebElement CheckoutBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='continue-button']")]
        public IWebElement ContinueBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-account-area']/div[2]/div[2]/a")]
        public IWebElement GuestBtn { get; set; }

        
    }
}

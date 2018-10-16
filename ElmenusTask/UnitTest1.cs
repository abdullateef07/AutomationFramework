using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using AutomationFramework.Pages;
using OpenQA.Selenium.Interactions;
using System.Threading;
using ElmenusTask.Pages;

namespace ElmenusTask
{
    [TestClass]
    public class UnitTest1
    { String URL = "http://www.konakart.com/konakart/Welcome.action";
        IWebDriver driver;
        
        [TestMethod]
        public void TestMethod1()
        {   driver = new ChromeDriver(@"C:\Users\user-\Downloads\Compressed");
            driver.Navigate().GoToUrl(URL);

            scenario1();
            scenario2();
            scenario3();
        }

        public void scenario1()

        {
            GamesPage page = new GamesPage(driver);
            page.GamesTab.Click();
            // 
            Actions SliderAction = new Actions(driver);
            SliderAction.DragAndDropToOffset(page.RangeSlider, -50, 0).Perform();

            Actions CartAction = new Actions(driver);
            CartAction.MoveToElement(page.Seconditem).Perform();
            page.AddToCartView.Click();


            Actions ViewCart = new Actions(driver);
            ViewCart.MoveToElement(page.MenuHeader).Perform();
            Thread.Sleep(2000);
            Assert.IsTrue(page.MenuHeadertxt.Text.Contains("$79.99"));
            page.FirstElement.Click();
            Thread.Sleep(4000);

         

        }

        public void scenario2()
        {

            CartPage page2 = new CartPage(driver);
            page2.AddToCartBtn.Click();
            page2.CheckoutBtn.Click();
            page2.ContinueBtn.Click();
            page2.GuestBtn.Click();


        }

        public void scenario3()
        {
            DeliveryDetails page3 = new DeliveryDetails(driver);
            page3.GenderRbtn.Click();
            page3.firstNameF.SendKeys("Abdullateef");
            page3.lastNameF.SendKeys("Mamdouh");
            IJavaScriptExecutor Datepicker = (IJavaScriptExecutor)driver;
            Datepicker.ExecuteScript("document.getElementById('datepicker').value='10/01/1992'");
            page3.emailAddrF.SendKeys("cseabdo@gmail.com");
            page3.UserNameF.SendKeys("Abdo");
            page3.streetAddressF.SendKeys("805");
            page3.suburbF.SendKeys("Future city");
            page3.postcodeF.SendKeys("61111");
            page3.cityF.SendKeys("Egypt");
            var selectCountry = new SelectElement(page3.countryIdF);
            selectCountry.SelectByValue("63");
            page3.stateF.SendKeys("Egypt");
            page3.PrimaryTelephoneNumberF.SendKeys("0000");
            page3.OtherTelephoneNumberF.SendKeys("0000");
            page3.faxNumberF.SendKeys("0000");
            page3.continueBTN.Click();
        }
    }
}

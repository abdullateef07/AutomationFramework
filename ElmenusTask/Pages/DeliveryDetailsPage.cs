using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    class DeliveryDetails
    {       // Initialize page 
        public DeliveryDetails(IWebDriver driver)

        {
            PageFactory.InitElements(driver, this);
        }

        //Objects for the CartInfoPage page
        [FindsBy(How = How.XPath, Using = "//*[@id='form1']/div[1]/div[2]/div[2]/span[1]/input")]
        public IWebElement GenderRbtn { get; set; }

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement firstNameF { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement lastNameF { get; set; }

        [FindsBy(How = How.Id, Using = "emailAddr")]
        public IWebElement emailAddrF { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UserNameF { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement companyF { get; set; }

        [FindsBy(How = How.Id, Using = "streetAddress")]
        public IWebElement streetAddressF { get; set; }

        [FindsBy(How = How.Id, Using = "suburb")]
        public IWebElement suburbF { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement postcodeF { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement cityF { get; set; }

        [FindsBy(How = How.Id, Using = "state")]
        public IWebElement stateF { get; set; }

        [FindsBy(How = How.Id, Using = "countryId")]
        public IWebElement countryIdF { get; set; }

        [FindsBy(How = How.Id, Using = "telephoneNumber1")]
        public IWebElement OtherTelephoneNumberF { get; set; }

        [FindsBy(How = How.Id, Using = "telephoneNumber")]
        public IWebElement PrimaryTelephoneNumberF { get; set; }

        [FindsBy(How = How.Id, Using = "faxNumber")]
        public IWebElement faxNumberF { get; set; }

        [FindsBy(How = How.Id, Using = "continue-button")]
        public IWebElement continueBTN { get; set; }







    }
}

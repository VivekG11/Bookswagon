using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace BookswagonAutomation.Pages
{
    public class PlaceOrder
    {
        public PlaceOrder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/form[1]/div[4]/div[2]/div[3]/div[2]/div[1]/div[4]/div[5]/a[1]")]
        [CacheLookup]
        public IWebElement buynow;

        [FindsBy(How = How.XPath, Using = "BookCart_lvCart_ctrl0_imgDelete")]
        [CacheLookup]
        public IWebElement remove;

        [FindsBy(How = How.Name, Using = "BookCart$lvCart$ctrl0$txtQty")]
        [CacheLookup]
        public IWebElement quantity;

        [FindsBy(How = How.XPath, Using = "//*[@name='BookCart$lvCart$imgPayment'][@id='BookCart_lvCart_imgPayment']")]
        [CacheLookup]
        public IWebElement placeOrder;

        [FindsBy(How = How.ClassName, Using = "continue-button")]
        [CacheLookup]
        public IWebElement continuebtn;

        [FindsBy(How = How.ClassName, Using = "//*[text()='Sorry, Only ']")]
        [CacheLookup]
        public IWebElement warning;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewRecipientName")]
        [CacheLookup]
        public IWebElement name;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewCompanyName")]
        [CacheLookup]
        public IWebElement company;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewAddress")]
        [CacheLookup]
        public IWebElement street;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewLandmark")]
        [CacheLookup]
        public IWebElement landmark;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCountry")]
        [CacheLookup]
        public IWebElement country;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ddlNewState")]
        [CacheLookup]
        public IWebElement state;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCities")]
        [CacheLookup]
        public IWebElement city;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_txtNewPincode")]
        [CacheLookup]
        public IWebElement zipcode;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewMobile")]
        [CacheLookup]
        public IWebElement mobile;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewPhone")]
        [CacheLookup]
        public IWebElement phone;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$imgSaveNew")]
        [CacheLookup]
        public IWebElement save;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ShoppingCart$lvCart$savecontinue")]
        [CacheLookup]
        public IWebElement continues;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$btnCCAvenue")]
        [CacheLookup]
        public IWebElement payment ;


    }
}

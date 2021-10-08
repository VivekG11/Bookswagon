using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonAutomation.Pages
{
    public class Logout
    {
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/form[1]/div[4]/div[1]/div[1]/div[1]/div[4]/div[1]/ul[1]/li[1]/a[1]/span[1]")]
        [CacheLookup]
        public IWebElement Accbtn;

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        [CacheLookup]
        public IWebElement logoutbtn;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonAutomation.Pages
{
    public class LoginClass
    {
        public LoginClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "ctl00_imglogo")]
        [CacheLookup]
        public IWebElement logo;

        [FindsBy(How = How.XPath, Using = "//*[text()='Login']")]
        [CacheLookup]
        public IWebElement login;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtPassword")]
        [CacheLookup]
        public IWebElement pwd;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$btnLogin")]
        [CacheLookup]
        public IWebElement loginbtn;
    }
}

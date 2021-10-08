using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonAutomation.Pages
{
    public class SignUp
    {
        public SignUp(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_imglogo")]
        [CacheLookup]
        public IWebElement logo;

        [FindsBy(How = How.XPath, Using = "//*[text()='Signup']")]
        [CacheLookup]
        public IWebElement signup;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtPassword")]
        [CacheLookup]
        public IWebElement pwd;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtConfirmPwd")]
        [CacheLookup]
        public IWebElement confirm;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[6]/input[1]")]
        [CacheLookup]
        public IWebElement submit;

    }
}

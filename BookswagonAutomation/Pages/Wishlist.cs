using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonAutomation.Pages
{
    public class Wishlist
    {
        public Wishlist(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "wlButton")]
        [CacheLookup]
        public IWebElement add;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_WishList_lvWishList_ctrl0_divAddtoCart")]
        [CacheLookup]
        public IWebElement buynow;
    }
}

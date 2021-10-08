using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonAutomation.Pages
{
    public class Search
    {
        public Search(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_lihome")]
        [CacheLookup]
        public IWebElement homeIcon;

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        [CacheLookup]
        public IWebElement searchtext;

        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$Button1")]
        [CacheLookup]
        public IWebElement searchIcon; 
    }
}

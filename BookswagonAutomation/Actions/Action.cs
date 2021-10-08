using System.Threading;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BookswagonAutomation.Pages;
using BookswagonAutomation.AccessData;
using BookswagonAutomation.Base;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace BookswagonAutomation.Actions
{
    public class Action:Base.BaseClass
    {

        public void UserRegistration(IWebDriver driver)
        {
            try
            {
                SignUp signUp = new SignUp(driver);

                LogInfo.Info("Accessing data from excel sheet");

                ExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\DataResource\LoginData.xlsx");

                Assert.AreEqual("Online Bookstore | Buy Books Online | Read Books Online", driver.Title);

                Assert.IsTrue(signUp.logo.Displayed);

                signUp.signup.Click();
                Thread.Sleep(2000);

                Assert.AreEqual("https://www.bookswagon.com/signup", driver.Url);

                signUp.email.SendKeys(ExcelData.ReadData(1, "UserName"));
                Thread.Sleep(2000);

                signUp.pwd.SendKeys(ExcelData.ReadData(1, "Password"));
                Thread.Sleep(2000);

                signUp.confirm.SendKeys(ExcelData.ReadData(1, "Password"));
                Thread.Sleep(2000);

                // signUp.submit.Click();

                LogInfo.Info("User Registered  successfully.....");
            }
            catch
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.FileNotFoundException, "Couldn't Find File in the location ");
            }
        }

        public void Login(IWebDriver driver)
        {
            try
            {
                LoginClass login = new LoginClass(driver);

                LogInfo.Info("Accessing data from excel sheet");

                ExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\DataResource\LoginData.xlsx");

                Assert.IsTrue(login.logo.Displayed);

                login.login.Click();
                Thread.Sleep(2000);

                Assert.AreEqual("https://www.bookswagon.com/login", driver.Url);

                login.email.SendKeys(ExcelData.ReadData(1, "UserName"));
                Thread.Sleep(2000);

                login.pwd.SendKeys(ExcelData.ReadData(1, "Password"));
                Thread.Sleep(2000);

                login.loginbtn.Click();

                IWebElement account = driver.FindElement(By.XPath("//*[text()='vivekvk2903@gmail.co']"));

                Assert.IsTrue(account.Displayed);

                LogInfo.Info("User logged in successfully.....");
            }
            catch
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.FileNotFoundException, "Couldn't Find File in the location ");
            }
        }

        public void InvalidLogin(IWebDriver driver)
        {
            LoginClass login = new LoginClass(driver);

            LogInfo.Info("Accessing data from excel sheet");

            ExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\DataResource\LoginData.xlsx");

            login.login.Click();
            Thread.Sleep(2000);

            login.email.SendKeys(ExcelData.ReadData(2, "UserName"));
            Thread.Sleep(2000);

            login.pwd.SendKeys(ExcelData.ReadData(2, "Password"));
            Thread.Sleep(2000);

            login.loginbtn.Click();

            if(driver.Url!= "https://www.bookswagon.com/myaccount.aspx")
            {
                Screenshot();
                LogInfo.Debug("Login failed");
            }

            LogInfo.Info("Login Successful......");

        }

        public void SearchBook(IWebDriver driver)
        {
            try
            {
                Login(driver);

                Search search = new Search(driver);

                search.homeIcon.Click();
                Thread.Sleep(2000);

                search.searchtext.SendKeys(Keys.Control + "v");
                Thread.Sleep(2000);

                search.searchIcon.Click();
                Thread.Sleep(2000);
            }
            catch 
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.NoSuchElementException, "Couldn't Find Element with the corresponding locator");
            }
        }

        public void WishList(IWebDriver driver)
        {
            try
            {
                SearchBook(driver);
                
                Wishlist add = new Wishlist(driver);

                add.add.Click();
                Thread.Sleep(2000);

                add.buynow.Click();
            }
            catch   
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.NoSuchElementException, "Couldn't Find Element with the corresponding locator");
            }
        }

        public void Order(IWebDriver driver)
        {
            try
            {
                SearchBook(driver);

                PlaceOrder place = new PlaceOrder(driver);

                place.buynow.Click();
                Thread.Sleep(6000);

                driver.SwitchTo().Frame(0);

                place.quantity.SendKeys(Keys.Backspace);

                place.quantity.SendKeys(Keys.NumberPad2);
                Thread.Sleep(2000);

                place.quantity.SendKeys(Keys.Backspace);

                place.quantity.SendKeys(Keys.NumberPad1);
                Thread.Sleep(2000);

                System.Console.WriteLine(driver.CurrentWindowHandle);

                place.placeOrder.Click();
                Thread.Sleep(6000);

                place.continuebtn.Click();
                Thread.Sleep(6000);

                ExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\DataResource\AddressData.xlsx");

                place.name.SendKeys(ExcelData.ReadData(1, "Name"));
                Thread.Sleep(2000);

                place.company.SendKeys(ExcelData.ReadData(1, "CompanyName"));
                Thread.Sleep(2000);

                place.street.SendKeys(ExcelData.ReadData(1, "Address"));
                Thread.Sleep(2000);

                place.landmark.SendKeys(ExcelData.ReadData(1, "Landmark"));
                Thread.Sleep(2000);

                place.country.SendKeys(ExcelData.ReadData(1, "Country"));
                Thread.Sleep(2000);

                place.state.SendKeys(ExcelData.ReadData(1, "State"));
                Thread.Sleep(2000);

                place.city.SendKeys(ExcelData.ReadData(1, "City"));
                Thread.Sleep(2000);

                place.zipcode.SendKeys(ExcelData.ReadData(1, "Pincode"));
                Thread.Sleep(2000);

                place.mobile.SendKeys(ExcelData.ReadData(1, "Mobile"));
                Thread.Sleep(2000);

                place.phone.SendKeys(ExcelData.ReadData(1, "Phone"));
                Thread.Sleep(2000);

                place.save.Click();
                Thread.Sleep(2000);

                place.continues.Click();
                Thread.Sleep(2000);

                place.payment.Click();
            }
            catch 
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.NoSuchElementException, "Couldn't Find Element with the corresponding locator");
            }

        }

        public void Signout(IWebDriver driver)
        {
            try
            {
                Logout logout = new Logout(driver);

                Login(driver);
                Thread.Sleep(2000);

                logout.Accbtn.Click();
                Thread.Sleep(2000);

                logout.logoutbtn.Click();
            }
            catch 
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.NoSuchElementException, "Couldn't Find Element with the corresponding locator");
            }
        }
    }
}

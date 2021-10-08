using NUnit.Framework;
using BookswagonAutomation.Actions;
using AventStack.ExtentReports;
//using NUnit.Allure.Core;
//using NUnit.Allure.Attributes;
//using Allure.Commons;

namespace BookswagonAutomation
{
    //[TestFixture]
    //[AllureNUnit]
    public class BookswagonTests:Base.BaseClass
    {
        Action action = new Action();

        ExtentReports reports = ReportClass.report();
        ExtentTest test;

        [Test, Order(0)]
        public void UserRegistration()
        {
            test = reports.CreateTest("BookswagonTests");
            action.UserRegistration(driver);
            reports.Flush();

        }



        [Test,Order(1)]
        public void UserLogin()
        {
            test = reports.CreateTest("Bookswagon  Login");
            action.Login(driver);
            reports.Flush();
        }

        [Test, Order(2)]
        public void SearchBook()
        {
            test = reports.CreateTest("Searching a book");
            action.SearchBook(driver);
            reports.Flush();
        }


        [Test, Order(3)]
        public void AddtoWishList()
        {
            test = reports.CreateTest("BookswagonTests");
            test.Log(Status.Info, "Automating to add books to wishlist.");
            action.WishList(driver);
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
        }

        [Test, Order(4)]
        public void PlacingOrder()
        {
            test = reports.CreateTest("BookswagonTests");
            test.Log(Status.Info, "Automating placing an order .");
            action.Order(driver);
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
        }

        [Test, Order(5)]
        public void Login_Using_InvalidCredentials()
        {
            test = reports.CreateTest("BookswagonTests");
            test.Log(Status.Info,"Validaing Negative testcase....");
            action.InvalidLogin(driver);
            test.Info("Details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\Screenshots\ss.jpg").Build());
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
        }

        [Test, Order(6)]
        public void Logout()
        {
            test = reports.CreateTest("BookswagonTests");
            action.Signout(driver);
            reports.Flush();
        }
    }
}
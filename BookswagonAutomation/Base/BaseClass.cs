using System.IO;
using System.Reflection;
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace BookswagonAutomation.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;

        public readonly ILog LogInfo = LogManager.GetLogger(typeof(BookswagonTests));
        public static readonly ILoggerRepository loggerRepository = LogManager.GetRepository(Assembly.GetCallingAssembly());


        [SetUp]
        public void NewRegistration()
        {
            var file = new FileInfo("log4net.config");

            //logging info into file using XML configurator
            log4net.Config.XmlConfigurator.Configure(loggerRepository, file);

            LogInfo.Info("Initializing SetUp");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            LogInfo.Info("Disabling notifications");
            driver = new ChromeDriver(options);
            LogInfo.Info("navigating control to chrome browser");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.bookswagon.com/";
            LogInfo.Debug("Navigating to corresponding URL");
        }

        public static void Screenshot()
        {
            ITakesScreenshot ss = driver as ITakesScreenshot;
            Screenshot screenshot = ss.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\Screenshots\ss.jpg");
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}
    }
}

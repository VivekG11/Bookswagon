using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace BookswagonAutomation
{
    public class ReportClass
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;

        public static ExtentReports report()
        {
            if (extent == null)
            {

                string reportPath = @"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\Reports\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "Vivek");
                extent.AddSystemInfo("ProviderName", "Vivek");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("Browser", "FireFox");
                extent.AddSystemInfo("ProjectName", "Spotify Automation");

                string conifgPath = @"C:\Users\vivek.g\source\repos\BookswagonAutomation\BookswagonAutomation\report.xml";
                htmlReporter.LoadConfig(conifgPath);

            }
            return extent;
        }

    }
}

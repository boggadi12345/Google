using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitDemo.Framework.Tests
{
    [TestFixture]
    public class ExtentReportDemo
    {
        [Test]
        public void GenerateReport()
        {
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(@"C:\Users\Bhuma\Documents\ExtentReport\report.html");
            AventStack.ExtentReports.ExtentReports report = new AventStack.ExtentReports.ExtentReports();
            report.AttachReporter(htmlreport);
          
            ExtentTest testLog = report.CreateTest("Test1");
            testLog.Log(Status.Pass, "Success log");
            testLog.Log(Status.Fail, "Failure log");
            testLog.Log(Status.Info, "Info log");

            report.Flush();
        }
    }
}

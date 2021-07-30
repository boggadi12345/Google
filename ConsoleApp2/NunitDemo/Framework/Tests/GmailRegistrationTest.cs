using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ConsoleApp2.Framework.Base;
using ConsoleApp2.Framework.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2.Framework.Tests
{
    [TestFixture]
    public class GmailRegistrationTest
    {
        IWebDriver driver;
        AventStack.ExtentReports.ExtentReports report;

        [OneTimeSetUp]//Assembly initialize
        public void OneTimeSetup()
        {
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(@"C:\Users\Bhuma\Documents\ExtentReport\report.html");
            report = new AventStack.ExtentReports.ExtentReports();
            report.AttachReporter(htmlreport);
        }
        [OneTimeTearDown]//Assembly cleaup
        public void OneTimeTeardown()
        {
            report.Flush();
        }
        [SetUp]
        public void TestInitialize()
        {
            BrowserFactory browser = new BrowserFactory();
            driver = browser.LaunchBrowser();
        }

        [TearDown]
        public void TestCleanUp()
        {
            driver.Quit();
        }

        [Test]
        public void GmailReg()
        {
            ExtentTest testLog = report.CreateTest("GmailReg");

            BrowserActions actions = new BrowserActions(driver, testLog);
            actions.NavigateURL();
            actions.ClickObj( HomePage.lnk_CreateAnAccount, "Create an account");
            actions.ClickObj( HomePage.lnk_MySelf, "My self");
            actions.EnterText( GmailRegistrationPage.txt_FirstName, "Rama", "FirstName");
            actions.EnterText( GmailRegistrationPage.txt_LastName, "LastName", "LastName");
            actions.EnterText( GmailRegistrationPage.txt_UserName, "ramadevi23456732", "UserName");
            actions.EnterText( GmailRegistrationPage.txt_password, "1234598765$", "PassWord");
            actions.EnterText( GmailRegistrationPage.txt_cnfPwd, "1234598765$", "ConfirmPassword");

            actions.ClickObj( GmailRegistrationPage.check_name, "Checkbox");
            actions.ClickObj( GmailRegistrationPage.btn_Next, "Next");
            //Thread.Sleep(2000);
            bool ele = actions.ElementDisplay( By.Id("phoneNumberId"), "Phone number");
            //bool  ele = driver.FindElement(By.Id("phoneNumberId")).Displayed;
            if (ele == true)
            {
                Console.WriteLine("Gmail Regisration successfullly completed");
            }
            else
            {
                Console.WriteLine("Failure to perform Gmail Regisration");
            }

            Assert.IsTrue(driver.FindElement(By.Id("phoneNumberId")).Displayed,"Registration not completed successfully");
        }
    }
}

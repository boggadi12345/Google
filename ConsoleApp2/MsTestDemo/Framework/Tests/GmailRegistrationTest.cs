using ConsoleApp2.Framework.Base;
using ConsoleApp2.Framework.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2.Framework.Tests
{
    [TestClass]
    public class GmailRegistrationTest
    {
        IWebDriver driver;
        [TestInitialize]
        public void TestInitialize()
        {
            BrowserFactory browser = new BrowserFactory();
            driver = browser.LaunchBrowser();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
        }

        [TestMethod]
        public void GmailReg()
        {
            BrowserActions actions = new BrowserActions();
            actions.NavigateURL(driver);
            actions.ClickObj(driver, HomePage.lnk_CreateAnAccount, "Create an account");
            actions.ClickObj(driver, HomePage.lnk_MySelf, "My self");
            actions.EnterText(driver, GmailRegistrationPage.txt_FirstName, "Rama", "FirstName");
            actions.EnterText(driver, GmailRegistrationPage.txt_LastName, "LastName", "LastName");
            actions.EnterText(driver, GmailRegistrationPage.txt_UserName, "ramadevi23456732", "UserName");
            actions.EnterText(driver, GmailRegistrationPage.txt_password, "1234598765$", "PassWord");
            actions.EnterText(driver, GmailRegistrationPage.txt_cnfPwd, "1234598765$", "ConfirmPassword");

            actions.ClickObj(driver, GmailRegistrationPage.check_name, "Checkbox");
            actions.ClickObj(driver, GmailRegistrationPage.btn_Next, "Next");
            Thread.Sleep(2000);
            bool  ele = driver.FindElement(By.Id("phoneNumberId")).Displayed;
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

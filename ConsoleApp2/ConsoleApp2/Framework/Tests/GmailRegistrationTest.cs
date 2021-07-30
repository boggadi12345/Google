using ConsoleApp2.Framework.Base;
using ConsoleApp2.Framework.Repository;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Framework.Tests
{
    public class GmailRegistrationTest
    {
        public void GmailReg()
        {

            //IWebDriver driver = new EdgeDriver(@"C:\Users\Bhuma\Downloads\edgedriver_win64");
            BrowserFactory browser = new BrowserFactory();
            IWebDriver driver = browser.LaunchBrowser();
            //driver.Url = "https://gmail.com";

            BrowserActions actions = new BrowserActions();
            actions.NavigateURL(driver);

            //driver.Manage().Window.Maximize();


            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            actions.ClickObj(driver, HomePage.lnk_CreateAnAccount, "Create an account");

            // driver.FindElement(By.XPath("//*[text()='Create account']")).Click();//create account
            // driver.FindElement(By.XPath("//*[text()='For myself']")).Click();//for myself
            actions.ClickObj(driver, HomePage.lnk_MySelf, "My self");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //driver.FindElement(By.Name("firstName")).SendKeys("Rama");
            actions.EnterText(driver, GmailRegistrationPage.txt_FirstName, "Rama", "FirstName");
            //driver.FindElement(By.XPath("//*[@jscontroller='pxq3x']")).SendKeys("Last name");//lastname
            actions.EnterText(driver, GmailRegistrationPage.txt_LastName, "LastName" ,"LastName");
            actions.EnterText(driver, GmailRegistrationPage.txt_UserName, "ramadevi","UserName");
            //driver.FindElement(By.Name("Username")).SendKeys("ramadevi");
           
            //driver.FindElement(By.Name("Passwd")).SendKeys("12345$");
            actions.EnterText(driver, GmailRegistrationPage.txt_password, "12345$","PassWord");
            //driver.FindElement(By.Name("ConfirmPasswd")).SendKeys("12345$");
            actions.EnterText(driver, GmailRegistrationPage.txt_cnfPwd, "12345$","ConfirmPassword");

            //driver.FindElement(By.XPath("//*[@type='checkbox']")).Click();
            actions.ClickObj(driver, GmailRegistrationPage.check_name, "Checkbox");
            //driver.FindElement(By.XPath("//*[@class='qhFLie']")).Click();
            actions.ClickObj(driver, GmailRegistrationPage.btn_Continue, "Continue");
        }
    }
}

using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Framework.Base
{
    public class BrowserActions
    {
        IWebDriver driver;
        ExtentTest testLog;

        public BrowserActions(IWebDriver driver, ExtentTest testLog)
        {
            this.driver = driver;
            this.testLog = testLog;
        }
        public void NavigateURL()
        {
            try
            {
                driver.Url = "https://gmail.com";
                driver.Manage().Window.Maximize();
                Console.WriteLine("Successfully navigate url");
                testLog.Log(Status.Pass, "Successfully navigate url");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to navigate url");
                testLog.Log(Status.Fail, "Failure to navigate url ");
            }
            
        }
        public void ClickObj( By locator, string msg)
        {
            try
            {
                WaitForEle( locator);
                driver.FindElement(locator).Click();
                Console.WriteLine("Successfully ClickElement "+msg);
                testLog.Log(Status.Pass, "Successfully ClickElement " + msg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to ClickElement "+msg);
                testLog.Log(Status.Fail, "Failure to ClickElement " + msg);
            }
            //driver.FindElement(locator).Click();
        }
        public void EnterText(By locator,string input,String msg)
        {
            try
            {
                WaitForEle(locator);
                driver.FindElement(locator).SendKeys(input);
                Console.WriteLine("Successfully EnterText "  +msg);
                testLog.Log(Status.Pass, "Successfully EnterText " + msg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to EnterText "  +msg);
                testLog.Log(Status.Fail, "Failure to EnterText " + msg);
            }
            //driver.FindElement(locator).SendKeys(input);
        }

        public bool ElementDisplay( By locator,string msg)
        {
            try {
                WaitForEle( locator);
                bool ele = driver.FindElement(locator).Displayed;
                testLog.Log(Status.Pass, "Successfully element display " + msg);

                return ele;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to display element " + msg);
                testLog.Log(Status.Fail, "Failure to display element " + msg);
                return false;
            }
        }

        public void WaitForEle( By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            }
            catch(Exception e)
            {

            }
            
        }
    }
}

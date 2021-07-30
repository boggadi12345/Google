using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Framework.Base
{
    class BrowserActions
    {
        public void NavigateURL(IWebDriver driver)
        {
            try
            {
                driver.Url = "https://gmail.com";
                driver.Manage().Window.Maximize();
                Console.WriteLine("Successfully navigate url");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to navigate url");
            }
            
        }
        public void ClickObj(IWebDriver driver, By locator, string msg)
        {
            try
            {
                driver.FindElement(locator).Click();
                Console.WriteLine("Successfully ClickElement "+msg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to ClickElement "+msg);
            }
            //driver.FindElement(locator).Click();
        }
        public void EnterText(IWebDriver driver,By locator,string input,String msg)
        {
            try
            {
                driver.FindElement(locator).SendKeys(input);
                Console.WriteLine("Successfully EnterText "  +msg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to EnterText "  +msg);
            }
            //driver.FindElement(locator).SendKeys(input);
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
   public class GmailRegistration
    {
        public void GmailReg()
        {
            
            IWebDriver driver = new EdgeDriver(@"C:\Users\Bhuma\Downloads\edgedriver_win64");
            driver.Url = "https://gmail.com";
            driver.Manage().Window.Maximize();


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            

            driver.FindElement(By.XPath("//*[text()='Create account']")).Click();//create account
            
            driver.FindElement(By.XPath("//*[text()='For myself']")).Click();//for myself

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            driver.FindElement(By.Name("firstName")).SendKeys("Rama");
            driver.FindElement(By.XPath("//*[@jscontroller='pxq3x']"));//lastname
            driver.FindElement(By.Name("Username")).SendKeys("ramadevi");
            driver.FindElement(By.Name("Passwd")).SendKeys("12345$");
            driver.FindElement(By.Name("ConfirmPasswd")).SendKeys("12345$");
            driver.FindElement(By.XPath("//*[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//*[@class='qhFLie']")).Click();
        }

    }
}

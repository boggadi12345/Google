using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    public class HandleAllertsDemo
    {
        public void HandleAllert()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";

            driver.Manage().Window.Maximize();
            string title = driver.Title;
            driver.FindElement(By.XPath("//button[text()='Click for JS Alert']")).Click();

            driver.SwitchTo().Alert().Accept();//ok

            //driver.SwitchTo().Alert().Dismiss(); //Cancel
            driver.FindElement(By.XPath("//button[text()='Click for JS Prompt']")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().SendKeys("Sample text");
        }
    }
}

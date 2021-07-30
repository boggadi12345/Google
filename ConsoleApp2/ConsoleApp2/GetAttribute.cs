using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class GetAttribute
    {
        public void GetAtt()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://Google.com";

            driver.Manage().Window.Maximize();

            IWebElement Shopping = driver.FindElement(By.Name("q"));
            Shopping.SendKeys("Selenium");

            String value = Shopping.GetAttribute("value");
            String title = Shopping.GetAttribute("title");

        }
    }
}

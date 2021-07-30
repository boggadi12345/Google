using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
   public  class HandleDropdownDemo11 
    {
        public void DropdownDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://flipkart.com";

            driver.Manage().Window.Maximize();

            IWebElement Shopping = driver.FindElement(By.XPath("//a[@data-hveid='CAIQAw']"));
           

        }
    }
}

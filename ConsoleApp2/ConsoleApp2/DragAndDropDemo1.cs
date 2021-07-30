using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class DragAndDropDemo1
    {
        public void DragDrop()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://DragAndDrop.com";
            driver.Manage().Window.Maximize();


            Actions actions = new Actions(driver);
           

             IWebElement Source = driver.FindElement(By.XPath("//li[@data-id='2']"));
            IWebElement Destination = driver.FindElement(By.XPath("//li[@data-id='2']"));
            actions.DragAndDrop(Source, Destination);
            actions.Build().Perform();

            actions.ContextClick();
            actions.Build().Perform();





        }
    }
}

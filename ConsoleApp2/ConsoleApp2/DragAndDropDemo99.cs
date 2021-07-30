using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class DragAndDropDemo99
    {
        public void DragAndDrop5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://DragAndDrop.com";
            driver.Manage().Window.Maximize();

            Actions actions = new Actions(driver);



            IWebElement Source = driver.FindElement(By.XPath("//img[@class='jch - lazyloaded']"));
            IWebElement Destination = driver.FindElement(By.XPath("//img[@class='jch - lazyloaded'])"));


            actions.DragAndDrop(Source, Destination);
            actions.Build().Perform();




            actions.ContextClick();
            actions.Build().Perform();

        }
    }
    
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MouseHoverDemo33
    {
        public void MouseHover1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://flipkart.com";
            driver.Manage().Window.Maximize();


            IWebElement fashion = driver.FindElement(By.XPath("//img[@alt='Fashion']"));
            //IWebElement womenethnic = driver.FindElement(By.XPath("//span[@class='_2I9KP_ _2WDRax']"));


            Actions actions = new Actions(driver);
            actions.MoveToElement(fashion);
            actions.Build().Perform();
        }
        }
    }


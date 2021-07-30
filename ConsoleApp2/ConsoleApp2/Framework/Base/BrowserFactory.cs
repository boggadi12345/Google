using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Framework.Base
{
    public class BrowserFactory
    {
        public IWebDriver LaunchBrowser()
        {
            try
            {
                IWebDriver driver = new EdgeDriver(@"C:\Users\Bhuma\Downloads\edgedriver_win64");
                Console.WriteLine("Successfully Launch Browser");
                return driver;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Failure to Launch browser");
                return null;
            }
        }
    }
}

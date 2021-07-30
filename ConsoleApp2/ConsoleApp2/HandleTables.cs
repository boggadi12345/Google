using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class HandleTables
    {
        public void HandleTabl()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/web-table-element.php";

            driver.Manage().Window.Maximize();

            IWebElement table = driver.FindElement(By.XPath("//table[@class='dataTable']"));
            IList<IWebElement> lst_Rows= table.FindElements(By.TagName("tr"));
            foreach(IWebElement row in lst_Rows)
            {
                IList<IWebElement> lst_Columns =row.FindElements(By.TagName("td"));

                foreach(IWebElement columns in lst_Columns)
                {
                    Console.Write(columns.Text+" ");

                }
                Console.WriteLine();
            }

        }
    }
}

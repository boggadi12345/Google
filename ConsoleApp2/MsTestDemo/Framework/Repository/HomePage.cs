using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Framework.Repository
{
    public class HomePage
    {
        public static By lnk_CreateAnAccount = By.XPath("//*[text()='Create account']");
        public static By lnk_MySelf = By.XPath("//*[text()='For myself']");

    }
}

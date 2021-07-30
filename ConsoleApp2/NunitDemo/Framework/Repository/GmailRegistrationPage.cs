using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Framework.Repository
{
    public class GmailRegistrationPage
    {
        public static By txt_FirstName = By.Id("firstName");
        public static By txt_LastName = By.Name("lastName");
        public static By txt_UserName = By.Name("Username");
        public static By txt_password = By.Name("Passwd");
        public static By txt_cnfPwd = By.Name("ConfirmPasswd");
        public static By check_name = By.XPath("//*[@type='checkbox']");
        public static By btn_Continue = By.XPath("//*[@class='qhFLie']");
        public static By btn_Next = By.XPath("//*[text()='Next']");
    }
}

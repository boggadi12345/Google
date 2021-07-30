using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class IrctcRegistration
    {
		public void Irctc1()
		{


			IWebDriver driver = new ChromeDriver();
			driver.Url = "http://www.Irctc.co.in";
			driver.Manage().Window.Maximize();
			//driver.Manage().Cookies.DeleteAllCookies();


			driver.FindElement(By.XPath("//*[@class='text-center col-xs-12']")).Click();
			driver.FindElement(By.Id("userName")).SendKeys("Rama");
			driver.FindElement(By.Id("usrPwd")).SendKeys("1@abcd");
			driver.FindElement(By.Id("cnfUsrPwd")).SendKeys("1@abcd");
			driver.FindElement(By.XPath("//*[text()='Preferred Language']")).Click();
			driver.FindElement(By.XPath("//*[text()='English']")).Click();
			driver.FindElement(By.XPath("//*[@class='ng-tns-c66-39 ui-dropdown ui-widget ui-state-default ui-corner-all']")).Click();//security question
			driver.FindElement(By.XPath("//[@aria-label='What is your pet name ?']")).Click();
			driver.FindElement(By.XPath("//*[@placeholder='Security Answer ']")).SendKeys("dolly");
			driver.FindElement(By.XPath("//[@label='Continue']")).Click();
			driver.FindElement(By.Id("firstName")).SendKeys("Rama");
			driver.FindElement(By.Id("middleName")).SendKeys("Devi");
			driver.FindElement(By.Id("lastname")).SendKeys("Boggadi");
			driver.FindElement(By.XPath("//*[text()='Select Occupation']")).Click();
			driver.FindElement(By.XPath("//*[@aria-label='PRIVATE']")).Click();
			//driver.findElement(By.xpath("//input[@class='ng-tns-c59-10 ui-inputtext ui-widget ui-state-default ui-corner-all ng-star-inserted']")).click();

			//year
			//WebElement year = driver.findElement(By.xpath("//select[@class='ui-datepicker-year ng-tns-c59-10 ng-star-inserted']"));

		
			
			driver.FindElement(By.XPath("//[@aria-label='Male']")).Click();
			driver.FindElement(By.Id("email")).SendKeys("ramadevi.boggadi@gmail.com");
			driver.FindElement(By.Id("mobile")).SendKeys("9113842611");
			driver.FindElement(By.XPath("//[@label='Continue']")).Click();
			//WebElement nationality = driver.findElement(By.xpath("//select[@class='form-control ng-pristine ng-invalid ng-touched']"));

			
			//driver.findElement(By.xpath("//*[@class='form-control ng-touched ng-dirty ng-valid']")).click();
			//driver.findElement(By.xpath("//*[text()='American Samoa']")).click();
			//driver.FindElement(By.XPath("//button[@class='search_btn train_Search ng-star-inserted']")).click();
			driver.FindElement(By.Id("resAddress1")).SendKeys("1085-5");
			driver.FindElement(By.Id("resAddress2")).SendKeys("BTM");
			driver.FindElement(By.Id("resAddress3")).SendKeys("BANGALORE");
			driver.FindElement(By.Name("resPinCode")).SendKeys("520029");
			driver.FindElement(By.Name("resState")).SendKeys("KARNATAKA");
			/*WebElement city = driver.findElement(By.xpath("//select[@class='form-control ng-pristine ng-invalid ng-touched']"));

			Actions action=new Actions(driver);
			action.moveToElement(city);
			action.build().perform();

			driver.FindElement(By.linkText("KARNATAKA")).click();*/
			driver.FindElement(By.Id("resPhone")).SendKeys("9113842611");
			//driver.findElement(By.xpath("//span[@class='ui-radiobutton-icon ui-clickable']")).click();
			//driver.findElement(By.id("recaptcha-anchor")).click();
			driver.FindElement(By.XPath("//*[text()='REGISTER']")).Click();

		}

	  }

	}

	
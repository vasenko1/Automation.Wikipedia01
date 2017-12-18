using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Wikipedia01.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation.Wikipedia01.Pages
{
    class BasePage
    {

        public static void OpenPage(string PageURL)
        {
            BaseWebDriver.driver.Navigate().GoToUrl(PageURL);
            Console.WriteLine("Opened url: " + PageURL);
        }

        public static void ClickOnElement(string findtype, string element)
        {
            if (findtype == "Id")
                BaseWebDriver.driver.FindElement(By.Id(element)).Click();
            if (findtype == "Name")
                BaseWebDriver.driver.FindElement(By.Name(element)).Click();
            if (findtype == "Class")
                BaseWebDriver.driver.FindElement(By.ClassName(element)).Click();
            Console.WriteLine("Element clicked by " + findtype);
        }
    }
    
}

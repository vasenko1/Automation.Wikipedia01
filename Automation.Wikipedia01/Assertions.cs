using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Wikipedia01.Base;
using Automation.Wikipedia01.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation.Wikipedia01
{
    class Assertions
    {
        public static void IsElementTextCorrect(string elementID, string text)
        {
            BasePage.FindElementByID(elementID);
            IWebElement element = BaseWebDriver.driver.FindElement(By.Id(elementID)); ;
            Assert.Equals(element.Text, text);
        }
    }
}

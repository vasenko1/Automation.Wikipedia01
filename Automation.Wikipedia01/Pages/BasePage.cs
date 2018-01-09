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
using OpenQA.Selenium.Support.UI;

namespace Automation.Wikipedia01.Pages
{
    class BasePage
    {
        public static string headerID = "firstHeading";
        public static string headerXPath = "//h1";

        public static void OpenPage(string PageURL)
        {
            BaseWebDriver.driver.Navigate().GoToUrl(PageURL);
            Console.WriteLine("Opened url: " + PageURL);
        }

        public static IWebElement FindElementByID(string elementID)
        {
            new WebDriverWait(BaseWebDriver.driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(elementID)));
            IWebElement element = BaseWebDriver.driver.FindElement(By.Id(elementID));
            Console.WriteLine("Element with ID '" + elementID + "' is VISIBLE.");
            return element;
        }

        public static IWebElement FindElementByXpath(string elementXPath)
        {
            new WebDriverWait(BaseWebDriver.driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(elementXPath)));
            IWebElement element = BaseWebDriver.driver.FindElement(By.XPath(elementXPath));
            Console.WriteLine("Element with XPath '" + elementXPath + "' is VISIBLE.");
            return element;
        }


        public static void GetTextFromElementXPath(string elementXPath, string elementText)
        {
            elementText = FindElementByXpath(elementXPath).GetAttribute("h1");
        }

        public static void GetTextFromElementID(string elementID, string elementText)
        {
            elementText = FindElementByXpath(elementID).GetAttribute("h1");
        }

        public static void SelectDropdownItem(string itemId)
        {
           
        }
    }
    
}

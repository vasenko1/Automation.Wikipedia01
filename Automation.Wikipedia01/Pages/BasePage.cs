using System;
using Automation.Wikipedia01.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Automation.Wikipedia01.Pages
{
    public class BasePage
    {
        public void OpenPage(string PageURL)
        {
            BaseWebDriver.Driver.Navigate().GoToUrl(PageURL);
            Console.WriteLine("Opened url: " + PageURL);
        }

        public void ImplicitWaitByID(IWebElement element)
        {
            new WebDriverWait(BaseWebDriver.Driver, TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementToBeClickable(element));
            //Console.WriteLine("Element with ID '" + elementID + "' is VISIBLE.");

        }
        
        public static IWebElement FindElementByID(string elementID)
        {
            IWebElement element = new WebDriverWait(BaseWebDriver.Driver, TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementExists(By.Id(elementID)));
            //Console.WriteLine("Element with ID '" + elementID + "' is VISIBLE.");
            return element;

        }

        public static IWebElement FindElementByXpath(string elementXPath)
        {
            IWebElement element = new WebDriverWait(BaseWebDriver.Driver, TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementExists(By.XPath(elementXPath)));
            //Console.WriteLine("Element with XPath '" + elementXPath + "' is VISIBLE.");
            return element;
        }


        public static void GetTextFromElementXPath(string elementXPath, string elementText)
        {
            elementText = FindElementByXpath(elementXPath).GetAttribute("h1");
        }

        public static string GetTextFromElementID(string elementID)
        {
            string elementText = FindElementByXpath(elementID).GetAttribute("h1");
            return elementText;
        }

        public static void SelectDropdownItem(string DropdownMenuId, string menuItemText)
        {
            FindElementByID(DropdownMenuId);
            new SelectElement(BaseWebDriver.Driver.FindElement(By.TagName("select"))).SelectByText(menuItemText);
            Console.WriteLine("Dropdown Item '" + menuItemText + "' is selected.");
        }
    }
    
}

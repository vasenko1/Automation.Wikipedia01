using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Automation.Wikipedia01.Pages
{
    class MainPage : BasePage
    {
        private static string searchFieldID = "searchInput";
        public static string headerID = "firstHeading";
        public static string headerXPath = "//div/h1";

        public static void InputAndSearchByField(string text)
        {
            FindElementByID(searchFieldID).Clear();
                Console.WriteLine("Element with ID '" + searchFieldID + "' is cleared.");
            FindElementByID(searchFieldID).SendKeys(text);
                Console.WriteLine("Text '" + text + "' is inputted into element with ID '" + searchFieldID + "'.");
            FindElementByID(searchFieldID).Submit();
                Console.WriteLine("Element with ID '" + searchFieldID + "' is submitted.");
            Assertions.IsElementTextByIdCorrect(headerID, text);
                Console.WriteLine("Opened page is correct.");
        }
    }
}

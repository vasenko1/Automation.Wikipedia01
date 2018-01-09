using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Wikipedia01.Pages
{
    class MainPage : BasePage
    {
        private static string searchFieldID = "searchInput";

        private static string elementText;

        public static string ElementText { get => elementText; set => elementText = value; }

        public static void InputAndSearchByField(string text)
        {
            FindElementByID(searchFieldID).Clear();
                Console.WriteLine("Element with ID '" + searchFieldID + "' is cleared.");
            FindElementByID(searchFieldID).SendKeys(text);
                Console.WriteLine("Text '" + text + "' is inputted into element with ID '" + searchFieldID + "'.");
            FindElementByID(searchFieldID).Submit();
                Console.WriteLine("Element with ID '" + searchFieldID + "' is submitted.");
            GetTextFromElementID(headerID, ElementText);
            Assertions.IsElementTextCorrect(headerID, text);
                Console.WriteLine("Page header is '" + ElementText + "'.");
        }
    }
}

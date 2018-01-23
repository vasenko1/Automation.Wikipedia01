using System;
using NUnit.Framework;

namespace Automation.Wikipedia01.Pages
{
    class MainPage : BasePage
    {
        private static string MainPageUrl = "https://en.wikipedia.org/wiki/Main_Page";
        private static string searchFieldID = "searchInput";
        private static string headerID = "firstHeading";
        private static string headerXPath = "//div/h1";

        

        public void RunTest(string text)
        {
            OpenPage(MainPageUrl);
            ClearField();
            InputTextIntoField(text);
            SubmitElement();
            CheckMainPageIsCorrect(text);
        }

        private static void ClearField()
        {
            FindElementByID(searchFieldID).Clear();
            Console.WriteLine("Element with ID '" + searchFieldID + "' is cleared.");
        }


        private static void InputTextIntoField(string text)
        {
            FindElementByID(searchFieldID).SendKeys(text);
            Console.WriteLine("Text '" + text + "' is inputted into element with ID '" + searchFieldID + "'.");
        }

        private static void SubmitElement()
        {
            FindElementByID(searchFieldID).Submit();
            Console.WriteLine("Element with ID '" + searchFieldID + "' is submitted.");
        }

        private static void CheckMainPageIsCorrect(string text)
        {
            string elementText = BasePage.FindElementByID(headerID).Text;
            Console.WriteLine("Element text is: " + elementText);
            Assertions.AssertIt(()=>Assert.AreEqual(elementText, text));
            Console.WriteLine("MainPage is fully checked.");
        }

    }
}

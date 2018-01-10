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
        public static void IsElementTextByIdCorrect(string elementID, string text)
        {
            string elementText = BasePage.FindElementByID(elementID).Text.ToString();
            Console.WriteLine("Element text is: " + elementText);

            try
            {
                Assert.AreEqual(elementText, text, "Elements are not equal.");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Assertion error is occured:  " + exception.Message);
            }
        }

        public static void IsElementTextByXpathCorrect(string elementXpath, string text)
        {
            string elementText = BasePage.FindElementByXpath(elementXpath).Text;
            Console.WriteLine("Element text is: " + elementText);


            try
            {
                Assert.AreEqual(elementText, text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Assertion error is occured:");
                Console.WriteLine(e);
            }
        }
    }
}
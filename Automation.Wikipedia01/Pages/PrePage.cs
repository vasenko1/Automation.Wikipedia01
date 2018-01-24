using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Automation.Wikipedia01.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation.Wikipedia01.Pages
{
    class PrePage : BasePage
    {
        private static string pageURL = "http://wikipedia.org";
        private static string linkEngId = "js-link-box-en";
        private static string linkRusId = "id('js-link-box-ru')/strong[1]";
        private static string LangLinksTextXPath = "//div[@class='central-featured']/div/a/strong";
        private static string SearchLangDDXpath = "id('searchLanguage')";

        public void RunTest()
        {
            OpenPage(pageURL);
            SelectDropdownItem(SearchLangDDXpath, "Suomi");
            CheckPrePageTitleIsCorrect();
            Check10LangLinkElements();
            CheckPrePageIsCorrect();
            ClickEnglishLink();
        }

        private void ClickEnglishLink()
        {
            FindElementByID(linkEngId).Click();
        }

        private static void CheckPrePageIsCorrect()
        {
            string elementText = FindElementByXpath(linkRusId).Text;
            Assertions.AssertIt(() => Assert.AreEqual(elementText, "Русский"));

            Console.WriteLine("PrePage is fully checked.");
        }

        private static void Check10LangLinkElements()
        {
            const int number = 10;
            int i = 0;

            IList<IWebElement> all = BaseWebDriver.Driver
                .FindElements(By.XPath(LangLinksTextXPath));
            String[] allText = new String[all.Count];
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }

            for (i = 0; i < allText.Length; i++)
            {
                Console.WriteLine(allText[i] + " - OK!");
            }
            Assertions.AssertIt(() => Assert.AreEqual(allText.Length, number));
 
            Console.WriteLine(number + " language link elements are presented.");
        }

        private static void CheckPrePageTitleIsCorrect()
        {
            string elementText = BaseWebDriver.Driver.Title;
            Assertions.AssertIt(() => Assert.AreEqual(elementText, "Wikipedia"));

            Console.WriteLine("Page Title '"+ elementText +"' is correct.");
        }
    }
}

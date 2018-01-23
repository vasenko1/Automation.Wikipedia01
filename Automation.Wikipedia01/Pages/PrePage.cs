using System;
using System.Collections;
using Automation.Wikipedia01.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation.Wikipedia01.Pages
{
    class PrePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "js-link-box-en")]
        public IWebElement _linkEngId { get; set; }

        private static string pageURL = "http://wikipedia.org";
        private static string linkEngId = "js-link-box-en";
        private static string linkRusId = "id('js-link-box-ru')/strong[1]";
        private static string TitleXpath = "id('undefined')/html[1]/head[1]/title[1]";
        private static string SearchLanguageId = "searchLanguage";


        public void RunTest()
        {
            OpenPage(pageURL);
            ClickOnLink();
            //SelectDropdownItem(SearchLanguageId, "Suomi");
            //CheckPrePageIsCorrect();            
        }

        private void ClickOnLink()
        {
            ImplicitWaitByID(_linkEngId);
            _linkEngId.Click();
            //FindElementByID(linkEngId).Click();
        }


        private static void CheckPrePageIsCorrect()
        {
            string elementText;
            int countX = 0;

            elementText = BaseWebDriver.Driver.Title;
            Assertions.AssertIt(() => Assert.AreEqual(elementText, "Wikipedia"));

            IWebElement element = FindElementByXpath("//body/div[1]/div[1]");
            IList AllLinksList = element.FindElements(By.XPath("//a/strong[1]"));
            countX = AllLinksList.Count;
            for (int i = 0; i < countX; i++)
            {
                Console.Write(AllLinksList[i] + " ");
            }
            Console.WriteLine(countX);
            Assertions.AssertIt(() => Assert.AreEqual(countX, 10));

            elementText = FindElementByXpath(linkRusId).Text;
            Assertions.AssertIt(() => Assert.AreEqual(elementText, "Русский"));

            Console.WriteLine("PrePage is fully checked.");
        }
    }
}

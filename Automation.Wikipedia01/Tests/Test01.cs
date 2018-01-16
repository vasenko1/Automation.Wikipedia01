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

namespace Automation.Wikipedia01.Tests
{
    [TestFixture]
    [Parallelizable]
    class Test01 : BaseWebDriver
    {
        PrePage prePage = new PrePage();
        MainPage mainPage = new MainPage();
        [Test]
        public void CheckPrePage()
        {
            //PageFactory.InitElements(Driver, prePage);
            prePage.RunTest();
        }

        [Test]
        public void SearchFlow()
        {
            mainPage.RunTest("dropdown");
            SearchResultPage.ClickEditTab();
            EditPage.SelectDropdownItems();
        }
    }
}

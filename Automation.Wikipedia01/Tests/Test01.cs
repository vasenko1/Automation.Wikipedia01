using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Wikipedia01.Base;
using Automation.Wikipedia01.Pages;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Automation.Wikipedia01.Tests
{
    [TestFixture]
    [Parallelizable]
    class Test01 : BaseWebDriver
    {
        [Test]
        public static void Start()
        {
            PrePage.RunTest();
        }

        [Test]
        public static void SearchFlow()
        {
            PrePage.OpenPrePage();
            PrePage.ClickOnLink();
            MainPage.InputAndSearchByField("iOS");
        }
    }
}

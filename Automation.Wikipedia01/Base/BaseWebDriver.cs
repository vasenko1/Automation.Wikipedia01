﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.Wikipedia01.Base
{

    [TestFixture]
    [Parallelizable]
    class BaseWebDriver
    {
        public static IWebDriver driver { get; set; }

        [SetUp]
        public static void Initialize()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public static void Exit()
        {
            driver.Close();
            driver.Quit();
        }

    }


}
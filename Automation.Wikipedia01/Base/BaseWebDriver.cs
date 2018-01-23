using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation.Wikipedia01.Base
{

    [TestFixture]
    [Parallelizable]
    class BaseWebDriver
    {
        public static IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public static void Initialize()
        {
            Driver = new ChromeDriver();
        }
        
        [OneTimeTearDown]
        public static void Exit()
        {
            Driver.Close();
            Driver.Quit();
        }
        
    }


}

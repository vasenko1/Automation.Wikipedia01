using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Wikipedia01.Pages
{
    class PrePage : BasePage
    {
        public static string pageURL = "http://wikipedia.org";
        public static string linkEngId = "js-link-box-en";

        public static void RunTest()
        {
            OpenPrePage();
            ClickOnLink();
        }

        public static void OpenPrePage()
        {
            OpenPage(pageURL);
        }
        public static void ClickOnLink()
        {
            FindElementByID(linkEngId).Click();
        }
    }
}

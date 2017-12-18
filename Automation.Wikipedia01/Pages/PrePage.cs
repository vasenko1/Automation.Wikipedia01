using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Wikipedia01.Pages
{
    class PrePage : BasePage
    {
        public static string PageURL = "http://wikipedia.org";
        public static string LinkEngId = "js-link-box-en";

        public static void RunTest()
        {
            OpenPrePage();
            ClickOnLink();
        }

        public static void OpenPrePage()
        {
            OpenPage(PageURL);
        }
        public static void ClickOnLink()
        {
            ClickOnElement(LinkEngId, "Id");
        }
    }
}

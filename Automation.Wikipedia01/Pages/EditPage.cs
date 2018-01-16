using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Wikipedia01.Pages
{
    class EditPage : BasePage
    {
        private static string dropDownItemInsertXpath = "Cyrillic";
        private static string dropDownMenuID = "editpage-specialchars";

        public static void SelectDropdownItems()
        {
            SelectDropdownItem(dropDownMenuID, dropDownItemInsertXpath);
        }
    }


}

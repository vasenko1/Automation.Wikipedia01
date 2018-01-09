﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Wikipedia01.Pages
{
    class SearchResultPage : BasePage
    {
        private static string EditTabId = "ca-edit";

        public void ClickEditTab()
        {
            FindElementByID(EditTabId).Click();
        }
    }
}
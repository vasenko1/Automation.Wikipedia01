using System;

namespace Automation.Wikipedia01.Pages
{
    class SearchResultPage : BasePage
    {
        private string EditTabId = "ca-edit";

        public void ClickEditTab()
        {
            try
            {
                FindElementByID(EditTabId).Click();
                Console.WriteLine("Edit tab is clicked.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
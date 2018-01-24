using Automation.Wikipedia01.Base;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Wikipedia01.Pages
{
    class EditPage : BasePage
    {
        private static string dropDownItemInsertText = "IPA (English)";
        private static string dropDownMenuXpath = "id('editpage-specialchars')/select";


        public void SelectDropdownItems()
        {
            /*
            IWebElement element = FindElementByXpath(dropDownMenuXpath);
            bool isSelected = element.Selected;
            while (isSelected == false)
            {
            */
                SelectDropdownItem(dropDownMenuXpath, dropDownItemInsertText);
            /*
            }
            string elementText = element.ToString();
            Assertions.AssertIt(() => Assert.AreEqual(elementText, dropDownItemInsertText));
            */
        }
    }
}

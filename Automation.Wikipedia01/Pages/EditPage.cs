namespace Automation.Wikipedia01.Pages
{
    class EditPage : BasePage
    {
        private static string dropDownItemInsertText = "IPA (English)";
        private static string dropDownMenuID = "editpage-specialchars";

        public void SelectDropdownItems()
        {
            SelectDropdownItem(dropDownMenuID, dropDownItemInsertText);
        }
    }


}

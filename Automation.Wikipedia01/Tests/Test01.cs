using Automation.Wikipedia01.Base;
using Automation.Wikipedia01.Pages;
using NUnit.Framework;

namespace Automation.Wikipedia01.Tests
{
    [TestFixture]
    [Parallelizable]
    class Test01 : BaseWebDriver
    {
        PrePage pp = new PrePage();
        MainPage mp = new MainPage();
        SearchResultPage srp = new SearchResultPage();
        EditPage ep = new EditPage();

        [Test]
        public void CheckPrePage()
        {
            pp.RunTest();
        }

        [Test]
        public void SearchFlow()
        {
            mp.RunTest("Dropdown");
            srp.ClickEditTab();
            ep.SelectDropdownItems();
        }
    }
}

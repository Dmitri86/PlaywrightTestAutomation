using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;
using Pages;

namespace StepsContext
{
    public class HomeStepContext : BaseStepContext
    {
        private readonly HomePage _homePage;

        public HomeStepContext(IPage page) : base(page)
        {
            _homePage = new HomePage(Page);
        }

        public Task ClickNavigationItem(string text)
        {
            return _homePage.NavigationItems.GetItemByText(text).Click();
        }

        public Task ClickChangeLanguage()
        {
            return _homePage.Language.Click();
        }

        public Task ClickSelectUkLanguage()
        {
            return _homePage.LanguageUk.Click();
        }

        public async Task<IEnumerable<string>> GetNavigationLabels()
        {
            return await _homePage.NavigationItems.GetItemsText();
        }

        public Task VerifyNavigationItemHaveCorrectName(IEnumerable<string> expected, IEnumerable<string> actual)
        {
            Assert.AreEqual(expected, actual, "Verify navigation items have correct name");
            return Task.CompletedTask;
        }

        public void VerifyUserName(string expectedUserName)
        {
            var actual = _homePage.UserName.GetText().GetAwaiter().GetResult();
            Assert.AreEqual(expectedUserName, actual, "Verify user name");
        }
    }
}
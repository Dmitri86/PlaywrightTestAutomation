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

        public void ClickLogIn()
        {
             _homePage.Login.Click().GetAwaiter().GetResult();
        }

        public void ClickCabinet()
        { 
            _homePage.Cabinet.Click().GetAwaiter().GetResult();
        }

        public void VerifyUserName(string expectedUserName)
        {
            var actual = _homePage.UserName.GetText().GetAwaiter().GetResult();
            Assert.AreEqual(expectedUserName, actual, "Verify user name");
        }
    }
}
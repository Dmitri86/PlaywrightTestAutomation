using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;
using Pages;

namespace StepsContext
{
    public class SupportStepContext : BaseStepContext
    {
        private readonly SupportPage _supportPage;

        public SupportStepContext(IPage page) : base(page)
        {
            _supportPage = new SupportPage(Page);
        }

        public async Task ClickXButton()
        {
            var isVisible = await _supportPage.XButton.IsVisible();
            if (isVisible)
            {
                await _supportPage.XButton.Click();
            }
        }

        public async Task VerifyButtonSupportVisible(bool expected = true)
        {
            var actual = await _supportPage.SupportButton.IsVisible();
            Assert.AreEqual(expected, actual, "Verify button Support is visible");
        }
    }
}
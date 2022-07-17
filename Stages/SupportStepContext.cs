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

        public void ClickXButton()
        {
            _supportPage.XButton.Click().GetAwaiter().GetResult();
        }

        public void VerifyButtonSupportVisible(bool expected = true)
        {
            var actual = _supportPage.SupportButton.IsVisible().GetAwaiter().GetResult();
            Assert.AreEqual(expected, actual, "Verify button Support is visible");
        }
    }
}
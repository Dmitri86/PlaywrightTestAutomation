using Core.Controls.Elements;
using Microsoft.Playwright;

namespace Pages
{
    public class SupportPage
    {
        private readonly IPage _page;

        public SupportPage(IPage page)
        {
            _page = page;
            XButton = new Button(_page.Locator("//div[@id='open-appeal-modal']//button"));
            SupportButton = new Button(_page.Locator("//a[contains(@class, 'open-appeal-modal__btn')]"));
        }

        public Button XButton;
        public Button SupportButton;
    }
}
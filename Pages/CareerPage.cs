using Core.Controls.Elements;
using Microsoft.Playwright;

namespace Pages
{
    public class CareerPage
    {
        public CareerPage(IPage page)
        {
            Title = new Label(page.Locator(".career-hero__title"));
            CareerItems = new Navigation(page.Locator(".tabber__item"));

        }

        public Label Title;
        public Navigation CareerItems;
    }
}
using Core.Controls.Elements;
using Microsoft.Playwright;

namespace Pages
{
    public class AllFlightsPage 
    {
        public AllFlightsPage(IPage page)
        {
            Items = new Navigation(page.Locator(".tabber__item"));
            Search = new TextBox(page.Locator("#bestSearchInput"));
            FromCity = new Label(page.Locator(".best-card__from-city:visible"));
            ToCity = new Label(page.Locator(".best-card__to-city:visible"));
            NoSearchResult = new Label(page.Locator("#bestNoResults"));
        }

        public Navigation Items;
        public TextBox Search;
        public Label FromCity;
        public Label NoSearchResult;
        public Label ToCity;
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Controls.Interfaces;
using Microsoft.Playwright;

namespace Core.Controls.Elements
{
    public class Navigation : PageElement, INavigation
    {
        public Navigation(ILocator locator) : base(locator)
        {
        }

        public async Task<IEnumerable<string>> GetItemsText()
        {
            var items = await Locator.AllTextContentsAsync();
            return items.Select(el => el.Trim());
        }

        public IMenuItem GetItemByText(string text)
        {
            return new MenuItem(Locator.Filter(new LocatorFilterOptions {HasTextString = text}));
        }
    }
}
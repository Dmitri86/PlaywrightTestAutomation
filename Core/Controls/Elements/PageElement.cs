using System.Threading.Tasks;
using Core.Controls.Interfaces;
using Microsoft.Playwright;

namespace Core.Controls.Elements
{
    public abstract class PageElement : IPageElement
    {
        protected readonly ILocator Locator;

        protected PageElement(ILocator locator)
        {
            Locator = locator;
        }


        public Task<bool> IsVisible()
        {
            return Locator.IsVisibleAsync();
        }

        public Task<bool> IsEnable()
        {
            return Locator.IsEnabledAsync();
        }
    }
}
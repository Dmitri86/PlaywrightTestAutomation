using Core.Controls.Interfaces;
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace Core.Controls.Elements
{
    public class Button : PageElement, IButton
    {
        public Button(ILocator locator) : base(locator)
        {
        }

        public Task Click()
        {
            return Locator.ClickAsync();
        }

        public Task<string> GetText()
        {
            return Locator.TextContentAsync();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Controls.Interfaces;
using Microsoft.Playwright;

namespace Core.Controls.Elements
{
    public class Label : PageElement, ILabel
    {
        public Label(ILocator locator) : base(locator)
        {
        }

        public Task<string> GetText()
        {
            return Locator.TextContentAsync();
        }

        public Task<IReadOnlyList<string>> GetTexts()
        {

            return Locator.AllTextContentsAsync();
        }
    }
}
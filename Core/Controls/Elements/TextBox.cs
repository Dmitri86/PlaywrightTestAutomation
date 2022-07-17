using System.Threading.Tasks;
using Core.Controls.Interfaces;
using Microsoft.Playwright;

namespace Core.Controls.Elements
{
    public class TextBox : PageElement, ITextBox
    {
        public TextBox(ILocator locator) : base(locator)
        {
        }

        public Task SetText(string text)
        {
            return Locator.FillAsync(text);
        }
    }
}
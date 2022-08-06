using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Core.Controls.Interfaces
{
    public interface INavigation
    {
        Task<IEnumerable<string>> GetItemsText();
        IMenuItem GetItemByText(string text);
    }
}
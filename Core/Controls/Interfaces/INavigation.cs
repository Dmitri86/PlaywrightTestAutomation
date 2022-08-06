using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Controls.Interfaces
{
    public interface INavigation
    {
        Task<IEnumerable<string>> GetItemsText();
        IButton GetItemByText(string text);
    }
}
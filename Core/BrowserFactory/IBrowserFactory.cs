using System.Threading.Tasks;
using Core.Settings;
using Microsoft.Playwright;

namespace Core
{
    public interface IBrowserFactory
    {
        public Task<IBrowser> GetBrowserAsync(BrowserSettings browserSettings);
    }
}
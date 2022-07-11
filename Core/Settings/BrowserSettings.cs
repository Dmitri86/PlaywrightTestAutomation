using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;

namespace Core.Settings
{
    public class BrowserSettings
    {
        public string Type { get; init; }
        public BrowserTypeLaunchOptions BrowserOptions { get; init; }

        public BrowserSettings(IConfiguration configurationSection)
        {
            Type = configurationSection.GetSection("Name").Value;
            BrowserOptions = new BrowserTypeLaunchOptionsBuilder(configurationSection.GetSection("Options"))
                .Headless()
                .SlowMo()
                .Build();
        }
    }
}
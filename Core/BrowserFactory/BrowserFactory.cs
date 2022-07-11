using System;
using System.Threading.Tasks;
using Core.Settings;
using Microsoft.Playwright;

namespace Core.BrowserFactory
{
    public class BrowserFactory : IBrowserFactory
    {
        private static readonly BrowserFactory Factory = new();

        protected BrowserFactory() { }


        private IPlaywright _playwright;

        public static BrowserFactory GetInstance()
        {
            return Factory;
        }

        public async Task<IBrowser> GetBrowserAsync(BrowserSettings browserSettings)
        {
            _playwright = await Playwright.CreateAsync();
            var browserType = GetBrowserType(browserSettings.Type);
            return await browserType.LaunchAsync(browserSettings.BrowserOptions);
        }

        private IBrowserType GetBrowserType(string browserType)
        {
            return browserType switch
            {
                "Chrome" => _playwright.Chromium,
                "Firefox" => _playwright.Firefox,
                "Webkit" => _playwright.Webkit,
                _ => throw new ArgumentException($"Parameter [{browserType}] is unavailable")
            };
        }
    }
}
using Core.BrowserFactory;
using Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using ReportPortal.Shared;
using System.Threading.Tasks;

namespace Tests
{
    public class AbstractTest
    {
        protected IBrowserContext BrowserContext;
        protected IPage Page;
        private IBrowser _browser;
        private static IConfiguration _configs;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _configs = InitSettings();
            await InitBrowserSettings(_configs);
        }


        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await _browser.DisposeAsync();
        }

        [SetUp]
        public async Task SetUp()
        {
            Context.Current.Log.Trace("Start SetUp");
            Page = await BrowserContext.NewPageAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            var res = TestContext.CurrentContext.Result.Outcome;
            if (res.Equals(ResultState.Failure) || res.Equals(ResultState.Error))
            {
                await TakeScreenShot();
            }
            await Page.CloseAsync();
        }

        private static IConfiguration InitSettings()
        {
            var configs = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true)
                .Build();
            return configs.GetSection("settings");
        }

        private async Task InitBrowserSettings(IConfiguration configuration)
        {
            var browserSettings = new BrowserSettings(_configs.GetSection("browser"));
            Context.Current.Log.Info($"Browser type - [{browserSettings.Type}]");
            _browser = await BrowserFactory.GetInstance()
                .GetBrowserAsync(browserSettings);
            var options = InitContextOptions();
            Context.Current.Log.Info(
                $"Browser options - [ViewPort - {options.ViewportSize?.Width}:{options.ViewportSize?.Height}]" +
                $"[BaseUrl - [{options.BaseURL}]");
            BrowserContext =
                await _browser.NewContextAsync(options);
        }

        private static BrowserNewContextOptions InitContextOptions()
        {
            var optionsBuilder = new ContextOptionsBuilder(_configs.GetSection("context"));
            return optionsBuilder
                .BaseUrl()
                .ViewPortSize()
                .Build();
        }

        private async Task TakeScreenShot()
        {
            var bytes = await Page.ScreenshotAsync();
            Context.Current.Log.Context.Log.Error("screenshots", "image/png", bytes);
        }
    }
}
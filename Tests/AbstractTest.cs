using System.Threading.Tasks;
using Core.BrowserFactory;
using Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using NUnit.Framework;

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
            _browser = await BrowserFactory.GetInstance()
                .GetBrowserAsync(new BrowserSettings(_configs.GetSection("browser")));
            var options = InitContextOptions();
            BrowserContext =
                await _browser.NewContextAsync(options);
        }


        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await _browser.DisposeAsync();
        }

        [SetUp]
        public async Task SetUp()
        {
            Page = await BrowserContext.NewPageAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await Page.CloseAsync();
        }

        private static IConfiguration InitSettings()
        {
            var configs = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true)
                .Build();
            return configs.GetSection("settings");
        }

        private static BrowserNewContextOptions InitContextOptions()
        {
            var optionsBuilder = new ContextOptionsBuilder(_configs.GetSection("context"));
            return optionsBuilder
                .BaseUrl()
                .ViewPortSize()
                .Build();
        }
    }
}
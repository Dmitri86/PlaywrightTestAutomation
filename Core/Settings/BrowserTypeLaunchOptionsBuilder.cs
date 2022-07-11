using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;

namespace Core.Settings
{
    public class BrowserTypeLaunchOptionsBuilder
    {
        private readonly BrowserTypeLaunchOptions _options;
        private readonly IConfiguration _configuration;

        public BrowserTypeLaunchOptionsBuilder(IConfiguration configurationSection)
        {
            _configuration = configurationSection;
            _options = new BrowserTypeLaunchOptions();
        }

        public BrowserTypeLaunchOptionsBuilder Headless()
        {
            _options.Headless = bool.Parse(_configuration.GetSection("Headless").Value);
            return this;
        }

        public BrowserTypeLaunchOptionsBuilder SlowMo()
        {
            _options.SlowMo = float.Parse(_configuration.GetSection("SlowMo").Value);
            return this;
        }

        public BrowserTypeLaunchOptions Build()
        {
            return _options;
        }
    }
}
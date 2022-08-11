using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;

namespace Core.Settings
{
    public class ContextOptionsBuilder
    {
        private readonly BrowserNewContextOptions _options;
        private readonly IConfiguration _configuration;

        public ContextOptionsBuilder(IConfiguration configurationSection)
        {
            _options = new BrowserNewContextOptions{Locale = "en-EN" };
            _configuration = configurationSection;
        }

        public ContextOptionsBuilder BaseUrl()
        {
            _options.BaseURL = _configuration.GetSection("BaseURL").Value;
            return this;
        }

        public ContextOptionsBuilder ViewPortSize()
        {
            _options.ViewportSize = new ViewportSize
            {
                Height = int.Parse(_configuration.GetSection("ViewportSize").GetSection("Height").Value),
                Width = int.Parse(_configuration.GetSection("ViewportSize").GetSection("Width").Value)
            };
            return this;
        }

        public BrowserNewContextOptions Build()
        {
            return _options;
        }
    }
}
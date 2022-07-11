using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace Steps
{
    public abstract class BaseStep
    {
        protected IBrowserContext BrowserContext;
        protected IPage Page;

        #region Actions

        public BaseStep InitPage(IBrowserContext browserContext)
        {
            BrowserContext = browserContext;
            Page = BrowserContext.NewPageAsync().Result;
            return this;
        }

        public BaseStep GoToPage(string url)
        {
            Page.GotoAsync(url).GetAwaiter().GetResult();
            return this;
        }

        #endregion


        #region Verification

        public BaseStep VerifyUrlStartWith(string expectedUrl)
        {
            var actualUrl = Page.Url;
            Assert.IsTrue(actualUrl.StartsWith(expectedUrl),
                $"The link [{actualUrl}] doesn't start with [{expectedUrl}]");
            return this;
        }

        #endregion
    }
}
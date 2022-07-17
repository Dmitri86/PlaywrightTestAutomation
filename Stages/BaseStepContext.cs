using Core;
using Microsoft.Playwright;
using NUnit.Framework;

namespace StepsContext
{
    public class BaseStepContext : TestStepContext<BaseStepContext>
    {
        protected IBrowserContext BrowserContext;
        protected IPage Page;

        #region Actions

        public BaseStepContext InitPage(IBrowserContext browserContext)
        {
            BrowserContext = browserContext;
            Page = BrowserContext.NewPageAsync().Result;
            return this;
        }

        public BaseStepContext GoToPage(string url)
        {
            Page.GotoAsync(url).GetAwaiter().GetResult();
            return this;
        }

        #endregion


        #region Verification

        public BaseStepContext VerifyUrlStartWith(string expectedUrl)
        {
            var actualUrl = Page.Url;
            Assert.IsTrue(actualUrl.StartsWith(expectedUrl),
                $"The link [{actualUrl}] doesn't start with [{expectedUrl}]");
            return this;
        }

        #endregion
    }
}
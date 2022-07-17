using Core;
using Microsoft.Playwright;
using NUnit.Framework;

namespace StepsContext
{
    public abstract class BaseStepContext
    {
        protected IPage Page;

        protected BaseStepContext(IPage page)
        {
            Page = page;
        }


        #region Actions


        public void GoToPage(string url)
        {
            Page.GotoAsync(url).GetAwaiter().GetResult();
        }

        #endregion


        #region Verification

        public void VerifyUrlStartWith(string expectedUrl)
        {
            var actualUrl = Page.Url;
            Assert.IsTrue(actualUrl.StartsWith(expectedUrl),
                $"The link [{actualUrl}] doesn't start with [{expectedUrl}]");
        }

        #endregion
    }
}
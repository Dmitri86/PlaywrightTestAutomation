using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

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


        public Task GoToPage(string url = "")
        {
            url = string.IsNullOrEmpty(url) ? "/" : url;
            return Page.GotoAsync(url);
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
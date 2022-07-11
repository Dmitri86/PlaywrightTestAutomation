using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class FirstTest : AbstractTest
    {
        [Test]
        public async Task VerifyHomeUrl()
        {
            const string expectedUrl = "https://skyup.aero";

            var page = await BrowserContext.NewPageAsync();
            await page.GotoAsync("/");
            var actualUrl = page.Url;
            Assert.IsTrue(actualUrl.StartsWith(expectedUrl),
                $"The link [{actualUrl}] doesn't start with [{expectedUrl}]");
        }
    }
}
using System.Threading.Tasks;
using NUnit.Framework;
using Steps;

namespace Tests
{
    [TestFixture]
    public class FirstTest : AbstractTest
    {
        [Test]
        public void VerifyHomeUrl()
        {
            const string expectedUrl = "https://skyup.aero";

            new HomePageStep()
                .InitPage(BrowserContext)
                .GoToPage("/")
                .VerifyUrlStartWith(expectedUrl);
        }
    }
}
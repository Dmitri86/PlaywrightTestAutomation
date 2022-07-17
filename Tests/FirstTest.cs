using System.Threading.Tasks;
using Core;
using NUnit.Framework;
using StepsContext;

namespace Tests
{
    [TestFixture]
    public class FirstTest : AbstractTest
    {
        [Test]
        public void VerifyHomeUrl()
        {
            const string expectedUrl = "https://skyup.aero";

            TestStepContext<HomeStepContext>.Instance
                .InitPage(BrowserContext)
                .GoToPage("/")
                .VerifyUrlStartWith(expectedUrl);
        }
    }
}
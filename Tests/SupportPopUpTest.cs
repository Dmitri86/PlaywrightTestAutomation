using System.Threading.Tasks;
using NUnit.Framework;
using StepsContext;

namespace Tests
{
    [TestFixture]
    public class SupportPopUpTest : AbstractTest
    {
        [Test]
        public async Task VerifyPopUpVisible()
        {
            var homeContext = new HomeStepContext(Page);
            var supportContext = new SupportStepContext(Page);

            await homeContext.GoToPage();
            await supportContext.VerifyButtonSupportVisible();
        }
    }
}
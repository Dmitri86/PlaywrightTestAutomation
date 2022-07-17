using NUnit.Framework;
using StepsContext;

namespace Tests
{
    [TestFixture]
    public class SupportPopUpTest : AbstractTest
    {
        [Test]
        public void VerifyPopUpVisible()
        {
            var homeContext = new HomeStepContext(Page);
            homeContext.GoToPage("/");
            var supportContext = new SupportStepContext(Page);
            supportContext.VerifyButtonSupportVisible();
        }
    }
}
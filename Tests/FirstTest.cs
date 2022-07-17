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

            var homeSteps = new HomeStepContext(Page);
            homeSteps.GoToPage("/");
            homeSteps.VerifyUrlStartWith(expectedUrl);
        }
    }
}
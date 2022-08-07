using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using ReportPortal.Shared;
using StepsContext;

namespace Tests
{
    [TestFixture]
    public class CareerTest : AbstractTest
    {
        [Test]
        public async Task VerifyCareerTest()
        {
            Context.Current.Log.Info("start test!!!");
            const string career = "Career";
            const string title = "career for U";
            var items = new List<string> { "Vacancies", "Academy", "Team of inspiration" };

            var homeContext = new HomeStepContext(Page);
            var supportContext = new SupportStepContext(Page);
            var careerContext = new CareerStepContext(Page);

            await supportContext.GoToPage();
            await supportContext.ClickXButton();

            await homeContext.ClickNavigationItem(career);
            await careerContext.VerifyTitleIsCorrect(title);
            await careerContext.VerifyCareerItemsAreCorrect(items);
            Context.Current.Log.Fatal("end test!!!");
        }
    }
}
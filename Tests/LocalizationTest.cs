using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using NUnit.Framework;
using StepsContext;

namespace Tests
{
    [TestFixture]
    public class LocalizationTest : AbstractTest
    {
        [Test]
        public async Task VerifyLocalizationUkElements()
        {
            var expectedItems = new List<string>
                {"Мої бронювання", "Пасажирам", "Маршрути", "Всі рейси", "Кар'єра", "Проєкти", "Контакти"};

            var homeSteps = new HomeStepContext(Page);
            var supportContext = new SupportStepContext(Page);

            await homeSteps.GoToPage();
            await supportContext.ClickXButton();
            await homeSteps.ClickChangeLanguage();
            await homeSteps.ClickSelectUkLanguage();
            var actualNavigationItems = await homeSteps.GetNavigationLabels();
            await homeSteps.VerifyNavigationItemHaveCorrectName(expectedItems, actualNavigationItems);
        }

        [Test]
        public async Task VerifyLocalizationEnElements()
        {
            var expectedItems = new List<string>
                {"My bookings", "Passengers", "Routes", "All flights", "Career", "Projects", "Contacts"};

            var homeSteps = new HomeStepContext(Page);
            var supportContext = new SupportStepContext(Page);

            await homeSteps.GoToPage();
            await supportContext.ClickXButton();
            var actualNavigationItems = await homeSteps.GetNavigationLabels();
            await homeSteps.VerifyNavigationItemHaveCorrectName(expectedItems, actualNavigationItems);
        }
    }
}
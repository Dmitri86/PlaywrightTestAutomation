using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;
using Pages;

namespace StepsContext
{
    public class CareerStepContext : BaseStepContext
    {
        private readonly CareerPage _careerPage;

        public CareerStepContext(IPage page) : base(page)
        {
            _careerPage = new CareerPage(page);
        }

        public async Task VerifyTitleIsCorrect(string expected)
        {
            var actual = await _careerPage.Title.GetText();
            Assert.AreEqual(expected, actual, "Verify 'Career' page title is correct");
        }

        public async Task VerifyCareerItemsAreCorrect(IEnumerable<string> expected)
        {
            var actual = await _careerPage.CareerItems.GetItemsText();
            Assert.AreEqual(expected, actual, "Verify career items are correct");
        }
    }
}
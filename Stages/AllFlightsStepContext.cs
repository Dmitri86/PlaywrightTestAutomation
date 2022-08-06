using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;
using Pages;

namespace StepsContext
{
    public class AllFlightsStepContext : BaseStepContext
    {
        private readonly AllFlightsPage _allFlightsPage;

        public AllFlightsStepContext(IPage page) : base(page)
        {
            _allFlightsPage = new AllFlightsPage(Page);
        }

        public Task ClickNavigationItem(string item)
        {
            return _allFlightsPage.Items.GetItemByText(item).Click();
        }

        public Task SetSearch(string text)
        {
            return _allFlightsPage.Search.SetText(text);
        }

        public async Task VerifyDepartureIsCorrect(string expectedDeparture)
        {
            var actualDeparture = await _allFlightsPage.FromCity.GetText();
            Assert.AreEqual(expectedDeparture, actualDeparture, "Verify departure value is correct");
        }

        public async Task VerifyDestinationIsCorrect(string expectedDestination)
        {
            var actualDestination = await _allFlightsPage.ToCity.GetText();
            Assert.AreEqual(expectedDestination, actualDestination, "Verify destination value is correct");
        }

        public async Task VerifyNoSearchResult()
        {
            const string expected = "No search results";
            var actual = await _allFlightsPage.NoSearchResult.GetText();
            Assert.AreEqual(expected, actual, "Verify no search result");
        }
    }
}
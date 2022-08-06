using System.Threading.Tasks;
using NUnit.Framework;
using StepsContext;

namespace Tests
{
    [TestFixture]
    public class FlightTest : AbstractTest
    {
        [Test]
        public async Task VerifyFlight()
        {
            const string allFlights = "All flights";
            const string summerFlights = "Summer flights";
            const string country = "Turkey";
            const string departure = "Kyiv";
            const string destination = "Istanbul";

            var supportContext = new SupportStepContext(Page);
            var homeContext = new HomeStepContext(Page);
            var allFlightContext = new AllFlightsStepContext(Page);

            await supportContext.GoToPage();
            await supportContext.ClickXButton();

            await homeContext.ClickNavigationItem(allFlights);

            await allFlightContext.SetSearch(country);
            await allFlightContext.VerifyDepartureIsCorrect(departure);
            await allFlightContext.VerifyDestinationIsCorrect(destination);

            await allFlightContext.ClickNavigationItem(summerFlights);
            await allFlightContext.VerifyNoSearchResult();
        }
    }
}
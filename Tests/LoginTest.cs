using NUnit.Framework;
using StepsContext;

namespace Tests
{
    [TestFixture]
    public class LoginTest : AbstractTest
    {
        [Test]
        public void VerifyLogIn()
        {
            var homeContext = new HomeStepContext(Page);
            var supportContext = new SupportStepContext(Page);
            var authorizationContext = new AuthorizationStepContext(Page);

            homeContext.GoToPage("/");
            
            supportContext.ClickXButton();
            homeContext.ClickLogIn();
            
            authorizationContext.ClickLogIn();
            authorizationContext.SetEmail("alexssom01@gmail.com");
            authorizationContext.SetPassword("123456");
            authorizationContext.ClickFinalLogin();
            homeContext.ClickCabinet();
            homeContext.VerifyUserName("alex");
        }
    }
}
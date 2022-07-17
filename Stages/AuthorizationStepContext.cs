using Microsoft.Playwright;
using Pages;

namespace StepsContext
{
    public class AuthorizationStepContext : BaseStepContext
    {
        private readonly AuthorizationPage _authorizationPage;

        public AuthorizationStepContext(IPage page) : base(page)
        {
            _authorizationPage = new AuthorizationPage(Page);
        }

        public void ClickLogIn()
        {
             _authorizationPage.LogIn.Click().GetAwaiter().GetResult();
        }

        public void ClickFinalLogin()
        {
            _authorizationPage.FinalLogin.Click().GetAwaiter().GetResult();
        }

        public void SetEmail(string text)
        {
             _authorizationPage.Email.SetText(text).GetAwaiter().GetResult();
        }

        public void SetPassword(string text)
        {
            _authorizationPage.Password.SetText(text).GetAwaiter().GetResult();
        }
    }
}
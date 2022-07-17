using Core.Controls.Elements;
using Microsoft.Playwright;

namespace Pages
{
    public class AuthorizationPage
    {
        public AuthorizationPage(IPage page)
        {
            Email = new TextBox(page.Locator("//input[@id='logInEmail']"));
            Password = new TextBox(page.Locator("//input[@name='password' and not(@id)]"));
            LogIn = new Button(page.Locator("//button[@type='submit' and contains(@class, 'js-show')]"));
            FinalLogin = new Button(page.Locator("//button[@id='logInBtn']"));

        }

        public TextBox Email;
        public TextBox Password;
        public Button LogIn;
        public Button FinalLogin;
    }
}
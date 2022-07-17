using Core.Controls.Elements;
using Microsoft.Playwright;

namespace Pages
{
    public class HomePage
    {
        public HomePage(IPage page)
        {
            Login = new Button(page.Locator("//button[@id='headerLogin']"));
            Cabinet = new Button(page.Locator("//button[@id='headerCabinet']"));
            UserName = new Label(page.Locator("//p[@class='cabinet-nav__user-name']"));
        }

        public Button Login;
        public Button Cabinet;
        public Label UserName;
    }
}
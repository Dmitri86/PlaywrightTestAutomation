using Core.Controls.Elements;
using Microsoft.Playwright;

namespace Pages
{
    public class HomePage
    {
        public HomePage(IPage page)
        {
            NavigationItems = new Navigation(page.Locator("//ul[contains(@class, 'header__nav')]//li"));
            Language = new Button(page.Locator("#showLangsDesktop"));
            LanguageUk = new Button(page.Locator("//ul[@id='headerLangListDesktop']//button[@data-lang='uk']"));
            Login = new Button(page.Locator("//button[@id='headerLogin']"));
            Cabinet = new Button(page.Locator("//button[@id='headerCabinet']"));
            UserName = new Label(page.Locator("//p[@class='cabinet-nav__user-name']"));
        }

        public Navigation NavigationItems;
        public Button Language;
        public Button LanguageUk;
        public Button Login;
        public Button Cabinet;
        public Label UserName;
    }
}
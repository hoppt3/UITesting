using Framework.Test.UI.Helper;
using OpenQA.Selenium;

namespace TestUI.Pages
{
    partial class LoginPage : SeleniumHelper
    {
        private readonly IWebDriver driver;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public LoginPage Login(string username, string password)
        {
            InputText(By.CssSelector(LoginUsernameTxtCss), username);
            InputText(By.CssSelector(LoginUsernameTxtCss), password);
            ClickOnButton(By.CssSelector(LoginSignInBtnCss));
            return this;
        }
    }
}

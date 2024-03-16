
using Framework.Test.UI.Helper;
using OpenQA.Selenium;

namespace ProjectName.Test.UI.Pages
{
    partial class LogoutPage : SeleniumHelper
    {
        private IWebDriver driver;
        public LogoutPage(IWebDriver driver): base(driver)
        {
            this.driver = driver;
        }

        public LogoutPage Logout()
        {
            ClickOnButton(By.CssSelector(LogoutIconCss));
            //wait until login form show up
            return this;
        }
    }
}

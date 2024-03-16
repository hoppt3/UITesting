using Framework.Test.UI.Helper;
using OpenQA.Selenium;

namespace TestUI.Pages
{
    partial class OutsideLoginPage : SeleniumHelper
    {
        private IWebDriver driver;
        public OutsideLoginPage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;
        }

        public OutsideLoginPage Login(string password)
        {
            InputText(By.CssSelector(OutsidePasswordTxtCss), password);
            ClickOnButton(By.CssSelector(OutsideLoginBtnCss));
            return this;
        }
    }
}

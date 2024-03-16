using Framework.Test.UI.Helper;
using OpenQA.Selenium;

namespace TestUI.Pages
{
    partial class ManufacturersPage : SeleniumHelper
    {
        private IWebDriver driver;
        public ManufacturersPage(IWebDriver driver) :base(driver)
        {
            this.driver = driver;
        }

        public ManufacturersPage InputManufacturerInformation(string name)
        {
            //only name so can input name, but when input alot fields should input by an object
            InputText(By.CssSelector(ManufacturerDetailsNameTxtCss), name);
            return this;
        }

        public ManufacturersPage InputManufacturerInformationThenSave(string name)
        {
            InputManufacturerInformation(name);
            ClickOnButton(By.CssSelector(ManufacturerSaveBtnCss));
            return this;
        }
    }
}

using System.Drawing;
using Framework.Test.UI.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectName.Test.UI.Data;

namespace TestUI
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string baseUrl;

        protected IWebDriver OpenBrowser()
        {
            IWebDriver driver = BrowserDriver.GetBrowser(TestEnvironmentData.GetBrowserName());
            driver.Url = TestEnvironmentData.GetBaseUrl();
            driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Manage().Window.Maximize();
            return driver;
        }

        public void CloseBrowser(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}

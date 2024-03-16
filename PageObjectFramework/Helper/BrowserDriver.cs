using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Test.UI.Helper
{
    public class BrowserDriver
    {
        public static IWebDriver GetBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    ChromeOptions chromeOption = new ChromeOptions();
                    return new ChromeDriver(chromeOption);
                case "ChromeHeadless":
                    ChromeOptions headlessOption = new ChromeOptions();
                    headlessOption.AddArguments("--headless");
                    return new ChromeDriver(headlessOption);
                case "Firefox":
                    return new FirefoxDriver();
                default:
                    return new ChromeDriver();

            }
        }
    }
}

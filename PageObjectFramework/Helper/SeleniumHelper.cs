using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Test.UI.Helper
{
    public class SeleniumHelper
    {
        public readonly IWebDriver driver;
        public const int Timeout = 15;

        public SeleniumHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Waits
        /// <summary>
        /// Waits for 15 seconds the element, wait until the element is visible
        /// </summary>
        public IWebElement WaitForElementToBeVisible(string css, int timeout = Timeout)
        {
            try
            {
                WebDriverWait webDriverWait = new(driver, new TimeSpan(0, 0, timeout));
                return webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(css)));
            }
            catch (StaleElementReferenceException)
            {
                throw new StaleElementReferenceException();
            }
            catch (Exception ex)
            {
                string textError = $"ERROR: " + ex.Message + $" Waiting {timeout}s for WebElement {css}";
                throw new TimeoutException(textError);
            }
        }

        #endregion Waits
        #region Texts
        /// <summary>
        /// Input text
        /// </summary>
        public SeleniumHelper InputText(By locator, string text)
        {
            //should wait until element display
            IWebElement textboxElement = driver.FindElement(locator);
            textboxElement.Clear();
            textboxElement.SendKeys(text);
            return this;
        }
        #endregion Texts

        #region Actions
        /// <summary>
        /// Input text
        /// </summary>
        public SeleniumHelper ClickOnButton(By locator)
        {
            IWebElement buttonElement = driver.FindElement(locator);
            //should wait until button can be clickable
            buttonElement.Click();
            return this;
        }
        #endregion Actions
    }
}

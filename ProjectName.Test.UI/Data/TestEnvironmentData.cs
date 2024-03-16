namespace ProjectName.Test.UI.Data
{
    public class TestEnvironmentData
    {
        /// <summary>
        /// The browser under test, eg. Chrome, HeadlessChrome, Firefox
        /// </summary>
        /// 
        public static string browser = "Chrome";
        /// <summary>
        /// The test environment used. eg. Automation, Dev, Test, Preprod
        /// Currently only Automation is supported
        /// </summary>
        private static readonly string dockerBaseUrl = "http://localhost:4999/";
        private static readonly string automationBaseUrl = "https://sgate-automation.sghrz-int.com/";
        /// <summary>
        /// The browser under test
        /// </summary>
        public static string GetBrowserName()
        {
            return browser;
        }

        /// <summary>
        /// Get the base URL
        /// </summary>
        /// <returns></returns>
        public static string GetBaseUrl()
        {
            return Environment.GetEnvironmentVariable("AUTOMATION") == null ? dockerBaseUrl : automationBaseUrl;
        }
    }
}

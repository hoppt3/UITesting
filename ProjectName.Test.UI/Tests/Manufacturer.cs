using Framework.Test.UI.Helper;
using NUnit.Framework;
using ProjectName.Test.UI.Pages;
using TestUI.Pages;

namespace TestUI.Tests
{
    [TestFixture]
    public class Manufacturer : BaseTest
    {
        private string outsidePassword = "osterhase";
        private string username = "admin";
        private string password = "sgate";
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver = OpenBrowser();
        }

        [SetUp]
        public void Setup()
        {
            new OutsideLoginPage(driver)
                .Login(outsidePassword);
            new LoginPage(driver)
                .Login(username, password);
        }

        [TearDown]
        public void TearDown() 
        {
            new LogoutPage(driver)
                .Logout();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() 
        {
            CloseBrowser(driver);
        }

        [Test]
        public void CreateManufacturerWithValidName()
        {
            string manufacturerName = "Manufactuer name " + RandomHelper.GetRandomText(5);

            //test 3


            //
            //

            new ManufacturersPage(driver)
                .InputManufacturerInformationThenSave(manufacturerName);
        }
    }
}

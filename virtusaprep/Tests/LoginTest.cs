using virtusaprep.Base;
using virtusaprep.Pages;
using virtusaprep.Utils;

namespace virtusaprep.Tests
{
    public class LoginTest : BaseTest
    {
         
        [Test]
        public void TestValidLogin()
        {
            var loginData = TestDataReader.GetValidLogin();
            var loginPage = new LoginPage(Driver);
            loginPage.Login(loginData.Username, loginData.Password);

            Assert.IsTrue(Driver.Url.Contains("dashboard"), "Expected to land on dashboard.");
        }

        [Test]
        public void TestInvalidLogin()
        {
            var loginData = TestDataReader.GetInvalidLogin();
            var loginPage = new LoginPage(Driver);
            loginPage.Login(loginData.Username, loginData.Password);

            Assert.IsFalse(Driver.Url.Contains("dashboard"), "Expected to throw error");
        }
    }
}
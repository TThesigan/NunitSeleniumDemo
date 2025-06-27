using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace virtusaprep.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Login(string username, string password)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            var usernameField = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("username")));
            var passwordField = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            var loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[type='submit']")));

            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            loginButton.Click();
        }

        public string CheckUser() 
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var userName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[@class='oxd-userdropdown-name']")));
            return userName.Text;
        }
    }
}
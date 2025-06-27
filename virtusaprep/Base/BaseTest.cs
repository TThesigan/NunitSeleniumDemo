using OpenQA.Selenium;
using virtusaprep.Utils;

namespace virtusaprep.Base
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public virtual void Setup()
        {
            Driver = DriverFactory.InitDriver();
            Driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }

        [TearDown]
        public virtual void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
        }
    }
}

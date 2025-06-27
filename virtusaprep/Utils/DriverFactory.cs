using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace virtusaprep.Utils
{
    public static class DriverFactory
    {
        public static IWebDriver InitDriver()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("start-maximized");
            return new EdgeDriver(options);
        }
    }
}

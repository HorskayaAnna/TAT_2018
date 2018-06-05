using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV_10
{
    public static class DriverInstance
    {
        public static IWebDriver driver = new ChromeDriver(@"C:\Users\horsk\Desktop");

        public static IWebDriver GetInstance()
        {
            return driver;
        }
    }
}

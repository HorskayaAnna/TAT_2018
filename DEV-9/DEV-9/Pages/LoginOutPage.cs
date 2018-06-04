using OpenQA.Selenium;
using DEV_9.Locators;

namespace DEV_9.Pages
{
    class LogOutPage
    {
        private IWebDriver driver = DriverInstance.GetInstance();

        public void LogOut()
        {
            driver.FindElement(By.XPath(XpathLocators.LoginOutMeny)).Click();
            driver.FindElement(By.XPath(XpathLocators.LoginOutButton)).Click();
        }
    }
}

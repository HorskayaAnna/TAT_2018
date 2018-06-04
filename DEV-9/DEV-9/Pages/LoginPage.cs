using OpenQA.Selenium;
using DEV_9.Locators;

namespace DEV_9.Pages
{
    class LoginPage
    {
        public static IWebDriver driver = DriverInstance.GetInstance();

        public void Login(string login, string password)
        {
            driver.Navigate().GoToUrl("https://vk.com/");
            IWebElement webElement = driver.FindElement(By.XPath(XpathLocators.LoginBlock));
            webElement.FindElement(By.XPath(XpathLocators.LoginInputForm)).SendKeys(login);
            webElement.FindElement(By.XPath(XpathLocators.PasswordInputForm)).SendKeys(password);
            webElement.FindElement(By.XPath(XpathLocators.LoginButton)).Click();
        }
    }
}

using OpenQA.Selenium;
using DEV_9.Locators;
using System;
using OpenQA.Selenium.Support.UI;

namespace DEV_9.Pages
{
    class MessageArea
    {
        public static IWebDriver driver = DriverInstance.GetInstance();
        private IWebElement msgSpace = driver.FindElement(By.XPath(XpathLocators.MessageSpace));
        private IWebElement sendMsgBtn = driver.FindElement(By.XPath(XpathLocators.SendMessagButton));

        public void SendMessage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(XpathLocators.MessageSpace)));
            msgSpace.SendKeys("Test message. Don't reply");
            sendMsgBtn.Click();
        }
    }
}

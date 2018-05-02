using OpenQA.Selenium;

namespace DEV_9
{
    class Login
    {
        IWebDriver driver;
        public Login()
        {
            driver = DriverInstance.GetInstance();
        }

        public void LoginVk(string login, string password)
        {
            driver.Navigate().GoToUrl("https://vk.com/");
            IWebElement webElement = driver.FindElement(By.XPath(@"//form[@name='login']"));
            webElement.FindElement(By.XPath(@"//input[@id='index_email']")).SendKeys(login);
            webElement.FindElement(By.XPath(@"//input[@id='index_pass']")).SendKeys(password);
            webElement.FindElement(By.XPath(@"//button[@id='index_login_button']")).Click();
        }
    }
}


using OpenQA.Selenium;

namespace DEV_9
{
    /// <summary>
    /// Class which loging out vk
    /// </summary>
    public class LogOut
    {
        IWebDriver driver;
        public LogOut()
        {
            driver = DriverInstance.GetInstance();
        }
        public void LoginOut()
        {
            driver.FindElement(By.XPath("//a[@id='top_profile_link']")).Click();
            driver.FindElement(By.XPath("//a[@id='top_logout_link']")).Click();
        }
    }
}




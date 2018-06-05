using System;
using OpenQA.Selenium;
using DEV_9.Locators;

namespace DEV_9.Pages
{
    /// <summary>
    /// Class, which check are user's name the same with vk page name
    /// </summary>
    class MyPage
    {
        IWebDriver driver;
        public AreMyPage()
        {
            driver = DriverInstance.GetInstance();
        }

        public void CheckMyPage(string name)
        {
            driver.FindElement(By.XPath()).Click(XpathLocators.ProfilePageButton);
            string myName = driver.FindElement(By.XPath(XpathLocators.Name)).Text;
            if (name == myName)
            {
                Console.WriteLine("it is " + name + "'s page");
            }
            else
            {
                Console.WriteLine("it is not " + name + "'s page");
            }
        }
    }
}

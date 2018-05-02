using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace DEV_9
{
    class FirstFriends
    {
        IWebDriver driver;
        public FirstFriends()
        {
            driver = DriverInstance.GetInstance();
        }

        public void FirstFiveFriends()
        {
            driver.Navigate().GoToUrl("https://vk.com/friends");
            List<IWebElement> friends = new List<IWebElement>(driver.FindElements(By.XPath("//div[@class='friends_user_info']")));
            Console.WriteLine("My first five friends");
            foreach (IWebElement element in friends)
            {
                Console.WriteLine(element.FindElement(By.XPath("div/a")).Text.Trim());
            }
        }
    }
}

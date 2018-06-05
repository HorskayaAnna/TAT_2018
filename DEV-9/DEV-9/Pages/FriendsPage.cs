using OpenQA.Selenium;
using DEV_9.Locators;
using System.Collections.Generic;
using System;
using System.Threading;

namespace DEV_9.Pages
{
    class FriendsPage
    {
        public static IWebDriver driver = DriverInstance.GetInstance();
        private List<IWebElement> friends;
        private IWebElement searchFriend;

        public void FirstFiveFriends()
        {
            driver.Navigate().GoToUrl("https://vk.com/friends");
            friends = new List<IWebElement>(driver.FindElements(By.XPath(XpathLocators.FriendsInfo)));
            Console.WriteLine("My first five friends");
            int counter=0;
            foreach (IWebElement element in friends)
            {
                Console.WriteLine(element.FindElement(By.XPath("div/a")).Text.Trim());
                if (++counter == 5)
                {
                    break;
                }
            }
        }

        public void OpenFriendPage(string name, string id)
        {
            Thread.Sleep(10);
            driver.Navigate().GoToUrl("https://vk.com/friends");
            Thread.Sleep(20);
            searchFriend = driver.FindElement(By.Id("s_search"));
            searchFriend.SendKeys(name);
            var chooseFriend = driver.FindElement(By.XPath($"//*[@id=\"friends_user_row{id}\"]/div[4]/a"));
            chooseFriend.Click();
            Thread.Sleep(20);
            Pages.MessageArea message = new Pages.MessageArea();
            message.SendMessage();
        }
    }
}

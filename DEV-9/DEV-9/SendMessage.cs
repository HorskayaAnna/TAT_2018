using System;
using OpenQA.Selenium;

namespace DEV_9
{
    class SendMessage
    {
        IWebDriver driver;
        IWebElement searchFriend;
        private IWebElement msgSpace ;
        private IWebElement sendMsgBtn;

        public SendMessage( )
        {
            driver = DriverInstance.GetInstance();
            searchFriend = driver.FindElement(By.Id("s_search"));
            msgSpace = driver.FindElement(By.XPath("//*[@id=\"mail_box_editable\"]"));
            sendMsgBtn = driver.FindElement(By.XPath("//*[@id=\"mail_box_send\"]"));
        }

        public void SendingMessage(string name, int id)
        {
            driver.Navigate().GoToUrl("https://vk.com/friends");
            searchFriend.SendKeys(name);
            var chooseFriend = driver.FindElement(By.XPath($"//*[@id=\"friends_user_row{id}\"]/div[4]/a"));       
            chooseFriend.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            msgSpace.SendKeys("Я отправил это сообщение в автоматическом режиме. Не обращай внимания");
            sendMsgBtn.Click();
        }
    }
}

using System;
using OpenQA.Selenium;

namespace DEV_9
{
    /// <summary>
    /// Class, which send message to chosen by user name
    /// </summary>
    class SendMessage
    {
        IWebDriver driver;
        IWebElement searchFriend;
        private IWebElement msgSpace ;
        private IWebElement sendMsgBtn;

        public SendMessage( )
        {
            driver = DriverInstance.GetInstance();
            // = driver.FindElement(By.Id("s_search"));
           // msgSpace = driver.FindElement(By.XPath("//*[@id=\"mail_box_editable\"]"));
           // sendMsgBtn = driver.FindElement(By.XPath("//*[@id=\"mail_box_send\"]"));
        }

        public void SendingMessage(string name, int id)
        {
            driver.Navigate().GoToUrl("https://vk.com/friends");
            searchFriend= driver.FindElement(By.XPath("body"));
            searchFriend.SendKeys(name);
            var chooseFriend = driver.FindElement(By.XPath($"//*[@id=\"friends_user_row{id}\"]/div[4]/a"));
            chooseFriend.FindElement(By.XPath($"//a[@href='write{id}']")).Click();
            //chooseFriend.Click();
            msgSpace = driver.FindElement(By.XPath("//*[@id=\"mail_box_editable\"]"));
            msgSpace.SendKeys("I have sent this message in the automatic mode. Don't pay attention");
            sendMsgBtn = sendMsgBtn = driver.FindElement(By.XPath("//*[@id=\"mail_box_send\"]"));
            sendMsgBtn.Click();
        }
    }
}

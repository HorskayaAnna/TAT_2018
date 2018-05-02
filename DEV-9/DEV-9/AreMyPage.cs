using System;
using OpenQA.Selenium;

namespace DEV_9
{
    class AreMyPage
    {
        IWebDriver driver;
        public AreMyPage()
        {
            driver = DriverInstance.GetInstance();
        }

        public void CheckMyPage()
        { 
            driver.FindElement(By.XPath(@"//li[@id = 'l_pr']")).Click();
            string myName = driver.FindElement(By.XPath("//div/h2[@class=\"page_name\"]")).Text;
            Console.WriteLine(myName);
        }


    }
}

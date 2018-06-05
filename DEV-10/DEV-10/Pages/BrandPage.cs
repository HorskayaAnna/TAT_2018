using DEV_10.Locators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_10.Pages
{
    /// <summary>
    /// Class which represents page of
    /// chosen by user brand 
    /// </summary>
    class BrandPage
    {
        private IWebDriver driver = DriverInstance.GetInstance();
        private Dictionary<string, int> models;

        public BrandPage()
        {
            models = new Dictionary<string, int>();
            foreach (IWebElement element in driver.FindElements(By.XPath(XpathLocators.Model)))
            {
                models[element.FindElement(By.TagName("span")).Text] = int.Parse(element.FindElement(By.TagName("small")).Text);
            }
            models = models.OrderBy(x => x.Value).Reverse().ToDictionary(y => y.Key, y => y.Value);
        }

        /// <summary>
        /// This method outputs sorted hastable of cars
        /// </summary>
        public void PrintModelsWithAmount()
        {
            foreach (KeyValuePair<string, int> x in models)
            {
                Console.WriteLine($"{x.Key} - {x.Value}");
            }
        }
    }
}

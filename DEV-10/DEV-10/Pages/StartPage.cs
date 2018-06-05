using OpenQA.Selenium;
using DEV_10.Locators;

namespace DEV_10.Pages
{
    /// <summary>
    /// class which represents main page 
    /// of av.by
    /// </summary>
    class StartPage
    {
        public static IWebDriver driver = DriverInstance.GetInstance();
        public string brandName;
        public string brandXpath;

        public StartPage(string paramBrand)
        {
            brandName = paramBrand;
            brandXpath = XpathLocators.GetChosenBrandXpath(paramBrand);
        }

        /// <summary>
        /// This method click on the bottin, which 
        /// show all brands 
        /// </summary>
        public void ShowAllBrands()
        {
            driver.FindElement(By.XPath(XpathLocators.ShowAllBrandsButton)).Click();
        }

        /// <summary>
        /// This method checks wheser input 
        /// brand is valid and if it is goes to brand's page and r
        /// </summary>
        /// <returns>
        /// Brand page
        /// </returns>
        public BrandPage GoToChosenBrandPage()
        {
            try
            {
                driver.FindElement(By.XPath(brandXpath));
                driver.Navigate().GoToUrl("https://cars.av.by/" + brandName.ToLower());
                return new BrandPage();
            }
            catch
            {
                throw new NoSuchElementException(message: "no such brand in catalog");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10.Locators
{
    class XpathLocators
    {
        //start page
        public static readonly string ShowAllBrandsButton = "//a[@class='js-brands-show-all']";

        //cars page
        public static readonly string Model = "//ul[@class='brandslist']/li";
        public static readonly string ModelAmount = "";

        /// <summary>
        /// This method returns Xpath of chosen by user car brand 
        /// </summary>
        /// <param name="paramBrand">
        /// Input by user brend name
        /// </param>
        /// <returns>
        /// Xpath of valid car
        /// </returns>
        public static string GetChosenBrandXpath(string paramBrand)
        {
            return $"//ul[@class='brandslist']/li//span[text() = '{paramBrand}']";
        }
    }
}

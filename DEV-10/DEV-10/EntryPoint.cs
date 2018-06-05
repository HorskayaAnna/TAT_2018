using System;
using DEV_10.Pages;

namespace DEV_10
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                DriverInstance.GetInstance().Navigate().GoToUrl("https://av.by/");
                Pages.StartPage page = new StartPage(args[0]);
                page.ShowAllBrands();
                BrandPage carsPage = page.GoToChosenBrandPage();
                carsPage.PrintModelsWithAmount();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message)
;            }
        }
    }
}

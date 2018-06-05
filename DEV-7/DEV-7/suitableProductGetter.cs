using System.Collections.Generic;

namespace DEVTask7
{
    /// <summary>
    /// command for getting suitable product in the storage 
    /// </summary>
    class SuitableProductGetter : ICommand<List<Product>>
    {
        Catalog catalog;
        Product chosenByUserProduct;

        public List<Product> Execute()
        {
            return catalog.GetSuitableProducts(chosenByUserProduct);
        }

        public void SetCatalog(Catalog paramCatalog)
        {
            catalog = paramCatalog;
        }

        public void SetChosenByUserProduct(Product paramChosenByUserProduct)
        {
            chosenByUserProduct = paramChosenByUserProduct;
        }
    }
}

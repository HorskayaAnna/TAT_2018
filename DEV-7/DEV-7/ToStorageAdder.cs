namespace DEVTask7
{
    /// <summary>
    /// Comand for adding product to the storage
    /// </summary>
    class ToStorageAdder : ICommand<bool>
    {
        Storage storage;
        Product chosenByUserProduct;

        public bool Execute()
        {
            storage.AddProductToStorage(chosenByUserProduct);
            return true;
        }

        public void SetStorage(Storage paramStorage)
        {
            storage = paramStorage;
        }

        public void SetChosenByUserProduct(Product paramChosenByUserProduct)
        {
            chosenByUserProduct = paramChosenByUserProduct;
        }
    }
}

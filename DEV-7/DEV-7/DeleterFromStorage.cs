namespace DEVTask7
{
    /// <summary>
    /// Class which delete bought product
    /// </summary>
    class DeleterFromStorage : ICommand<bool>
    {
        Storage storage;
        Product chosenByUserProduct;

        public bool Execute()
        {
            storage.RemoveProduct(chosenByUserProduct);
            return true;
        }

        /// <summary>
        /// Storage setter
        /// </summary>
        /// <param name="paramStorage">
        /// Storage to set
        /// </param>
        public void SetStorage(Storage paramStorage)
        {
            storage = paramStorage;
        }

        /// <summary>
        /// Chosen by user product setter  
        /// </summary>
        /// <param name="paramChosenByUserProduct">
        /// Chosen by user product
        /// </param>
        public void SetChosenByUserProduct(Product paramChosenByUserProduct)
        {
            chosenByUserProduct = paramChosenByUserProduct;
        }
    }
}

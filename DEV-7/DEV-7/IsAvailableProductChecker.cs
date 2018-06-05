namespace DEVTask7
{
    /// <summary>
    /// Command, which checks if the product is in the storage or not 
    /// </summary>
    class IsAvailableProductChecker : ICommand<bool>
    {
        Storage storage;
        Product chosenByUserProduct;

        public bool Execute()
        {
            return storage.IsAvailableProduct(chosenByUserProduct);
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

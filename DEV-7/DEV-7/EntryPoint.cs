namespace DEVTask7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog(@"cars.json");
            SuitableProductGetter suitableProductGetter = new SuitableProductGetter();
            suitableProductGetter.SetCatalog(catalog);
            Storage storage = new Storage(@"storage.json");
            ToStorageAdder toStorageAdder = new ToStorageAdder();
            DeleterFromStorage deleterFromStorage = new DeleterFromStorage();
            IsAvailableProductChecker isAvailableProductChecker = new IsAvailableProductChecker();
            isAvailableProductChecker.SetStorage(storage);
            toStorageAdder.SetStorage(storage);
            deleterFromStorage.SetStorage(storage);
            Menu menu = new Menu();
            menu.GetSuitableCars = suitableProductGetter;
            menu.AddCarToStorage = toStorageAdder;
            menu.DeleteCarFromStorage = deleterFromStorage;
            menu.IsAvailableProductGetter = isAvailableProductChecker;
            menu.Run();         
        }
    }
}

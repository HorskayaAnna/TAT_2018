using System;

namespace DEVTask6
{
    class AllNumberOfCommodityCounter : ICommand
    {
        private Storage storage;

        public AllNumberOfCommodityCounter(Storage paramStorage)
        {
            storage = paramStorage;
        }

        public void Execute()
        {
            int numberOfCommodity = storage.CountAll();
            Console.WriteLine("All number of commodity: " + numberOfCommodity);
        }
    }
}

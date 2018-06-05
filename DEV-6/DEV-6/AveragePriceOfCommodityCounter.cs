using System;

namespace DEVTask6
{
    class AveragePriceOfCommodityCounter : ICommand
    {
        Storage storage;

        public AveragePriceOfCommodityCounter(Storage paramStorage)
        {
            storage = paramStorage;
        }

        /// <summary>
        /// this method calculate avarega price of commodity 
        /// </summary>
        public void Execute()
        {
            float averagePrice = storage.AveragePrice();
            Console.WriteLine("Average price of commodity: " + averagePrice);
        }
    }
}
using System;

namespace DEVTask6
{
    internal class AveragePriceOfCommodityCounterOfOneTypeCounter : ICommand
    {
        private Storage storage;

        public AveragePriceOfCommodityCounterOfOneTypeCounter(Storage paramStorage)
        {
            storage = paramStorage;
        }

        /// <summary>
        /// This method is calculate average price of 
        /// chosen by user type of commodity 
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Which type's average price I should count?\n" +
                                       "Input name, please");
            string type = Console.ReadLine();
            float averagePriceOfType = storage.AveragePrice(type);
            Console.WriteLine("Average price of " + type + " : " + averagePriceOfType);
        }
    }
}
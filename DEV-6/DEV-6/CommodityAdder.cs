using System;

namespace DEVTask6
{
    class CommodityAdder : ICommand
    {
        private Storage storage;

        public CommodityAdder(Storage paramStorage)
        {
            storage = paramStorage;
        }

        /// <summary>
        /// This method add commodity to the storage
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Input type's name");
            string nameOfTheType = Console.ReadLine();
            if (nameOfTheType.Length == 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            Commodity commodity = GetCommodity();
            storage.AddItems(nameOfTheType, commodity);
        }

        private Commodity GetCommodity()
        {
            Console.WriteLine("Input commodity's name, amount and prise");
            string CommodityName = Console.ReadLine();
            int commodityQuantity;
            while (!int.TryParse(Console.ReadLine(), out commodityQuantity))
            {
                Console.WriteLine("Input correct quantity, please ");
            }
            float commodityPrice;
            while (!float.TryParse(Console.ReadLine(), out commodityPrice))
            {
                Console.WriteLine("Input correct quantity, please ");
            }
            return new Commodity(CommodityName, commodityQuantity, commodityPrice);
        }
    }
}

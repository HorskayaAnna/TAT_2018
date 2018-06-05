using System;

namespace DEVTask6
{
    class Menu
    {
        private Terminal terminal;
        private CommodityAdder commodityAdder;
        private NumberOfTheTypeCounter numberOfTheTypeCounter;
        private AllNumberOfCommodityCounter allNumberOfCommodityCounter;
        private AveragePriceOfCommodityCounter averagePriceOfCommodityCounter;
        private AveragePriceOfCommodityCounterOfOneTypeCounter averagePriceOfCommodityCounterOfOneTypeCounter;

        public Menu(Storage storage)
        {
            terminal = new Terminal();
            commodityAdder = new CommodityAdder(storage);
            numberOfTheTypeCounter = new NumberOfTheTypeCounter(storage);
            allNumberOfCommodityCounter = new AllNumberOfCommodityCounter(storage);
            averagePriceOfCommodityCounter = new AveragePriceOfCommodityCounter(storage);
            averagePriceOfCommodityCounterOfOneTypeCounter = new AveragePriceOfCommodityCounterOfOneTypeCounter(storage);
        }

        /// <summary>
        /// This method starts endless cycle for interacting with user
        /// </summary>
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose command:\n" +
                    "1 To add commodity\n" +
                    "2 To count number of types\n" +
                    "3 To count all number of commodity\n" +
                    "4 To count average price of commodity\n" +
                    "5 To count average price of one type of commodity\n" +
                    "6 To exit \n");
                int caseNumber = Int32.Parse(Console.ReadLine());
                switch (caseNumber)
                {
                    case 1:
                        terminal.SetCommand(commodityAdder);
                        break;
                    case 2:
                        terminal.SetCommand(numberOfTheTypeCounter);
                        break;
                    case 3:
                        terminal.SetCommand(allNumberOfCommodityCounter);
                        break;
                    case 4:
                        terminal.SetCommand(averagePriceOfCommodityCounter);
                        break;
                    case 5:
                        terminal.SetCommand(averagePriceOfCommodityCounterOfOneTypeCounter);
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        return;
                }
                terminal.Execute();
            }
        }
    }
}

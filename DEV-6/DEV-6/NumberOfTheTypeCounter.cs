using System;

namespace DEVTask6
{
    class NumberOfTheTypeCounter : ICommand
    {
        private Storage storage;

        public NumberOfTheTypeCounter(Storage paramStorage)
        {
            storage = paramStorage;
        }

        /// <summary>
        /// this method is calculate number of commodity type's 
        /// </summary>
        public void Execute()
        {
            int numberOfTypes = storage.CountTypes();
            Console.WriteLine("Number of type: " + numberOfTypes);
        }
    }
}

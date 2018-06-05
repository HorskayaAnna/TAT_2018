using System;
using System.Collections.Generic;

namespace DEVTask8
{
    /// <summary>
    /// Class command for getting the oldest humans 
    /// </summary>
    class TheOldestHuman : ICommand
    {
        private Storage storage;

        public TheOldestHuman(Storage paramStorage)
        {
            storage = paramStorage;
        }

        public void Execute()
        {
            List<Human> TheOldestHuman = storage.TheOldestHuman();
            Console.WriteLine($"The Oldest Human : {TheOldestHuman}");
        }
    }
}

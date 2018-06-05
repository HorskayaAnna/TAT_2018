using System;

namespace DEVTask8
{
    /// <summary>
    /// Class-command for getting the most popular female name 
    /// </summary>
    class PopularFemaleName : ICommand
    {
        private Storage storage;

        public PopularFemaleName(Storage paramStorage)
        {
            storage = paramStorage;
        }

        public void Execute()
        {
            string popularName = storage.PopularFemaleName();
            Console.WriteLine($"Popular Name : {popularName}");
        }
    }
}

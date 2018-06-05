using System;

namespace DEVTask8
{
    /// <summary>
    /// Class-command for adding human to the storage
    /// </summary>
    class HumanAdder : ICommand
    {
        private Storage storage;

        public HumanAdder(Storage paramStorage)
        {
            storage = paramStorage;
        }

        public void Execute()
        {
            Human human = GetHuman();
            storage.AddItems(human);
        }

        private Human GetHuman()
        {
            Console.WriteLine("Input humans's firstname, lastname, sex  and age");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string sex = Console.ReadLine();
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Input correct age, please ");
            }
            
            return new Human(firstName, lastName, sex, age);
        }
    }
}
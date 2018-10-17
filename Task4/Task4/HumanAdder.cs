using System;

namespace Task4
{
    class HumanAdder
    {
        public Human SetHuman()
        {
            Console.WriteLine("Input humans's firstname, lastname, sex  and age");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Input correct age, please ");
            }
            
            return new Human(firstName, lastName, age);
        }
    }
}

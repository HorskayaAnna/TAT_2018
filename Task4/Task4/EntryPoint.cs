using System;

namespace Task4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            Console.WriteLine("Input something to continue and stop to stop input humans");
            while (Console.ReadLine() != "stop")
            {
                HumanAdder humanAdder = new HumanAdder();               
                storage.AddNewHumanInStorage(humanAdder.SetHuman());
            }
            storage.OutputAllHumans();
            Console.WriteLine($"Max age:{ storage.MaxAge()}");
            Console.WriteLine($"Min age:{ storage.MinAge()}");
            Console.WriteLine($"Average age:{ storage.AverageAge()}");

        }
    }
}

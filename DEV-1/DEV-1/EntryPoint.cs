using System;

namespace DevTask1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Write("Wrong number of arguments.");
            }
            else
            {
                MaxNumberOfTheSameConsecutiveSymbolsFinder finder = new MaxNumberOfTheSameConsecutiveSymbolsFinder(args[0]);
                Console.WriteLine($"Max value of sequent symbols is: {finder.GetNumberOfTheSameConsecutiveSymbols()}");
            }
        }
    }
}

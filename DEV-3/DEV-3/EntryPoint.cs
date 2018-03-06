using System;

namespace DevTask3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Write("Wrong number of arguments.\n");
            }
            else
            {
                if (Int32.Parse(args[1]) > 2 || Int32.Parse(args[1]) < 20)
                {
                    ConvertNumberToAnotherNumeralSystem conventer = new ConvertNumberToAnotherNumeralSystem(Int32.Parse(args[0]), Int32.Parse(args[1]));
                    Console.WriteLine($"Max value of sequent symbols is: {conventer.СonversionToAnotherNumeralSystem()}");
                }
            }
        }
    }
}


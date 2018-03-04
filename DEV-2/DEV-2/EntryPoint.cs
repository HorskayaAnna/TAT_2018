using System;
using System.Text;

namespace DevTask2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string, please");
            StringBuilder inputString = new StringBuilder(Console.ReadLine());
            if (inputString.Length > 0)
            {
                GetStringWithEvenSymbols delete = new GetStringWithEvenSymbols(inputString);
                delete.DeleteOddSymbols();
            }
            else
            {
                Console.WriteLine("Error:Empty string");
            }
        }
    }
}

using System;
using System.Text;

namespace DevTask2
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string, please");
            StringBuilder inputString = new StringBuilder(Console.ReadLine());
            if (inputString.Length > 0)
            {
                GetterStringWithEvenSymbols evener = new GetterStringWithEvenSymbols(inputString);
                evener.StringWithEvenSymbolsCreator();
            }
            else
            {
                Console.WriteLine("Error:Empty string");
            }
        }
    }
}

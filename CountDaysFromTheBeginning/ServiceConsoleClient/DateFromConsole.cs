using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceConsoleClient
{
    /// <summary>
    /// class, which gets date fron console
    /// </summary>
    class DateFromConsole
    {
        public string GetDateFromConsole()
        {
            Console.WriteLine("Input day");
            int Day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Month");
            int Month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("And year");
            int Year = Int32.Parse(Console.ReadLine());
            return $"{Year}.{Month}.{Day}";
        }
    }
}

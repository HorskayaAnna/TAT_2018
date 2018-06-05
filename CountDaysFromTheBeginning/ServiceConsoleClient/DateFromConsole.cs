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
            try
            {
                int Day;
                int Month;
                int Year;
                Console.WriteLine("Input day");
                Int32.TryParse(Console.ReadLine(), out Day);
                Console.WriteLine("Month");
                Int32.TryParse(Console.ReadLine(), out Month);
                Console.WriteLine("And year");
                Int32.TryParse(Console.ReadLine(), out Year);
                if (Day < 1 || Day > 31 || Month<1
                    || Month >12 || Year <0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return $"{Year}.{Month}.{Day}";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data format is invalid");
                throw ex;
            }
        }
    }
}

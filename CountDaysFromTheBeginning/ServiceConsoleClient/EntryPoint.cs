using CountDaysFromTheBeginning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceConsoleClient
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                string date = (new DateFromConsole()).GetDateFromConsole();
                WebService service = new WebService();
                Console.WriteLine(service.CountAmountOfDaysFromTheBeginning(date));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

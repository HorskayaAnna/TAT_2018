using System;

namespace DEVTask6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Storage storage = new Storage();
                Menu menu = new Menu(storage);
                menu.Run();
            }
            catch(FormatException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            catch (ArgumentOutOfRangeException exeption)
            {
                Console.WriteLine("Error:" + exeption.Message);
            }
        }
    }
}

using System;
using System.IO;

namespace DEVTask8
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Storage storage = new Storage();
                Menu menu = new Menu(storage);
                storage.IventHandler += PrintPeopleBearingTheSameSurname;
                menu.Run();
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            catch (ArgumentOutOfRangeException exeption)
            {
                Console.WriteLine("Error:" + exeption.Message);
            }
        }

        public static void PrintPeopleBearingTheSameSurname(object obj, AccountEventArgs e)
        {
            Console.WriteLine($"Persons bearing the same surnamev for this person {e.LastName} : {e}");
        }

        public static void WriteToFilePeopleBearingTheSameSurname(object obj, AccountEventArgs e)
        {
            File.WriteAllText("Persons bearing the same surnamev for this person.txt", $"Persons bearing the same surnamev for this person { e.LastName} : { e}");
        }
    }
}
using System;

namespace DEVTask8
{
    /// <summary>
    /// Class menu for interacting with user
    /// </summary>
    class Menu
    {
        private Terminal terminal;
        private HumanAdder humanAdder;
        private AverageAge averageAge;
        private TheOldestHuman oldestHuman;
        private PopularFemaleName popularName;

        public Menu(Storage storage)
        {
            terminal = new Terminal();
            humanAdder = new HumanAdder(storage);
            averageAge = new AverageAge(storage);
            oldestHuman = new TheOldestHuman(storage);
            popularName = new PopularFemaleName(storage);
        }

        /// <summary>
        /// This method starts an endless cycle for interacting with user
        /// </summary>
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose command:\n" +
                    "0 To add human\n"+
                    "1 To count average age\n" +
                    "2 To find oldest human\n" +
                    "3 To find popular name \n" +
                    "4 to exit");
                int caseNumber = Int32.Parse(Console.ReadLine());
                switch (caseNumber)
                {
                    case 0:
                        terminal.SetCommand(humanAdder);
                        break;
                    case 1:
                        terminal.SetCommand(averageAge);
                        break;
                    case 2:
                        terminal.SetCommand(oldestHuman);
                        break;
                    case 3:
                        terminal.SetCommand(popularName);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        return;
                }
                terminal.Execute();
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace DEVTask8
{
    /// <summary>
    /// Class which stores list of humans
    /// and provides user with the interface for adding and changing info in Storage
    /// </summary>
    public class Storage : IStorageCommand
    {
        private static Storage instance;
        private List<Human> humans = new List<Human>();
        public delegate void PeopleWithTheSameLastnameWasInput(object obj, AccountEventArgs e);
        public event PeopleWithTheSameLastnameWasInput IventHandler;

        public static Storage GetInstance()
        {
            if (instance == null)
                instance = new Storage();
            return instance;
        }

        public void AddItems(Human paramHumans)
        {
            if (humans.Select(h => h.LastName).ToList<string>().Contains(paramHumans.LastName))
            {
                IventHandler(this, new AccountEventArgs(humans, paramHumans.LastName));
            }
            humans.Add(paramHumans);
        }

        public int AverageAge()
        {
            int averageAge =(int) humans.Average(t => t.Age);
            return averageAge;               
        }

        public List<Human> TheOldestHuman()
        {
            int maxAge = (int)humans.Max(t => t.Age);
            List<Human> humansWithMaxAge = humans.Where(t => t.Age == maxAge).ToList();
            return humansWithMaxAge;
        }

        public string PopularFemaleName()
        {
            string popularName = string.Empty;
            int nummberOfMatches = 0;
            int bufferNumberOfMatches=0;
            foreach (Human humanName in humans)
            {
                foreach (Human humans in humans)
                {
                    if (humanName.FirstName == humans.FirstName && humans.Sex=="female")
                    {
                        bufferNumberOfMatches++;
                    }
                }
                if (bufferNumberOfMatches > nummberOfMatches)
                {
                    nummberOfMatches = bufferNumberOfMatches;
                    popularName = humanName.FirstName;
                }
            }
            return popularName;
        }
    }
}

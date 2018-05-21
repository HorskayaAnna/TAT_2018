using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Storage
    {
        List<Human> humans;

        public Storage()
        {
            humans = new List<Human>();
        }

        public void AddNewHumanInStorage(Human human)
        {
            humans.Add(human);
        }

        public void OutputAllHumans()
        {
            foreach (Human i in humans)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public int MaxAge()
        {
            int maxAge = humans.Max(t => t.Age);
           
            return maxAge;
        }

        public int MinAge()
        {
            int minAge = humans.Min(t => t.Age);           
            return minAge;
        }

        public double AverageAge()
        {
            double averageAge =humans.Average(t => t.Age);
            return averageAge;               
        }
    }
}

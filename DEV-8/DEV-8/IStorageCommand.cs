using System.Collections.Generic;


namespace DEVTask8
{
    interface IStorageCommand
    {
        int AverageAge();
        List<Human> TheOldestHuman();
        string PopularFemaleName();
    }
}
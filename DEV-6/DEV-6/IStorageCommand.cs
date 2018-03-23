using System;

namespace DEVTask6
{
    interface IStorageCommand
    {
        int CountTypes();
        int CountAll();
        float AveragePrice();
        float AveragePrice(string typeName);
        void AddItems(string namenameOfType, Commodity commodity);
    }
}

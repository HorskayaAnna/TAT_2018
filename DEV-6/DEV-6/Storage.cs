using System.Collections.Generic;

namespace DEVTask6
{
    public class Storage : IStorageCommand
    {
        private static Storage instance;
        private Dictionary<string, List<Commodity>> commodities = new Dictionary<string, List<Commodity>>();

        public static Storage GetInstance()
        {
            if (instance == null)
                instance = new Storage();
            return instance;
        }
         
        /// <summary>
        /// This method add's commodity  to storage
        /// </summary>
        /// <param name="typeName">
        /// newCommodity's type name 
        /// </param>
        /// <param name="newCommodity">
        /// Input by user commodity which will added to storage
        /// </param>
        public void AddItems(string typeName, Commodity newCommodity)
        {
            if (commodities.ContainsKey(typeName))
            {
                commodities[typeName].Add(newCommodity);
            }
            else
            {
                commodities[typeName] = new List<Commodity>();
                commodities[typeName].Add(newCommodity);
            }
        }

        /// <summary>
        /// This method returns number of type's of commodities 
        /// </summary>
        /// <returns>
        /// number of types
        /// </returns>
        public int CountTypes()
        {
            return commodities.Count;
        }

        /// <summary>
        /// This method returns number of all types' of commodities
        /// </summary>
        /// <returns>
        /// number of all commodities
        /// </returns>
        public int CountAll()
        {
            int numberOfCommodity = 0;
            foreach (KeyValuePair<string, List<Commodity>> items in commodities)
            {
                foreach (Commodity commodity in items.Value)
                {
                    numberOfCommodity += commodity.Amount;
                }
            }
            return numberOfCommodity;
        }

        /// <summary>
        /// This method returns average price of commodities 
        /// </summary>
        /// <returns>
        /// average price of commodities
        /// </returns>
        public float AveragePrice()
        {
            float averagePrice = 0;
            foreach (List<Commodity> items in commodities.Values)
            {
                float bufferAveragePrice = 0;
                foreach (Commodity commodity in items)
                {
                    bufferAveragePrice += commodity.Price;
                }
                averagePrice += bufferAveragePrice / items.Count;
            }
            return averagePrice / commodities.Count;
        }

        /// <summary>
        /// This method returns average price of 
        /// chosen by user type of commodities 
        /// or -1 if here is no such type 
        /// </summary>
        /// <param name="typeName">
        /// input type of commodity
        /// </param>
        /// <returns>
        /// average price of 
        /// chosen by user type of commodities 
        /// or -1 if here is no such type 
        /// </returns>
        public float AveragePrice(string typeName)
        {
            float averagePrice = 0;
            if (!commodities.ContainsKey(typeName))
            {
                return -1;
            }
            foreach (Commodity commodity in commodities[typeName])
            {
                averagePrice += commodity.Price;
            }
            return averagePrice / commodities[typeName].Count;
        }
    }
}

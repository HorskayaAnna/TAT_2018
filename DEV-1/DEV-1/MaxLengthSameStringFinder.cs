using System;

namespace DevTask1
{
    /// <summary>
    /// This class contains method, which calculates
    /// max number of the same consecutive symbols  
    /// </summary>
    class MaxNumberOfTheSameConsecutiveSymbolsFinder
    {
        string processedLine;
        /// <summary>
        /// Initializer of MaxNumberOfTheSameConsecutiveSymbolsFinder's instance
        /// </summary>
        /// <param name="arg"></param>
        public MaxNumberOfTheSameConsecutiveSymbolsFinder(string arg)
        {
            processedLine = arg;
        }
        /// <summary>
        /// This metod calculates 
        /// max number of the same consecutive symbols
        /// </summary>
        /// <returns>
        /// Returns max numbers of the same consecutive symbols
        /// </returns>
        public int GetNumberOfTheSameConsecutiveSymbols()
        {
            int maxQuantityOfIdenticalSymbols = 0;
            int counterOfIdenticalSymbols = 1;
            for (int i = 0; i < processedLine.Length - 1; i++)
            {
                if (processedLine[i].Equals(processedLine[i + 1]))
                {
                    counterOfIdenticalSymbols++;
                    if (counterOfIdenticalSymbols > maxQuantityOfIdenticalSymbols)
                    {
                        maxQuantityOfIdenticalSymbols = counterOfIdenticalSymbols;
                    }
                }
                else
                {
                    counterOfIdenticalSymbols = 1;
                }
            }
            return maxQuantityOfIdenticalSymbols;
        }
    }
}

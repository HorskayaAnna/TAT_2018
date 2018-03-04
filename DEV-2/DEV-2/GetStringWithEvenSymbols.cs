using System;
using System.Text;

namespace DevTask2
{
    /// <summary>
    /// This class contains method, which delete odd symbols 
    /// in string and output this string
    /// </summary>
    class GetStringWithEvenSymbols
    {
        StringBuilder processedString;

        /// <summary>
        /// Initializer of GetStringWithEvenSymbols's instance
        /// </summary>
        /// <param name="arg">
        /// string taken from the console
        /// </param>
        public GetStringWithEvenSymbols(StringBuilder arg)
        {
            processedString = arg;
        }

        /// <summary>
        /// This metod create new string with only even index symbols
        /// </summary>
        public void DeleteOddSymbols()
        {
            string bufferString = "";
            for (int i = 0; i < processedString.Length; i+=2)
            {
                bufferString += processedString[i];
            }
            Console.WriteLine($"String with even symbols : {bufferString}");
        }
    }
}

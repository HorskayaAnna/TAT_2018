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
        /// This metod Delete Odd Symbols in string
        /// </summary>
        public void DeleteOddSymbols()
        {
            processedString = processedString.Replace(" ", "");
            StringBuilder bufferString = new StringBuilder(10);
            int position=0;
            for (int i = 1; i < processedString.Length;i+=2)
            {
                bufferString.Insert(position, processedString[i]);
                position++;
            }
            Console.WriteLine($"String with even symbols : {bufferString}");
        }
    }
}

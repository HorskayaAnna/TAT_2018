using System;
using System.Text;

namespace DevTask2
{
    /// <summary>
    /// This class contains method, which delete odd symbols 
    /// in string and output this string
    /// </summary>
    class GetterStringWithEvenSymbols
    {
        StringBuilder processedString;

        /// <summary>
        /// Initializer of GetStringWithEvenSymbols's instance
        /// </summary>
        /// <param name="arg">
        /// string taken from the console
        /// </param>
        public GetterStringWithEvenSymbols(StringBuilder arg)
        {
            processedString = arg;
        }

        /// <summary>
        /// This metod create new string with only even index symbols
        /// </summary>
        public void StringWithEvenSymbolsCreator()
        {
            Console.WriteLine($"String with even symbols : {GetEvenPositionsStringBuilder()}");
        }

        /// <summary>
        /// Makes stringBuilder from processedString even indexes
        /// </summary>
        /// <returns>
        /// Returns stringBuilder with this even indexes chars
        /// </returns>
        public StringBuilder GetEvenPositionsStringBuilder()
        {
            StringBuilder outputStringBuilder = new StringBuilder();
            for (int i = 0; i < processedString.Length; i += 2)
            {
                outputStringBuilder.Append(processedString[i]);
            }
            return outputStringBuilder;
        }
    }
}

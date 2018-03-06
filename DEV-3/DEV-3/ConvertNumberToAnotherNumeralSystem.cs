using System;

namespace DevTask3
{
    /// <summary>
    /// This class convert deciminal number 
    /// to another numeral system from 2 to 20 
    /// </summary>
    class ConvertNumberToAnotherNumeralSystem
    {
        int numberToConvert;
        int radix;

        /// <summary>
        /// Initializer of ConvertNumberToAnotherNumeralSystem's instance
        /// </summary>
        /// <param name="arg">
        /// numbers taken from the console args
        /// </param>
        public ConvertNumberToAnotherNumeralSystem(int arg1, int arg2)
        {
            numberToConvert = arg1;
            radix = arg2; 

        }

        /// <summary>
        /// This metod convert deciminal
        /// number to another numeral system
        /// </summary>
        /// <returns>
        /// return number in anщther numeral system
        /// </returns>
        public string СonversionToAnotherNumeralSystem()
        {

            string result = ""; 
            int temp;
            int buffer=numberToConvert;
            while (buffer > 0)  
            {
                temp = buffer % radix;
                if (temp < 9)
                {
                    result += temp;
                }
                else
                {
                    char newRadixNum = (char)(65+temp-10);
                    result += newRadixNum;
                }
                buffer = buffer / radix;
            }
            return (Reverse(result));
        }

        /// <summary>
        /// This method reverse
        /// </summary>
        /// <param name="stringToRevert">
        /// string to revert, taken from the another method 
        /// </param>
        /// <returns>
        /// return Transformed in reverse order  String
        /// </returns>
        private string Reverse(string stringToRevert)
        {
            char[] TransformedString = stringToRevert.ToCharArray();
            Array.Reverse(TransformedString);
            return new string(TransformedString);
        }
    }
}

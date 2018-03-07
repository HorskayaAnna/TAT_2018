using System;

namespace DevTask3
{
    /// <summary>
    /// This class convert decimal number 
    /// to another numeral system from 2 to 20 
    /// </summary>
    class ConvertingNumberToAnotherNumeralSystem
    {
        int numberToConvert;
        int radix;

        /// <summary>
        /// Constructor of ConvertNumberToAnotherNumeralSystem's instance
        /// </summary>
        /// <param name="arg">
        /// numbers taken from the console args
        /// </param>
        public ConvertingNumberToAnotherNumeralSystem(int paramDecimalNumber, int paramNewRadix)
        {
            if (paramDecimalNumber < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                numberToConvert = paramDecimalNumber;
            }
            if (paramNewRadix < 2 || paramNewRadix > 20)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                radix = paramNewRadix;
            }
        }

        /// <summary>
        /// This metod convert decimal
        /// number to another numeral system
        /// </summary>
        /// <returns>
        /// return number in another numeral system
        /// </returns>
        public string СonversionToAnotherNumeralSystem()
        {
            string resultNumberInAnotherRadix= ""; 
            int modulo;
            int bufferDecimalNumber=numberToConvert;
            while (bufferDecimalNumber > 0)  
            {
                modulo = bufferDecimalNumber % radix;
                if (modulo < 9)
                {
                    resultNumberInAnotherRadix += modulo;
                }
                else
                {
                    char newRadixNum = (char)('A'+ modulo - 10);
                    resultNumberInAnotherRadix += newRadixNum;
                }
                 bufferDecimalNumber = bufferDecimalNumber / radix;
            }
            return (Reverse(resultNumberInAnotherRadix));
        }

        /// <summary>
        /// This method reverse
        /// </summary>
        /// <param name="stringToRevert">
        /// string to revert, taken from the another method 
        /// </param>
        /// <returns>
        /// return Transformed in reverse order String
        /// </returns>
        private string Reverse(string stringToRevert)
        {
            char[] TransformedString = stringToRevert.ToCharArray();
            Array.Reverse(TransformedString);
            return new string(TransformedString);
        }
    }
}

using System;

namespace DevTask3
{
    /// <summary>
    /// This class convert decimal number 
    /// to another numeral system from 2 to 20 
    /// </summary>
    public class ConvertingNumberToAnotherNumeralSystem
    {
        int numberToConvert;
        int radix;

        /// <summary>
        /// Constructor of ConvertNumberToAnotherNumeralSystem's instance
        /// </summary>
        /// <param name="args">
        /// numbers taken from the console args
        /// </param>
        public ConvertingNumberToAnotherNumeralSystem(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new IndexOutOfRangeException();
                }
                int paramDecimalNumber = int.Parse(args[0]);
                if (paramDecimalNumber < 0)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                numberToConvert = paramDecimalNumber;
                int paramNewRadix = int.Parse(args[1]);
                if (paramNewRadix < 2 || paramNewRadix > 20)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                radix = paramNewRadix;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This metod convert decimal
        /// number to another numeral system
        /// </summary>
        /// <returns>
        /// return number in another numeral system
        /// </returns>
        public string СonvertToAnotherNumeralSystem()
        {
            string resultNumberInAnotherRadix = "";
            int modulo;
            int bufferDecimalNumber = numberToConvert;
            if (bufferDecimalNumber == 0)
            {
                return ("0");
            }
            while (bufferDecimalNumber > 0)
            {
                modulo = bufferDecimalNumber % radix;
                if (modulo < 9)
                {
                    resultNumberInAnotherRadix += modulo;
                }
                else
                {
                    char newRadixNum = (char)('A' + modulo - 10);
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

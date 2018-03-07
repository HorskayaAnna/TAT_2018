using System;

namespace DevTask3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                int decimalNumber = Int32.Parse(args[0]);
                if (decimalNumber < 0)
                {
                    throw new Exception("Can't convert negative numbers");
                }
                int newRadix = Int32.Parse(args[1]);
                if (newRadix < 2 || newRadix > 20)
                {
                    throw new Exception("wrong Radix");
                }
                ConvertingNumberToAnotherNumeralSystem conventer = new ConvertingNumberToAnotherNumeralSystem(Int32.Parse(args[0]), Int32.Parse(args[1]));
                Console.WriteLine($"Max value of sequent symbols is: {conventer.СonversionToAnotherNumeralSystem()}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("ERROR: Wrong number of arguments");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}


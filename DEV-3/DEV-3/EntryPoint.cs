﻿using System;

namespace DevTask3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ConvertingNumberToAnotherNumeralSystem conventer = new ConvertingNumberToAnotherNumeralSystem(Int32.Parse(args[0]), Int32.Parse(args[1]));
                Console.WriteLine($"Max value of sequent symbols is: {conventer.СonversionToAnotherNumeralSystem()}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERROR: Wrong number of arguments");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
    }
}


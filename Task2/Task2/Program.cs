using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle rectangle = new Rectangle(Double.Parse(args[0]), Double.Parse(args[1]));
                double rectangleArea = rectangle.CalculateArea();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERROR: Wrong number of arguments");
            }
        }
    }
}

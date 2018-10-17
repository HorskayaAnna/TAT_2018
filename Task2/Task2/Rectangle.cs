using System;

namespace Task2
{
    public class Rectangle
    {
        double width;
        double length;

        public Rectangle(double paramWigth, double paramLength)
        {
            if (width <= 0 || length <= 0)
                throw new System.ArgumentOutOfRangeException("rectangle side cannot be 0");
            else
            {
                width = paramWigth;
                length = paramLength;
            }
            
        }

        public double CalculateArea()
        {
            return width * length;
        }
    }
}

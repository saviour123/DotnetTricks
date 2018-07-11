using System;

namespace Application
{
    public static class ShapeMath
    {
        public static double GetArea(string shape = "", double length = 0, double length2 = 0)
        {
            if (String.Equals("Rectangle",shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * length2;
            } else if(String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * (length2/2);
            } else if(String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("calculating area of the circle");
                return 3.142 * Math.Pow(length, 2);
            } else
            {
                return -1;
            }
        }


    }
}
using System;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;
            
            bool result = isUpper("hello");
            Console.WriteLine(result);
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}

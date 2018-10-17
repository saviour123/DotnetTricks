using System;
using ClassLibExtMethod;

namespace ExtensionMethod2
{

    public static class ExtMetClass
    {
        public static string StrExtension(this Class1 fine)
        {
            return "today" + fine;
        }
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.Print();
            obj.StrExtension();
            string str = "12345";
            int num = str.IntegerExtension();
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());
            Console.WriteLine("Hello World!");
        }
    }
}

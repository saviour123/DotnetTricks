using System;
using ClassLibExtMethod;

namespace ExtensionMethod1
{
    public static class XX
    {
        public static void NewMethod(this Class1 ob, string hello)
        {
            Console.WriteLine($"I am extended method {hello} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
            ob.Display();
            ob.Print();
            ob.NewMethod(hello: "hello");
            // Console.ReadKey();
            Console.WriteLine("Done");
        }
    }
}

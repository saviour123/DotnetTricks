using System;
using DIONE.Extensions;
using DIONE.Client;

namespace DIONE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Service1 service1 = new Service1();
            DIONE.Client.Client c1 = new DIONE.Client.Client(service1);
            c1.ServeMethod();

            Service2 service2 = new Service2();
            DIONE.Client.Client c2 = new DIONE.Client.Client(service2);
            c2.ServeMethod();

            // getter/setter
        }
    }
}

using System;
using MassTransit;

namespace MMT.Console
{
    class Program
    {

        public interface ValueEntered
        {
            string Value { get; }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var busControl = ConfigureBus();
            busControl.Start();

            do
            {
                System.Console.WriteLine("Enter a message (or quit to exit)");
                System.Console.Write("> ");
                string value = System.Console.ReadLine();

                if("quit".Equals(value, StringComparison.OrdinalIgnoreCase))
                    break;

                busControl.Publish<ValueEntered>(new 
                {
                    value = value
                });
                
            } while (true);
        }


        public static IBusControl ConfigureBus()
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg => 
            {
                cfg.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("sav");
                    h.Password("sav");
                });
            });
        }

    }
}

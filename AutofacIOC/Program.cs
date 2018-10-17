using Autofac;
using DemoApp;

namespace AutofacIOC
{
    public class Program
    {
        private static IContainer Container { get; set; }

        static void Main (string[] args)
        {
            var builder = new ContainerBuilder ();
            builder.RegisterType<ConsoleOutput> ().As<IOutput> ();
            builder.RegisterType<TodayWriter> ().As<IDateWriter> ();
            Container = builder.Build ();

            // The WriteDate method is where we'll make use
            // of our dependency injection. We'll define that
            // in a bit.
            WriteDate ();
        }
        public static void WriteDate ()
        {
            using (var scope = Container.BeginLifetimeScope ())
            {
                var writer = scope.Resolve<IDateWriter> ();
                writer.WriteDate ();
            }
        }
    }

}
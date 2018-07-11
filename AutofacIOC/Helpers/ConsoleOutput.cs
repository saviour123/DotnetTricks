using System;

namespace AutofacIOC.Helpers
{
  public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
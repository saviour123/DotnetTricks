using System;

namespace AutofacIOC.Helpers
{
    public class TodayWriter : IDateWriter
    {
        private IOutput _output;

        public TodayWriter()
        {
        } 
        public TodayWriter(IOutput output)
        {
            _output = output;
        }
        
        public void WriteDate()
        {
            // Console.WriteLine("hello");
            _output.Write("Hello");
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
using System;

namespace PartViewTuts
{
    class Program
    {
        static void Main(string[] args)
        {

            CoOrds mycords = new CoOrds(394, 34);
            mycords.PrintCoOrdd();

            Console.WriteLine("Hello World!");
        }
    }
    
    public partial class CoOrds
    {
        private int x;
        private int y;

        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class CoOrds
    {
        public void PrintCoOrdd()
        {
            Console.WriteLine($"CoOrds: {x}, {y}"); 
        }
    }


}

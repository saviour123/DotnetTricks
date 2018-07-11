using System;
using System.Linq;
using System.Text;

namespace Application {

    class EnumProgram {

        static void Main (string[] args) {


            int? randNum = null;

            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("Circle", 7));

            // Animal fox = new Animal () {
            //     name = "Red",
            //     sound = "Rawww"
            // };

            // fox.MakeSound();

            // Console.WriteLine("# of animals: {0}", Animal.GetNumAnimals());

        }
    }

}
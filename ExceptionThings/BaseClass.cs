using System;

namespace ExceptionThings
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class");
        }

        public void Print()
        {
            Console.WriteLine("I'm a parent class");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Constructor");            
        }

        // public static void Main()
        // {
        //     ChildClass child = new ChildClass();
        //     child.Print();

        // }
        
    }


}
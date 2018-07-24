using System;

namespace ExceptionThings
{
    public class BaseTalk
    {
        public string parentString;

        public BaseTalk()
        {
            Console.WriteLine("parent constructor");
        }

        public BaseTalk(string myString)
        {
            parentString = myString;
            Console.WriteLine(parentString);
        }

        public void Print()
        {
            Console.WriteLine("I'm a parent Class");
        }
    }

    // class two
    public class Child : BaseTalk
    {
        public Child() : base("from derived")
        {
            Console.WriteLine("Child Constructor");
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("I'm a child class");

        }
        public static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.parentString);
            child.Print();
            ((BaseTalk)child).Print();
        }
    }
}
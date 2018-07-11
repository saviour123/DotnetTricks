using System;

namespace Application {
    class Animal {
        public string name;
        public string sound;

        public Animal () {
            name = "No name";
            sound = "no sound";
        }

        public Animal (string name = "no name") {
            this.name = name;
            this.sound = "No sound";
            numOfAnimals++;
        }
        public Animal (string name = "no name", string sound = "No sound") {
            this.name = name;
            this.sound = "No sound";
            numOfAnimals++;
        }


        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
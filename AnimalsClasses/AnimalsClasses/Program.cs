using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsClasses
{
    internal class Program
    {
        class animal
        {
            public string name;
            public int maxAge;

            public virtual void MakeNoise()
            {
                Console.WriteLine("animal noises");
            }

        }
        class Dog : animal
        {
            public string race;

            public override void MakeNoise()
            {
                Console.WriteLine("woof woof");
            }
        }
        

        class Cat : animal
        {
            public string furColor;

            public override void MakeNoise()
            {
                Console.WriteLine("meow meow");
            }
        }
        static void Main(string[] args)
        {
            animal newAnimal = new animal();
            newAnimal.MakeNoise();
            Dog newDog = new Dog();
            newDog.name = "Fido";
            newDog.maxAge = 14;
            newDog.race = "Laika";
            Console.WriteLine($"{newDog.name} is {newDog.maxAge} years old and is a {newDog.race}");
            newDog.MakeNoise();

            Cat newCat = new Cat();
            newCat.name = "Micka";
            newCat.maxAge = 10;
            newCat.furColor = "brown";
            Console.WriteLine($"{newCat.name} is {newCat.maxAge} years old and is a {newCat.furColor}");
            newCat.MakeNoise();
            Console.ReadKey();
        }
        

    }
    

}

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainProgram
    {
        static void Main()
        {
            var listOfAnimals = new List<Animal> {new Dog ("Axel", 2, true),
                                            new Frog ("Pesho", 11, true),
                                            new Frog ("Kikeritsa",3,false),
                                            new Cat ("Gosho", 15, true),
                                            new Kitten ("Sivushka", 0.5),
                                            new Kitten ("Malinka", 0.6),
                                            new Tomcat ("Tom", 3),
                                            new Tomcat ("Leopold", 9),
                                            new Dog ("Rumpi",15,true)};

            foreach (var animal in listOfAnimals)
            {
                animal.ProduceSound();
            }

            Console.WriteLine("\r\nThe average age of the dogs is {0:0.00} years",
                Animal.CalculateAverageAge(listOfAnimals.Where(x => x is AnimalHierarchy.Dog)));
            Console.WriteLine("The average age of the cats is {0:0.00} years",
                Animal.CalculateAverageAge(listOfAnimals.Where(x => x is AnimalHierarchy.Cat)));
            Console.WriteLine("The average age of the kittens is {0:0.00} years",
                Animal.CalculateAverageAge(listOfAnimals.Where(x => x is AnimalHierarchy.Kitten)));
            Console.WriteLine("The average age of the tomcats is {0:0.00} years",
                Animal.CalculateAverageAge(listOfAnimals.Where(x => x is AnimalHierarchy.Tomcat)));
            Console.WriteLine("The average age of the frogs is {0:0.00} years",
                Animal.CalculateAverageAge(listOfAnimals.Where(x => x is AnimalHierarchy.Frog)));
        }
    }
}

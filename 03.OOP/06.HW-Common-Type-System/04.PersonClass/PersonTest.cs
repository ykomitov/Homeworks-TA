namespace PersonClass
{
    using System;
    using System.Linq;


    class PersonTest
    {
        static void Main()
        {
            var aPerson = new Person("Gosho");
            var anotherPerson = new Person("Pesho", 7);

            Console.WriteLine(aPerson);
            Console.WriteLine(anotherPerson);
        }
    }
}

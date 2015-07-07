namespace Task_2
{
    using System;

    public class PersonContainer
    {
        public enum Sex
        {
            male, female
        }

        public static void PersonConstructor(int age)
        {
            Person newPerson = new Person();
            newPerson.PersonAge = age;

            if (age % 2 == 0)
            {
                newPerson.PersonName = "Батката";
                newPerson.PersonSex = Sex.male;
            }
            else
            {
                newPerson.PersonName = "Мацето";
                newPerson.PersonSex = Sex.female;
            }

            Console.WriteLine(newPerson.PersonName);
            Console.WriteLine(newPerson.PersonAge);
            Console.WriteLine(newPerson.PersonSex);
        }

        public class Person
        {
            public Sex PersonSex { get; set; }

            public string PersonName { get; set; }

            public int PersonAge { get; set; }
        }
    }
}

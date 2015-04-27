namespace YetAnotherStudent
{
    using System;
    using System.Linq;
    using YetAnotherStudent.Models;

    class StudentTest
    {
        static void Main()
        {
            var testStudent = new Student("apostol", "hristov", "bakalov", 4401075480, "Sofia, Sample Address 23, apt. 23", 1, Enumeration.Specialty.Biology, Enumeration.University.SU, Enumeration.Faculty.FF, "0883309622", "abakalov@abv.bg");

            var compareStudent = new Student("apostol", "hristov", "bakalov", 9001162661, "Sofia, Sample Address 23, apt. 23", 1, Enumeration.Specialty.Biology, Enumeration.University.SU, Enumeration.Faculty.FF, "0883309622", "abakalov@abv.bg");

            Console.WriteLine(testStudent);

            //test IClonable implementation
            var deepClone = testStudent.Clone();
            Console.WriteLine("\r\nDeep clone:\r\n");
            Console.WriteLine(deepClone);

            //test IComparable implementation
            Console.WriteLine("\r\nIComparable implementation");
            Console.WriteLine(testStudent.CompareTo(compareStudent)); //difference in the SSN
            Console.WriteLine(testStudent.CompareTo(deepClone)); //compare with deep copy - expected 0

            //change family name in the deep copy instance, expected new outcome of CompareTo = 1
            deepClone.FamilyName = "atanasov";
            Console.WriteLine(testStudent.CompareTo(deepClone));
        }
    }
}

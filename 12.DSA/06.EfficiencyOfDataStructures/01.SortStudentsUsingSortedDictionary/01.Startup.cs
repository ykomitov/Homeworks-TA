/*A text file students.txt holds information about students and their courses in the following format:

    Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:

Kiril  | Ivanov   | C#
Stefka | Nikolova | SQL
Stela  | Mineva   | Java
Milena | Petrova  | C#
Ivan   | Grigorov | C#
Ivan   | Kolev    | SQL

C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
Java: Stela Mineva
SQL: Ivan Kolev, Stefka Nikolova*/

namespace _01.SortStudentsUsingSortedDictionary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string path = "../../students.txt";
            var coursesDb = new SortedDictionary<string, List<Student>>();  // Using simple List<Students> since the number of students in each course should be limited, and in my oppinion no further optimization is needed

            using (FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sreader = new StreamReader(fstream))
                {
                    string line;
                    while ((line = sreader.ReadLine()) != null)
                    {
                        var input = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var student = new Student(input[0], input[1]);

                        if (coursesDb.ContainsKey(input[2]))
                        {
                            coursesDb[input[2]].Add(student);
                        }
                        else
                        {
                            coursesDb[input[2]] = new List<Student>();
                            coursesDb[input[2]].Add(student);
                        }
                    }
                }
            }

            foreach (var couse in coursesDb)
            {
                var students = couse.Value
                                         .OrderBy(s => s.LastName)
                                         .ThenBy(s => s.FirstName)
                                         .ToList();

                Console.WriteLine("{0}: {1}", couse.Key, string.Join(", ", students));
            }
        }
    }
}

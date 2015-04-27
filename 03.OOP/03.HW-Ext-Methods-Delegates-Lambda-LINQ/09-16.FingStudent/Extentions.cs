using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStudentGroups
{
    static class Extentions
    {
        public static List<Student> SelectStudentsByGroup(this List<Student> studentsList, byte group)
        {
            var selectedStudents = (from student in studentsList
                                    where (student.GroupNum == 2)
                                    orderby student.FirstName
                                    select student)
                                  .ToList();

            if (selectedStudents.Count == 0)
            {
                Console.WriteLine("No students in the list...");
            }

            return selectedStudents;
        }

        public static List<Student> SelectPoorStudents(this List<Student> studentsList)
        {
            var poorStudents = studentsList
                                    .Where(x => x.Marks.Count(y => y == 2) == 2)
                                    .ToList();

            if (poorStudents.Count == 0)
            {
                Console.WriteLine("No students in the list...");
            }
            return poorStudents;
        }

        public static IEnumerable<IGrouping<byte, FindStudentGroups.Student>> GroupStudentsByGroup(this List<Student> studentsList)
        {
            var groupStudents = from student in studentsList
                                group student by student.GroupNum into newGroup
                                select newGroup;

            if (groupStudents.Count() == 0)
            {
                Console.WriteLine("No students in the list...");
            }
            return groupStudents;
        }
    }
}

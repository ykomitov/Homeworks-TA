namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            var mySchool = new School("My School");
            var class1 = new SchoolClass();
            var class2 = new SchoolClass();
            mySchool.SchoolClass.Add(class1);

            //test add & remove class
            mySchool.SchoolClass.Add(class2);
            mySchool.PrintClasses();
            //mySchool.SchoolClass.Remove(class2);
            mySchool.RemoveClass("B");
            Console.WriteLine("<After the removal of class B>");
            mySchool.PrintClasses();

            //test add & remove students
            class1.AddStudent(new Student("Angel Angelov"));
            class1.AddStudent(new Student("Borislav Borisov"));
            class1.RemoveStudent("Angel Angelov");

            //test add & remove teachers
            class1.AddTeacher(new Teacher("White Death", new List<SchoolSubject>{
                                                                            new SchoolSubject("Math",20,30),
                                                                            new SchoolSubject("Biology",10,10),
                                                                            new SchoolSubject("English Literature",20,20)}));

            //test add & remove subject
            class1.AddSubject("White Death", new SchoolSubject("Rocket Science", 100, 100));
            class1.RemoveSubject("White Death", "Biology");
            class1.Comment = "My DreamClass";
            var blackDeath = new Teacher("Black Death", new List<SchoolSubject>{
                                                                            new SchoolSubject("Chemistry",20,30),
                                                                            new SchoolSubject("Physics",10,10)});
            class1.ClassTeachers.Add(blackDeath);
            blackDeath.SetOfSubjects.Add(new SchoolSubject ("Student Executions", 1, 1));
            blackDeath.Comment = "My DreamTeacher";
            var aStudent = new Student("Gargamel Petrov");
            aStudent.Comment = "complete idiot";
            class1.AddStudent(aStudent);
            //Console.WriteLine(class1);
            Console.WriteLine("Print the contents of my school:");
            Console.WriteLine(mySchool);
        }
    }
}

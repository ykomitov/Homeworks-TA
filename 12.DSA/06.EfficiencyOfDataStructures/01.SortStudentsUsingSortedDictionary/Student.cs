﻿namespace _01.SortStudentsUsingSortedDictionary
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}

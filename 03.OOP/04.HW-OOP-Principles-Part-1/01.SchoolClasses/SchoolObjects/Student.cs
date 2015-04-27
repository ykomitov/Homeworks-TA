namespace School
{
    using System;
    using System.Linq;

    class Student : Person
    {
        static uint studentCounter = 1;
        private uint studentUniqueID;

        public Student(string name) : base(name)
        {
            this.PersonName = name;
            this.studentUniqueID = 10000 + studentCounter;
            studentCounter++;
        }
    }
}

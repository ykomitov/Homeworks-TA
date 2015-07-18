namespace Methods
{
    using System;

    internal class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            return this.Birthday < other.Birthday;
        }
    }
}

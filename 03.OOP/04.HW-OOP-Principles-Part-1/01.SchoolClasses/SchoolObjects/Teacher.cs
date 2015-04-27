namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Teacher : Person
    {
        private List<SchoolSubject> setOfSubjects;

        public Teacher(string name, List<SchoolSubject> listOfSubjects)
            : base(name)
        {
            this.setOfSubjects = listOfSubjects;
        }

        public List<SchoolSubject> SetOfSubjects
        {
            get
            {
                return this.setOfSubjects;
            }
            set
            {
                this.setOfSubjects = value;
            }
        }
    }
}

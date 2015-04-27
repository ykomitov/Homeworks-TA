namespace School
{
    using System;
    using System.Linq;

    class SchoolSubject : SchoolObject
    {
        private string subjectName;
        private ushort numOfLectures;
        private ushort numOfExercises;
        
        public SchoolSubject(string subjectName, ushort numOfLectures, ushort numOfExercises)
        {
            this.SubjectName = subjectName;
            this.NumOfLectures = numOfLectures;
            this.NumOfExercises = numOfExercises;
        }

        public string SubjectName
        {
            get
            {
                return this.subjectName;
            }
            set
            {
                this.subjectName = value;
            }
        }

        public ushort NumOfLectures
        {
            get
            {
                return this.numOfLectures;
            }
            set
            {
                this.numOfLectures = value;
            }
        }

        public ushort NumOfExercises
        {
            get
            {
                return this.numOfExercises;
            }
            set
            {
                this.numOfExercises = value;
            }
        }
    }
}

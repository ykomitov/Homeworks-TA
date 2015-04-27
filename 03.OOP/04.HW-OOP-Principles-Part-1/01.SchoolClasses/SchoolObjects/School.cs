namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class School : SchoolObject
    {
        private string schoolName;
        private List<SchoolClass> schoolClass;

        public School(string name)
        {
            this.SchoolName = name;
            this.schoolClass = new List<SchoolClass>();
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }
            set
            {
                this.schoolName = value;
            }
        }

        public List<SchoolClass> SchoolClass
        {
            get
            {
                return this.schoolClass;
            }
            set
            {
                this.schoolClass = value;
            }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.SchoolClass.Add(schoolClass);
        }

        public void RemoveClass(string classUniqueID)
        {
            int indexToBeRemoved = -1;
            int counter = 0;

            foreach (var scClass in SchoolClass)
            {
                if (scClass.TextIdentifier == classUniqueID)
                {
                    indexToBeRemoved = counter;
                    break;
                }
                counter++;

            }

            if (indexToBeRemoved == -1)
            {
                throw new Exception(String.Format("No entry for SchoolClass {0}", classUniqueID));
            }
            this.SchoolClass.RemoveAt(indexToBeRemoved);
        }

        public void PrintClasses()
        {
            var sb = new StringBuilder();

            foreach (var scClass in SchoolClass)
            {
                sb.Append("Class ");
                sb.Append(scClass.TextIdentifier);
                sb.Append("  ");
            }
            Console.WriteLine("The list of classes contains:\r\n{0}\r\n", sb.ToString());
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var schoolClass in SchoolClass)
            {
                sb.Append(schoolClass.ToString());
                sb.Append("\r\n\r\n\r\n");
            }
            return sb.ToString();
        }
    }
}

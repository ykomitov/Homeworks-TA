namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SchoolClass : SchoolObject
    {
        private static char uniqueTxtID = 'A';

        private string textIdentifier;
        private List<Teacher> classTeachers;
        private List<Student> classStudents;

        public SchoolClass()
        {
            this.textIdentifier = uniqueTxtID.ToString();
            uniqueTxtID++;
            this.classTeachers = new List<Teacher>();
            this.classStudents = new List<Student>();
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
        }

        public List<Teacher> ClassTeachers
        {
            get
            {
                return this.classTeachers;
            }
            set
            {
                this.classTeachers = value;
            }
        }

        public List<Student> ClassStudents
        {
            get
            {
                return this.classStudents;
            }
            set
            {
                this.classStudents = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.ClassTeachers.Add(teacher);
        }

        public void RemoveTeacher(string name)
        {
            int indexToBeRemoved = -1;
            int counter = 0;

            foreach (var teacher in ClassTeachers)
            {
                if (teacher.PersonName == name)
                {
                    indexToBeRemoved = counter;
                    break;
                }
                counter++;
            }

            //remove student
        }

        public void AddStudent(Student student)
        {
            this.ClassStudents.Add(student);
        }

        public void RemoveStudent(string studentName)
        {
            foreach (var st in ClassStudents)
            {
                if (st.PersonName == studentName)
                {
                    ClassStudents.Remove(st);
                    break;
                }
            }
        }

        public void AddSubject(string teacherName, SchoolSubject newSubject)
        {
            foreach (var teacher in classTeachers)
            {
                if (teacher.PersonName == teacherName)
                {
                    teacher.SetOfSubjects.Add(newSubject);
                }
            }
        }

        public void RemoveSubject(string teacherName, string subjectNameToRemove)
        {
            foreach (var teacher in ClassTeachers)
            {
                if (teacher.PersonName == teacherName)
                {
                    foreach (var subject in teacher.SetOfSubjects.ToList())
                    {
                        if (subject.SubjectName == subjectNameToRemove)
                        {
                            teacher.SetOfSubjects.Remove(subject);
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var teacher in this.ClassTeachers)
            {
                sb.Append("\r\n\t");
                sb.Append(teacher.PersonName);
                if (teacher.Comment != null)
                {
                    sb.Append(" (");
                    sb.Append(teacher.Comment);
                    sb.Append(")");
                    sb.Append(", ");
                }
                sb.Append(" teaching: ");
                foreach (var subject in teacher.SetOfSubjects)
                {
                    sb.Append(subject.SubjectName);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append("\r\n");
            }
            var teacherString = sb.ToString();
            sb.Clear();

            foreach (var student in this.ClassStudents)
            {
                sb.Append("\r\n\t");
                sb.Append(student.PersonName);
                sb.Append(", ");
                if (student.Comment != null)
                {
                    sb.Append(student.Comment);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append("\r\n");
            }
            var studentString = sb.ToString();

            return String.Format("\tClass {0}\r\n\r\nTeachers:\r\n {1}\r\nStudents:\r\n {2}", textIdentifier, teacherString, studentString);
        }
    }
}
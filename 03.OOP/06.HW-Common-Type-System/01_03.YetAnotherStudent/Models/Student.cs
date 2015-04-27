namespace YetAnotherStudent.Models
{
    using System;
    using System.Text.RegularExpressions;
    using YetAnotherStudent.Enumeration;

    class Student : IEquatable<Student>, ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string familyName;
        private ulong socialSecurityNumber;
        private string permanentAddress;
        private string mobilePhoneNum;
        private string email;
        private byte course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string familyName, ulong socialSecurityNumber, string permanentAddress, byte course, Specialty specialty, University university, Faculty faculty, string mobilePhoneNum = null, string email = null)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.FamilyName = familyName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.PermanentAddress = permanentAddress;
            this.MobilePhoneNum = mobilePhoneNum;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                string test = value;
                bool isValidName = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsLetter(test[i]))
                    {
                        continue;
                    }
                    else
                    {
                        isValidName = false;
                        break;
                    }
                }

                if (!isValidName)
                {
                    throw new ArgumentException("Invalid first name. First name can only contain letters!");
                }
                this.firstName = UppercaseWords(value);
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                string test = value;
                bool isValidName = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsLetter(test[i]))
                    {
                        continue;
                    }
                    else
                    {
                        isValidName = false;
                        break;
                    }
                }

                if (!isValidName)
                {
                    throw new ArgumentException("Invalid middle name. Middle name can only contain letters!");
                }
                this.middleName = UppercaseWords(value);
            }
        }

        public string FamilyName
        {
            get
            {
                return this.familyName;
            }
            set
            {
                string test = value;
                bool isValidName = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsLetter(test[i]))
                    {
                        continue;
                    }
                    else
                    {
                        isValidName = false;
                        break;
                    }
                }

                if (!isValidName)
                {
                    throw new ArgumentException("Invalid family name. Family name can only contain letters!");
                }
                this.familyName = UppercaseWords(value);
            }
        }

        public ulong SocialSecurityNumber
        {
            get
            {
                return this.socialSecurityNumber;
            }
            set
            {
                /*Chech if the enterned SSN is a valid SSN. For more info:
                 * http://www.kik-info.com/check/check_egn.php 
                 * http://debian.fmi.uni-sofia.bg/~bogo/egn/egn.htm */

                string test = value.ToString();

                if (test.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("The SSN must be exactly 10 digits!");
                }

                int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
                int controlValueFromSSN = int.Parse(test.Substring(9));
                int calculatedControlValue = 0;
                for (int i = 0; i < test.Length - 1; i++)
                {
                    int positionValue = weights[i] * (test[i] - '0');
                    calculatedControlValue += positionValue;
                }

                calculatedControlValue = calculatedControlValue % 11;

                if (controlValueFromSSN != calculatedControlValue)
                {
                    throw new ArgumentException("Entered SSN is not a valid SSN!");
                }

                this.socialSecurityNumber = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhoneNum
        {
            get
            {
                return this.mobilePhoneNum;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsNumber(ch))
                    {
                        throw new Exception("Phone must contain only numeric characters!");
                    }
                }
                if (value.Substring(0, 1) != "0")
                {
                    throw new Exception("Phone number must start with \"0\"!");
                }

                this.mobilePhoneNum = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                Regex regex = new Regex("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled);

                bool isValid = regex.IsMatch(value);

                if (!isValid)
                {
                    throw new Exception("Entered email is not in a valid format (example: someone@somedomainname.com)");
                }

                this.email = value;
            }
        }

        public byte Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value == 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Student's course is always a number between 1 & 5");
                }
                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }

        //===========================================> correcting lowercase first letters
        public string UppercaseWords(string value)
        {
            if (value == null)
            {
                return "";
            }
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        public override string ToString()
        {
            return string.Format(@"Name: {0} {1} {2}, course: {7}

SSN: {3}
Address: {4}
Phone: {5}
Email: {6}, 
=========================
University: {9}
Faculty: {10}
Specialty: {8}
========================="
                , firstName, middleName, familyName, socialSecurityNumber, permanentAddress, mobilePhoneNum, email, course, specialty, university, faculty);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((firstName != null) ? this.firstName.GetHashCode() : 0);
                result = result * 23 + ((middleName != null) ? this.middleName.GetHashCode() : 0);
                result = result * 23 + ((familyName != null) ? this.familyName.GetHashCode() : 0);
                result = result * 23 + this.socialSecurityNumber.GetHashCode();
                result = result * 23 + ((permanentAddress != null) ? this.permanentAddress.GetHashCode() : 0);
                result = result * 23 + ((mobilePhoneNum != null) ? this.mobilePhoneNum.GetHashCode() : 0);
                result = result * 23 + ((email != null) ? this.email.GetHashCode() : 0);
                result = result * 23 + this.course.GetHashCode();
                result = result * 23 + this.specialty.GetHashCode();
                result = result * 23 + this.university.GetHashCode();
                result = result * 23 + this.faculty.GetHashCode();
                return result;
            }
        }

        public bool Equals(Student other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Equals(this.firstName, other.firstName) &&
                   Equals(this.middleName, other.middleName) &&
                   Equals(this.familyName, other.familyName) &&
                   this.socialSecurityNumber == other.socialSecurityNumber &&
                   Equals(this.permanentAddress, other.permanentAddress) &&
                   Equals(this.mobilePhoneNum, other.mobilePhoneNum) &&
                   Equals(this.email, other.email) &&
                   this.course == other.course &&
                   this.specialty.Equals(other.specialty) &&
                   this.university.Equals(other.university) &&
                   this.faculty.Equals(other.faculty);
        }

        public override bool Equals(object obj)
        {
            Student temp = obj as Student;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            //first name
            if (this.FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }

            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                //middle name
                if (this.MiddleName.CompareTo(other.MiddleName) < 0)
                {
                    return -1;
                }

                if (this.MiddleName.CompareTo(other.MiddleName) == 0)
                {
                    //family name
                    if (this.FamilyName.CompareTo(other.FamilyName) < 0)
                    {
                        return -1;
                    }

                    if (this.FamilyName.CompareTo(other.FamilyName) == 0)
                    {
                        //social security
                        if (this.SocialSecurityNumber.CompareTo(other.SocialSecurityNumber) < 0)
                        {
                            return -1;
                        }

                        if (this.SocialSecurityNumber.CompareTo(other.SocialSecurityNumber) == 0)
                        {
                            return 0;
                        }

                        else
                        {
                            return 1;
                        }
                    }

                    if (this.FamilyName.CompareTo(other.FamilyName) > 0)
                    {
                        return 1;
                    }
                    return 0;
                }

                if (this.MiddleName.CompareTo(other.MiddleName) > 0)
                {
                    return 1;
                }
                return 0;
            }

            else
            {
                return 1;
            }
        }

        public Student Clone() // Deep cloning (public method)
        {
            Student copy = new Student(this.FirstName, this.MiddleName, this.FamilyName, this.SocialSecurityNumber, this.PermanentAddress, this.Course, this.Specialty, this.University, this.Faculty, this.MobilePhoneNum, this.Email);
            return copy;
        }
    }
}

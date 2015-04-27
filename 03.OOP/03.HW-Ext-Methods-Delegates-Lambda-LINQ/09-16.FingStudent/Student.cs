namespace FindStudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Student
    {
        private string firstName;
        private string lastName;
        private uint fakNomer;
        private string telNumber;
        private string email;
        private List<uint> marks;
        private byte groupNum;

        public Student(string firstName, string lastName, uint fakNomer, string telNumber, string email, List<uint> marks, byte groupNum)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FakNomer = fakNomer;
            this.TelNumber = telNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNum = groupNum;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (Char.IsNumber(ch))
                    {
                        throw new Exception("First name must not contain numeric characters!");
                    }
                }
                this.firstName = value;
            }
        } //validated

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (Char.IsNumber(ch))
                    {
                        throw new Exception("Family name must not contain numeric characters!");
                    }
                }
                this.lastName = value;
            }
        } //validated

        public uint FakNomer
        {
            get
            {
                return this.fakNomer;
            }
            set
            {
                if (value < 10000000 || value > 99999999)
                {
                    throw new Exception("Entered faculty number is not valid. Faculty number should be between 10000000 and 99999999");
                }
                this.fakNomer = value;
            }
        } //validated

        public string TelNumber
        {
            get
            {
                return this.telNumber;
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
                this.telNumber = value;
            }
        } //validated

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
        } //validated

        public List<uint> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                foreach (var mark in value)
                {
                    if (mark < 2 || mark > 6)
                    {
                        throw new Exception("Only marks between 2 and 6 are accepted as valid input!");
                    }
                }
                this.marks = value;
            }
        } //validated

        public byte GroupNum
        {
            get
            {
                return this.groupNum;
            }
            set
            {
                this.groupNum = value;
            }
        } //accepts byte values only
    }
}
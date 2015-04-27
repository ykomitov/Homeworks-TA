namespace PersonClass
{
    using System;

    class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            string personAge;

            if (this.age == null)
            {
                personAge = "Not specified!";
            }
            else
            {
                personAge = age.ToString();
            }
            return String.Format("Person Name: {0}\r\nAge: {1}\r\n", name, personAge);
        }
    }
}

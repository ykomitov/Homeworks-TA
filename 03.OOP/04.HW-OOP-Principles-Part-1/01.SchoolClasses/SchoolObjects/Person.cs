namespace School
{
    using System;
    using System.Linq;

    abstract class Person : SchoolObject
    {
        private string personName;

        public Person(string name)
        {
            this.PersonName = name;
        }

        public string PersonName
        {
            get
            {
                return this.personName;
            }
            set
            {
                string test = value;
                bool isValidName = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsLetter(test[i]) || test[i] == 32)
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
                    throw new ArgumentException("Invalid person name. Person name can only contain letters & spaces!");
                }
                this.personName = value;
            }
        }
    }
}

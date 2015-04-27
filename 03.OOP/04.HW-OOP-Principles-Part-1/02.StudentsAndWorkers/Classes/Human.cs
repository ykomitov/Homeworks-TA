namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using System.Text;

    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
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
                    throw new ArgumentException("Invalid first name. First name can only contain letters & spaces!");
                }

                this.firstName = UppercaseWords(value);
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                string test = value;
                bool isValidName = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsLetter(test[i]) || test[i] == 32 || test[i] == '\'')
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
                    throw new ArgumentException("Invalid last name. Last name can only contain letters & spaces!");
                }

                this.lastName = UppercaseWords(value);
            }
        }

        //=== Method for correcting lowercase first letters
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
            // ... Uppercase the lowercase letters following spaces & ' (O'Brien).
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ' || array[i - 1] == '\'')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}

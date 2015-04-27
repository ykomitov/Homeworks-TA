namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Animal
    {
        private double age;
        private string name;
        private bool isMale;

        public Animal(string name, double age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public Animal(string name, double age)
        {
            this.Name = name;
            this.Age = age;
        }

        public double Age
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

        public string Name
        {
            get
            {
                return this.name;
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
                    throw new ArgumentException("Invalid name! Name can only contain letters!");
                }

                this.name = UppercaseWords(value);
            }
        }

        public bool IsMale
        {
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
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

        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            double avgAge = animals.Average(a => a.Age);
            
            return avgAge;
        }

        public virtual void ProduceSound()
        {
        }
    }
}

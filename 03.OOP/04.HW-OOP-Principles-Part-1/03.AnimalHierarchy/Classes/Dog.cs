namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Dog : Animal, ISound
    {
        public Dog(string name, double age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The dog {0} barks!", this.Name);
        }
    }
}

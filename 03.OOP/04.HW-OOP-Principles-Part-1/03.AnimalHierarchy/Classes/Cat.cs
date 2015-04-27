namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Cat : Animal, ISound
    {
        public Cat(string name, double age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public Cat(string name, double age)
            : base(name, age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The cat {0} meows!", this.Name);
        }
    }
}

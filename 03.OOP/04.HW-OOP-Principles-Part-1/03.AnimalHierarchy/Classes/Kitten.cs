namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Kitten : Cat, ISound
    {
        public Kitten(string name, double age)
            : base(name, age)
        {
            this.IsMale = false;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The kitten {0} meows!", this.Name);
        }
    }
}

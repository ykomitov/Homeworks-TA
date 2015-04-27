namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Frog : Animal, ISound
    {
        public Frog(string name, double age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The frog {0} croaks!", this.Name);
        }
    }
}

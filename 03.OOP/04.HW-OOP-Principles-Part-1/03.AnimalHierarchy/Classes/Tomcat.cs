namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, double age)
            : base(name, age)
        {
            this.IsMale = true;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The tomcat {0} meows!", this.Name);
        }
    }
}

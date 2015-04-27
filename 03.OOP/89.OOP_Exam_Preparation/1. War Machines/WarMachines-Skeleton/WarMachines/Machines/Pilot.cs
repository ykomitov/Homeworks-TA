namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string pilotName;
        private List<IMachine> machinesEngaged = new List<IMachine>();

        public Pilot(string pilotName)
        {
            this.Name = pilotName;
        }

        public string Name
        {
            get
            {
                return this.pilotName;
            }
            private set
            {
                this.pilotName = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machinesEngaged.Add(machine);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("{0} - {1} {2}",
                this.Name,
                this.machinesEngaged.Count != 0 ? this.machinesEngaged.Count.ToString() : "no",
                this.machinesEngaged.Count != 1 ? "machines" : "machine"));

            if (this.machinesEngaged != null)
            {
                var sortedMachines = this.machinesEngaged.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);
                foreach (var machine in sortedMachines)
                {
                    sb.Append(machine.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}

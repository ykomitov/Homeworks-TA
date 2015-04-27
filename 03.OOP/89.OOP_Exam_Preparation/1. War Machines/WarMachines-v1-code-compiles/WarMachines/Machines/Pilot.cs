namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string pilotName;
        private List<IMachine> machinesEngaged;

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

        /*(pilot name) – (number of machines/”no”) (“machine”/”machines”)
          - (machine name)
           *Type: (“Tank”/”Fighter”)
           *Health: (machine health points)
           *Attack: (machine attack points)
           *Defense: (machine defense points)
           *Targets: (machine target names/”None” – comma separated)
           *Defense: (“ON”/”OFF” – when applicable)
          - (machine name)
           *Type: (machine type)
           *Health: (machine health points)
           *Attack: (machine attack points)
           *Defense: (machine defense points)
           *Targets: (machine target names/”None” – comma separated)
           *Stealth: (“ON”/”OFF” – when applicable)*/

        public string Report()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        //TODO: overwrite ToString
    }
}

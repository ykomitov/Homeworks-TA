namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string machineName;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        //Constructor with all fields
        public Machine(string machineName, IPilot pilot, double healthPoints, double attackPoints, double defensePoints, IList<string> targets)
        {
            this.Name = machineName;
            this.Pilot = pilot;
            this.HealthPoints = healthPoints;
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
            this.targets = targets;
        }

        //Constructor without pilot
        public Machine(string machineName, double attackPoints, double defensePoints)
        {
            this.Name = machineName;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
        }

        public string Name
        {
            get
            {
                return this.machineName;
            }
            set
            {
                this.machineName = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return this.targets;
            }
        }

        public void Attack(string target)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}

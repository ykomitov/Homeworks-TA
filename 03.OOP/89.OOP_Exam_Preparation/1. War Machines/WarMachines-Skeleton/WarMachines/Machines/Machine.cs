namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string machineName;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        //Constructor without pilot
        public Machine(string machineName, double attackPoints, double defensePoints)
        {
            this.Name = machineName;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
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
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //index of the last '.' in the type of the machine
            int substringStart = this.GetType().ToString().LastIndexOf('.') + 1;

            sb.Append(String.Format("\r\n- {0}", this.Name));
            sb.Append(String.Format("\r\n *Type: {0}", this.GetType().ToString().Substring(substringStart)));
            sb.Append(String.Format("\r\n *Health: {0}", this.HealthPoints));
            sb.Append(String.Format("\r\n *Attack: {0}", this.AttackPoints));
            sb.Append(String.Format("\r\n *Defense: {0}", this.DefensePoints));

            if (this.targets.Count != 0)
            {
                sb.Append(String.Format("\r\n *Targets: {0}", String.Join(", ", this.targets)));
            }
            else
            {
                sb.Append(String.Format("\r\n *Targets: None"));
            }

            return sb.ToString().TrimEnd();
        }
    }
}

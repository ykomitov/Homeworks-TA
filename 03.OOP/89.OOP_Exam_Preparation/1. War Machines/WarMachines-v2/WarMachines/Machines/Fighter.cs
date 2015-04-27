namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {
        private bool inStealthMode;
        private bool canBeAttackedByTanks;

        public Fighter(string machineName, double attackPoints, double defensePoints, bool inStealthMode)
            : base(machineName, attackPoints, defensePoints)
        {
            this.HealthPoints = 200;            //fighter’s initial health points are always 200
            this.StealthMode = inStealthMode;

            if (inStealthMode)
            {
                this.canBeAttackedByTanks = false;
            }
            else
            {
                this.canBeAttackedByTanks = true;
            }
        }

        public bool CanBeAttackedByTanks
        {
            get
            {
                return this.canBeAttackedByTanks;
            }
        }

        public bool StealthMode
        {
            get
            {
                return this.inStealthMode;
            }
            private set
            {
                this.inStealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.inStealthMode == false)
            {
                this.inStealthMode = true;
                this.canBeAttackedByTanks = false;
            }
            else
            {
                this.inStealthMode = false;
                this.canBeAttackedByTanks = true;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.Append(String.Format("\r\n *Defense: {0}", this.inStealthMode == true ? "ON" : "OFF"));

            return sb.ToString().TrimEnd();
        }
    }
}

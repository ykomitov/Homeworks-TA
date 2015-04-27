namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, IMachine, ITank
    {
        private bool inDefenceMode;


        public Tank(string machineName, double attackPoints, double defensePoints)
            : base(machineName, attackPoints, defensePoints)
        {
            this.HealthPoints = 100;           //Initial health points are always 100
            this.ToggleDefenseMode();          //By default tanks’ defense mode should be turned on. 
        }

        public bool DefenseMode
        {
            get
            {
                return this.inDefenceMode;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.inDefenceMode == false)
            {
                this.inDefenceMode = true;
                this.DefensePoints += 30;

                //check for negative attack points when in defence mode
                if (this.AttackPoints - 40 <= 0)
                {
                    this.AttackPoints = 0;
                }
                else
                {
                    this.AttackPoints -= 40;
                }
            }
            else
            {
                this.inDefenceMode = false;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.Append(String.Format("\r\n *Defense: {0}", this.inDefenceMode == true ? "ON" : "OFF"));

            return sb.ToString().TrimEnd();
        }
    }
}

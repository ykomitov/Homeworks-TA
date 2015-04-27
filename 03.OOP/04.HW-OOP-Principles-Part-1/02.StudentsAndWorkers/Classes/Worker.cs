namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using System.Text;

    class Worker : Human
    {
        decimal weekSalary;
        byte workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, byte workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Week salary must be > 0!");
                }
                this.weekSalary = value;
            }
        }

        public byte WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new Exception("Work hours can't be < 0 or > 24!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary / this.WorkHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.FirstName);
            sb.Append(" ");
            sb.Append(this.LastName);
            sb.Append(String.Format(", earns {0:0.00} lv./hour", this.MoneyPerHour()));
            return sb.ToString();
        }
    }
}

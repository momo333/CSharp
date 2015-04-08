

namespace StudentsAndWorkers
{
    using System;
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker (string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if(value<1)
                {
                    throw new ArgumentException("The salary cannot be null!");
                }
                this.weekSalary = value; 
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if(value<1)
                {
                    throw new ArgumentException("Working hours should be at least one or fire him!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPeHour()
        {
            return this.weekSalary / (this.workHoursPerDay * 5);
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.MoneyPeHour();
        }
    }
}

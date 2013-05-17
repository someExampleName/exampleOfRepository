using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansTask
{
    class Worker:Human
    {
        // fields
        private double weekSalary;
        private int workHoursPerDay;

        // properties
        public double WeekSalary 
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay 
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        // constructor
        public Worker(string firstName,string lastName, double weekSalary, int workHoursPerDay)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double allHours = 5 * this.workHoursPerDay;
            double moneyPerHour = this.weekSalary / allHours;

            return moneyPerHour;
        }

    }
}

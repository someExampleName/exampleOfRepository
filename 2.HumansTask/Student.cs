using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansTask
{
    class Student:Human
    {
        // field
        private double grade;

        // property
        public double Grade 
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        // constructor
        public Student()
            :this(default(string),default(string),default(double))
        { }
        public Student(string firstName, string lastName, double grade)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            this.grade = grade;
        }
    }
}

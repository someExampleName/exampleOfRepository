﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansTask
{
   abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public string FirstName 
        {
            get
            {
                return this.firstName ;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public Human()
            :this(default(string),default(string))
        { }
        public Human(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}

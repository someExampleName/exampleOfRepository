using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Person
    {
        protected string name;

        // property
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        // contstructor of the class
        public Person()
            :this(default(string))
        { }
        public Person(string name)
        {
            this.name = name;
        }
    }
}

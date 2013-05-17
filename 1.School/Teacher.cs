using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher:Person
    {
        private List<Discipline> disciplines;

        // property
        public List<Discipline> Disciplines { get; set; }

        //constructor
        public Teacher(string name, List<Discipline> disciplines)
        {
            base.name = name;
            this.disciplines = new List<Discipline>(disciplines);
        }
    }
}

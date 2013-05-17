using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimals
{
    class Tomcat:Cat
    {
        public Tomcat()
            :this("Unknown",default(int))
        { }
        public Tomcat(string name, int age)
        {
            base.Name = name;
            base.Age = age;
            base.Sex = 'm';
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimals
{
    class Kitten:Cat
    {
        public Kitten()
            :this("Unknown",default(int))
        { }
        public Kitten(string name, int age)
        {
            base.Sex = 'f';
            base.Name = name;
            base.Age = age;
        }
    }
}

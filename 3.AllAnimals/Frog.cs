using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimals
{
    class Frog:Animal
    {
        public Frog(string name, int age, char sex)
        {
            base.Name = name;
            base.Age = age;
            base.Sex = sex;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Kwa-kwa!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimals
{
    // The class is abstract because I don't want to create an inctance of it - only from Kitten and Tomcat
    abstract class Cat:Animal
    {
        public Cat()
            :this("Unknown",default(int),default(char))
        { }
        public Cat(string name, int age, char sex)
        {
            base.Name = name;
            base.Age = age;
            base.Sex = sex;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }
    }
}

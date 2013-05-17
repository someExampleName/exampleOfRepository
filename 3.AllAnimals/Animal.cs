using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimals
{
    abstract class Animal:ISound
    {
        private int age;
        private string name;
        private char sex;

        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
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
        public char Sex 
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }


        public virtual void ProduceSound()
        {
            Console.WriteLine("Every animal produce some different sound.");
        }

        public static double GetAvgAge(Animal[] animal)
        {
            double avgAge = 0;
            int currentSum = 0;
            for (int i = 0; i < animal.Length; i++)
            {
                currentSum += animal[i].Age;
            }
            avgAge = (double)currentSum/animal.Length;

            return avgAge;
        }

        public static void GetAnimalBySound(Animal animal)
        {
            Console.WriteLine("{0} is: {1}",animal.Name,animal.GetType().Name);
        }
    }
}

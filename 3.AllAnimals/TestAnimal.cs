using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnimals
{
    class TestAnimal
    {
        static void Main(string[] args)
        {
            // creating objects from all classes
            Frog[] frogs = 
            {
               new Frog("Josh",5,'f'),
               new Frog("Mon",6,'m'),
               new Frog("Pono",3,'f')
            };

            Dog[] dogs = 
            {
                new Dog("Rex",10,'m'),
                new Dog("Sisa",3,'f'),
                new Dog("Sharo",5,'m')
            };
            Kitten[] kittens = 
            {
                new Kitten("Pisi",3),
                new Kitten("Lili",4),
                new Kitten("Kiki",10)
            };
            Tomcat[] tomcats =
            {
                new Tomcat("Misho",10),
                new Tomcat("Riko",4),
                new Tomcat("Pauo",7)
            };

            // Testing how GetAvgAge method works.
            Console.WriteLine("--- Calculate the average age of each kind of animal: ---");
            double avgAgeFrogs = Animal.GetAvgAge(frogs);
            Console.WriteLine("The avarage sum of ages of Frogs is: {0}.",avgAgeFrogs);
            double avgAgeDogs = Animal.GetAvgAge(dogs);
            Console.WriteLine("The avarage sum of ages of Dogs is: {0}.", avgAgeDogs);
            double avgAgeKittens = Animal.GetAvgAge(kittens);
            Console.WriteLine("The avarage sum of ages of Kittens is: {0}.", avgAgeKittens);
            double avgAgeTomcats = Animal.GetAvgAge(tomcats);
            Console.WriteLine("The avarage sum of ages of Tomcats is: {0}.", avgAgeTomcats);

            // Getting the animal by its sound
            Console.WriteLine("\n--- Identifying the animal by its sound: ---");
            Animal.GetAnimalBySound(tomcats[0]);
            Animal.GetAnimalBySound(kittens[0]);
            Animal.GetAnimalBySound(frogs[0]);
        }
    }
}

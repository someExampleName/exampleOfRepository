using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansTask
{
    class TestHumans
    {
        public static void Main()
        {
            //initializing 10 students and 10 workers
            List<Student> students = new List<Student>() 
            {
                new Student("Pesho","Peshev",5.3),
                new Student("Misho","Mishev",4.35),
                new Student("Kristian","Shikov",3.3),
                new Student("Mario","Mariov",4.67),
                new Student("Lubomir","Rachev",6.0),
                new Student("Kristina","Pavlova",5.54),
                new Student("Sashka","Kosteva",4.98),
                new Student("Radoslav","Angelov",5.74),
                new Student("Angelina","Sotirova",4.96),
                new Student("Margarita","Kaneva",6.0),
                
            };
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Dimityr","Aseonv",50.5,8),
                new Worker("Ani","Malinova",40.8,8),
                new Worker("Kaloqn","Kristov",80.8,9),
                new Worker("Mimka","Kikova",38,4),
                new Worker("Radoslav","Penchev",90.1,10),
                new Worker("Kalinka","Hristova",45.4,8),
                new Worker("Angel","Angelov",87.3,10),
                new Worker("Iliana","Evova",89.9,9),
                new Worker("Krasimir","Karaivanov",92,11),
                new Worker("Luboslav","Vychkov",74.3,8),
            };

            // If you want to enter your own examples just erease the comment's markers and mark these that are above:

              // Console.WriteLine("Enter information about 10 students");
              // for (int i = 0; i < 10; i++)
              // {
              //     Console.WriteLine("Enter first name: ");
              //     string firstName = Console.ReadLine();
              //     Console.WriteLine("Enter last name: ");
              //     string lastName = Console.ReadLine();
              //     Console.WriteLine("Enter grade: ");
              //     double grade = double.Parse(Console.ReadLine());
              //     students[i] = new Student(firstName, lastName, grade);
              // }
              //
              // Worker[] workers = new Worker[10];
              //
              // Console.WriteLine("Enter information about 10 workers: ");
              // for (int i = 0; i < 10; i++)
              // {
              //     Console.WriteLine("Enter first name: ");
              //     string firstName = Console.ReadLine();
              //     Console.WriteLine("Enter last name: ");
              //     string lastName = Console.ReadLine();
              //     Console.WriteLine("Enter week salary: ");
              //     double weekSalary = double.Parse(Console.ReadLine());
              //     Console.WriteLine("Enter work hours per day: ");
              //     int workHoursPerDay = int.Parse(Console.ReadLine());
              //     workers[i] = new Worker(firstName, lastName, weekSalary, workHoursPerDay);
              // }

            // Sorting students by grade as using Lambda expresion
            List<Student> sortedStudents = students.OrderBy(x => x.Grade).ToList();

            // Sorting workers by money per hour as using Lambda expresion
            List<Worker> sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            //printing workers and students
            int counter = 1;
            Console.WriteLine("Students in ascending order(ordered by grade): ");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0}: {1} {2}.", counter, student.FirstName, student.LastName);
                counter++;
            }
            Console.WriteLine();

            Console.WriteLine("Workers in descending order(ordered by money per hour): ");
            counter = 1;
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0}: {1} {2}.", counter, worker.FirstName, worker.LastName);
                counter++;
            }

            // Mergin the list of workers and students
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            // Sorting workers and students
            var sortedHumans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            // Print sortedHumans
            Console.WriteLine("\nStudents and Workers ordered by their names: ");
            counter = 1;
            foreach (var human in sortedHumans)
            {
                Console.WriteLine("{0}: {1} {2}.",counter,human.FirstName,human.LastName);
                counter++;
            }
        }
    }
}

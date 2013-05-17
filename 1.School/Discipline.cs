using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Discipline
    {
        //fields of the class
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<string> comments;

        //properties
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
        public int NumberOfLectures 
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures =value;
            }
        }
        public int NumberOfExercises 
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }
        public List<string> Comments 
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = new List<string>(value);
            }
        }

        //constructor
        public Discipline(string name,int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}

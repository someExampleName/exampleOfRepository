using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student:Person
    {
        //fields
        private int numberInClass;
        private List<string> comments;

        // creating the properties
        public int NumberInClass
        {
            get
            {
                return this.numberInClass;
            }
            set
            {
                this.numberInClass = value;
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
        public Student(string name, int numberInClass)
        {
            base.name = name;
            this.numberInClass = numberInClass;
            this.comments = new List<string>();
        }

        // In order to enable the user to add comment we could make a method AddComment
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}

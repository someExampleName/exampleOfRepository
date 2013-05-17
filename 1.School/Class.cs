using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class
    {
        // due to the fact that classes contain students we need to have a field made of list of students
        private List<Student> students;

        // each class has a set of teachers => we need a list of teachers
        private List<Teacher> teachers = new List<Teacher>();
        private string identifier;
        private List<string> comments;

        // properties of the field
        public List<Student> Students 
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = new List<Student>(value); // in this way we copy the value, not only the reference
            }
        }

        public string Identifier 
        {
            get
            {
                return this.identifier;
            }
            set
            {
                this.identifier = value;
            }
        }

        public List<Teacher> Teachers 
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = new List<Teacher>(value);
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

        // constructor
        public Class()
        {
            this.students = new List<Student>();
            this.comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}

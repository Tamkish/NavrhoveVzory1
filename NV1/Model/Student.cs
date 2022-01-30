using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1.Model
{
    class Student : Person
    {
        const int maxcount = 5;
        static List<Student> students;


        private Student(int age, Genders gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
        }

        public new Student GetInstance(int age, Genders gender, string name)
        {
            if (students == null)
                students = new List<Student>();

            if (students.Count > maxcount)
            {
                return null; //if cannot create new one
            }
            else
            {
                Student student = new Student(age, gender, name);
                students.Add(student);
                return student;
            }
        }

        public override string ToString()
        {
            return "Student " + base.ToString();
        }
    }
}

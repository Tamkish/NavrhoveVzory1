using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1.Model
{
    class Student : Person
    {
        public Student(int age, Genders gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
        }

        public override string ToString()
        {
            return "Student " + base.ToString();
        }
    }
}

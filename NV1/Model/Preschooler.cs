using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1.Model
{
    class Preschooler : Person
    {
        public Preschooler(int age, Genders gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
        }

        public override string ToString()
        {
            return "Preschooler " + base.ToString();
        }
    }
}

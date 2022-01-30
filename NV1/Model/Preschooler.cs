using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1.Model
{
    class Preschooler : Person
    {
        static Preschooler Instance;
   
        private Preschooler(int age, Genders gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
        }

        public static new Preschooler GetInstance(int age, Genders gender, string name)
        {
            if (Instance == null)
            {
                Instance = new Preschooler(age, gender, name);
            }
            return Instance;
        }

        public override string ToString()
        {
            return "Preschooler " + base.ToString();
        }
    }
}

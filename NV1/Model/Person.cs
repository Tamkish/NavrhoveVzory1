using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1.Model
{
    class Person
    {
        public int Age { get; protected set; }
        public Genders Gender { get; protected set; }
        public string Name { get; protected set; }

        public static Person GetInstance(int age, Genders gender, string name)
        {

            if (age < 0)
                return null;

            if (age <= 7)
                return new Preschooler(age, gender, name);

            if (age <= 19)
                return new Student(age, gender, name);

            if (age <= 65)
                return new Worker(age, gender, name);
            
            else
                return new Senior(age, gender, name);
        }

        public Person Aging(int years)
        {
            return GetInstance(Age + years, Gender, Name);
        }

        public override string ToString()
        {
            return Name + " (" + Genders.GetName(Gender) + " " + Age + ") ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1.Model
{
    class Worker : Person
    {
        static List<Worker> workers;

        private Worker(int age, Genders gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
        }

        public new Worker GetInstance(int age, Genders gender, string name)
        {
            if (workers == null)
                workers = new List<Worker>();

            Worker newWorker = new Worker(age, gender, name);

            foreach (Worker worker in workers)
            {
                if (worker == newWorker)
                    return worker;
            }

            workers.Add(newWorker);
            return newWorker;

        }

        public override string ToString()
        {
            return "Worker " + base.ToString();
        }
    }
}

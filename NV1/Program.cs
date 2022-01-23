using NV1.Model;
using System;

namespace NV1
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Type name...");
            Console.Write(">");
            string name = Console.ReadLine();

            bool validInput = false;
            int age = 0;
            while (!validInput)
            {
                Console.Clear();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Type age...");
                Console.Write(">");
                validInput = int.TryParse(Console.ReadLine(), out age);
            }

            validInput = false;
            Genders gender = Genders.Unknown;
            while (!validInput)
            {
                Console.Clear();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Select gender");
                Console.WriteLine("[0] None/Unknown");
                Console.WriteLine("[1] Male");
                Console.WriteLine("[2] Female");
                Console.WriteLine("[3] Other");
                Console.Write(">");

                validInput = true;
                switch (Console.ReadLine())
                {
                    case "0":
                        gender = Genders.Unknown;
                        break;

                    case "1":
                        gender = Genders.Male;
                        break;

                    case "2":
                        gender = Genders.Female;
                        break;

                    case "3":
                        gender = Genders.Other;
                        break;

                    default:
                        validInput = false;
                        break;
                }
            }

            Person person = Person.GetInstance(age, gender, name);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(person);
                int aging;
                if (int.TryParse(Console.ReadLine(),out aging))
                {
                    person = person.Aging(aging);
                }
            }


        }
    }
}

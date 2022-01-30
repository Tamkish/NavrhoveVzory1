using NV1.Model;
using System;
using System.Collections.Generic;

namespace NV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            while (true)
            {
                Console.Clear();
                ListPeople();

                Console.WriteLine("[C]reate");
                Console.WriteLine("[A]ge");

                Console.Write("> ");
                switch (Console.ReadLine().ToLower())
                {
                    case "c":
                        CreatePerson();
                        break;

                    case "a":
                        AgePerson();
                        break;

                    default:
                        break;
                }
            }

            void ListPeople()
            {
                Console.WriteLine("People:");
                if (people.Count==0)
                {
                    Console.WriteLine(" <empty>");
                }
                else
                {

                foreach (var name in people.Keys)
                {
                    Console.WriteLine(" "+name+" - " + people[name]);
                }
                }
            }
            void CreatePerson()
            {
                Console.Clear();
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

                if (people.ContainsKey(name)) //name exists
                {
                    if (people[name] == person)
                        return; //exact copy
                    else
                        name += "*"; //just same name
                }
                people.Add(name, Person.GetInstance(age, gender, name));
            }


            //doesnt fully work
            /*
            void AgePerson()
            {
                string name;
                do
                {
                    Console.Clear();
                    ListPeople();
                    Console.WriteLine("Type a name... (empty to cancel)");
                    Console.Write(">");
                    name = Console.ReadLine();

                    if (name == "") return;

                } while (!people.ContainsKey(name));

                Person person = people[name];
                int age;
                string inputage;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Change age... (empty to cancel)");
                    Console.WriteLine(person);
                    Console.Write(">");
                    inputage = Console.ReadLine();
                    
                    if (inputage == "") return;

                } while (!int.TryParse(inputage, out age));
                person.Aging(age);
            }*/
            


        }
    }
}

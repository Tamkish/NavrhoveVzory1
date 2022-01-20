using NV1.Model;
using System;

namespace NV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba karel = Osoba.GetInstance(6, Pohlavi.Male, "Karel");
            Console.WriteLine("Hello World!");
        }
    }
}

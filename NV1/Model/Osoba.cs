using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV1.Model
{
    class Osoba
    {
        public int Vek { get; private set; }
        public Pohlavi Pohlavi { get; private set; }
        public string Jmeno { get; private set; }

        public static Osoba GetInstance(int vek, Pohlavi pohlavi, string jmeno)
        {

            if (vek < 0)
                return null;

            if (vek < 7)
                return new Predskolak(vek, pohlavi, jmeno);

        }
    }
}

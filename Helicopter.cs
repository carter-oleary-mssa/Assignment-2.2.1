using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._1
{
    internal class Helicopter : Aircraft
    {
        public int Rotors { get; set; }

        public Helicopter(string id, int r = 2) : base(id)
        {
            Rotors = r;
        }
    }
}

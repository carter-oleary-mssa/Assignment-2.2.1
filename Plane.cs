using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._1
{
    internal class Plane : Aircraft
    {
        public int Engines { get; set; }
        public int Seats { get; set; }

        public Plane(string id, int e = 1, int s = 1) : base(id)
        {
            Engines = e;
            Seats = s;
        }
    }
}

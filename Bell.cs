using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._1
{
    internal class Bell : Helicopter
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Bell(string id, string name, string description, int r = 2) :base(id, r)
        {
            Name = name; Description = description;
        }
    }
}

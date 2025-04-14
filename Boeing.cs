using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._1
{
    internal class Boeing : Plane
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Boeing(string id, string name, string description, int e = 1, int s = 1) : base(id, e, s)
        {
            Name = name;
            Description = description;
        }
    }
}

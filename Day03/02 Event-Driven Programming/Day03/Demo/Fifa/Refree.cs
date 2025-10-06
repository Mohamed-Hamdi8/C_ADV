using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Refree
    {
        public string Name { get; set; }
        public void Look(Ball ball) => Console.WriteLine($"{Name} Is Looking at ball ....");
        public override string ToString() => $"Refree : {Name}";
    }
}

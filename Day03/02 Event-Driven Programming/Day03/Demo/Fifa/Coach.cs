using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Coach
    {
        public string Name { get; set; }
        public void Order(Ball ball) =>Console.WriteLine( $"{Name} Is Order Player .... ");

        public override string ToString() => $"Coach : {Name}"; 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public void Run(Ball ball) => Console.WriteLine($"{Name} Is Running ....");
        public override string ToString() => $"Player : {Name} , Team : {Team}";
    }
}

using Demo.Fifa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Youtube
{
    internal class Subscriber
    {
        public string Name { get; set; }
        public void Notify(Video video) => Console.WriteLine($"You Received Notifcation At New Video {video.Title},{Name} .... ");
    }
}

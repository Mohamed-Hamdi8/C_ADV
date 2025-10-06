using Demo.Fifa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Youtube
{
    internal class Channel
    {
        public string Title { get; set; }
        public List<Video> Videos { get; set; } = new List<Video>();
        public void AddVideo(Video video)
        {
            if(video != null )
            {
                Videos.Add(video);
                NewVideoAdded?.Invoke(video);
            }
        }

        public event Action<Video> NewVideoAdded;
    }
}

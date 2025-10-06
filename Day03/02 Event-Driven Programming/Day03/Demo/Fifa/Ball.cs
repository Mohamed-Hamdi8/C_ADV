using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }
        public event Action<Ball> BallLocationChanged;
        private Location location;
        public Location Location
        {
            get { return location; }
            set
            {
                if(!value.Equals(location))
                {
                    location = value;
                    BallLocationChanged?.Invoke(this);
                }
            }
        }

        public override string ToString() => $"Ball : {Id} , Location : {location}";
    }
}

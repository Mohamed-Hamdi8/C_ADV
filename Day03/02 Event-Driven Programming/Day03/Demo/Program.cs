using Demo.Fifa;
using Demo.Youtube;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Event EX01
            //Ball ball = new Ball() { Id = 1001 };
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };

            //Player P01 = new Player() { Name = "Maloul", Team = "AlAhly" };
            //Player P02 = new Player() { Name = "Hani", Team = "AlAhly" };
            //Player P03 = new Player() { Name = "Vini", Team = "Real Madrid" };
            //Player P04 = new Player() { Name = "Modric", Team = "AC Milan" };

            //Refree R01 = new Refree() { Name = "Gehad Gresha" };

            /////Invoktion List [Queue]
            //ball.BallLocationChanged += new Action<Ball>(P01.Run);
            ////ball.BallLocationChanged += P01.Run;
            //ball.BallLocationChanged += P02.Run;
            //ball.BallLocationChanged += P03.Run;
            //ball.BallLocationChanged += P04.Run;
            //ball.BallLocationChanged += R01.Look;

            //ball.Location = new Location() { X = 1, Y = 2, Z = 1 };
            //Console.WriteLine();
            //Console.WriteLine("*************** Replace Player ****************");
            //Console.WriteLine();
            //Player P05 = new Player() { Name = "El Dbess", Team = "ALAhly" };
            //ball.BallLocationChanged -= P01.Run;
            //ball.BallLocationChanged += P05.Run;

            //ball.Location = new Location() { X = 1, Y = 2, Z = 2 };

            //Console.WriteLine();
            //Console.WriteLine("*************** Coach Order Players ****************");
            //Console.WriteLine();
            //Coach C01 = new Coach() { Name = "Emad ELNahaas" };
            //ball.BallLocationChanged += C01.Order;

            //ball.Location = new Location() { X = 2, Y = 2, Z = 2 }; 
            #endregion

            #region Event EX02
            //Channel channel = new Channel();
            //Subscriber S01 = new Subscriber(){Name = "Mohamed Hamdi"};
            //Subscriber S02 = new Subscriber(){Name = "Moahemd Fathy"};

            //channel.NewVideoAdded += S01.Notify;
            //channel.NewVideoAdded += S02.Notify;

            //channel.AddVideo(new Video() { Title = "Sba7o T7dy", Description = "Nso7y , Omar Marie" });
            //channel.AddVideo(new Video() { Title = "Sameh Sanad", Description = "Story Herror" }); 
            #endregion
        }
    }
}

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fecade = new HomeTheaterFacade(new Amplifier(), new DvdPlayer(), new Projector());
            fecade.WatchMovie("Inception");
            fecade.EndMovie();
        }
        public class HomeTheaterFacade
        {
            private Amplifier _amplifier;
            private DvdPlayer _dvdPlayer;
            private Projector _projector;

            public HomeTheaterFacade(Amplifier amplifier, DvdPlayer dvdPlayer, Projector projector)
            {
                _amplifier = amplifier;
                _dvdPlayer = dvdPlayer;
                _projector = projector;
            }

            public void WatchMovie(string movie)
            {
                Console.WriteLine("Get ready to watch a movie...");
                _amplifier.On();
                _dvdPlayer.On();
                _dvdPlayer.Play(movie);
                _projector.On();
            }

            public void EndMovie()
            {
                Console.WriteLine("Shutting movie theater down...");
                _projector.Off();
                _dvdPlayer.Stop();
                _dvdPlayer.Off();
                _amplifier.Off();
            }
        }
    }
}

namespace Spotify_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artiest TravisScott = new Artiest("Travis Scott", Genres.RnB);
            List<Artiest> zangertjes = new List<Artiest>();
            zangertjes.Add(TravisScott);

            Song HighestInTheRoom = new Song("Highest in the room", zangertjes, Genres.RnB, 4);

            Artiest Drake = new Artiest("Drake", Genres.HipHop);
            Artiest JCole = new Artiest("JCole", Genres.HipHop);
            zangertjes = new List<Artiest>();
            zangertjes.Add(Drake); zangertjes.Add(JCole);
            Song FirstPersonShooter = new Song("First person shooter", zangertjes, Genres.HipHop, 6);


            Artiest Swans = new Artiest("Swans", Genres.Rock);
            zangertjes = new List<Artiest>();
            zangertjes.Add(Swans);
            Song Oxigen = new Song("Oxigen", zangertjes, Genres.Rock, 3);

            List<Song> nummers = new List<Song>();
            nummers.Add(HighestInTheRoom); nummers.Add(FirstPersonShooter); nummers.Add(Oxigen);

            Playlist NareksNummers = new Playlist("Narek's nummers", nummers);
            NareksNummers.Shuffle();
            Console.WriteLine(NareksNummers);
            NareksNummers.Play();




        }
    }
}

namespace Spotify_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist Sabrina = new Artist("Sabrina Carpenter", MusicGenre.Pop, 5000);
            Sabrina.AddAlbum();
            Sabrina.AddAlbum();

            Artist BadBunny = new Artist("Bad Bunny", MusicGenre.Latin, 70000);
            Artist Tupac = new Artist("Tupac amaru shakur", MusicGenre.HipHop, 1);
            Artist Gims = new Artist("Jimmy LeGrand", MusicGenre.RnB, 50006);
            Artist Kendrick = new Artist("Kendrick Lamar", MusicGenre.Rap, 9001);
            Artist Drake = new Artist("Drake", MusicGenre.Autotune, 0);
            BadBunny.AddAlbum();
            Tupac.AddAlbum();
            Tupac.AddAlbum();
            Tupac.AddAlbum();
            Gims.AddAlbum();
            Kendrick.AddAlbum();
            Kendrick.AddAlbum();
            Kendrick.AddAlbum();
            Kendrick.AddAlbum();
            Drake.AddAlbum();

            Kendrick.RemoveAlbum();

            List<Artist> artists = new List<Artist>();
            artists.Add(Sabrina); artists.Add(BadBunny); artists.Add(Tupac);
            artists.Add(Gims); artists.Add(Kendrick); artists.Add(Drake);

            /*foreach (var item in artists)
            {
                Console.WriteLine(item);
            }*/
            //Artist a in artists


            Song Espresso = new Song("Espresso", Sabrina, 4, MusicGenre.Pop);
            Song Dtmf = new Song("Dtmf", BadBunny, 5, MusicGenre.Latin);
            Song DearMama = new Song("Dear Mama", Tupac, 3, MusicGenre.HipHop);
            Song Spider = new Song("Spider", Gims, 4, MusicGenre.Rap);
            Song SwimmingPools = new Song("Swimming Pools", Kendrick, 3, MusicGenre.Rap);
            Song Massive = new Song("Massive", Drake, 2, MusicGenre.HipHop);

            List<Song> songs = new List<Song>();
            songs.Add(Espresso); songs.Add(Dtmf); songs.Add(DearMama);
            songs.Add(Spider); songs.Add(SwimmingPools); songs.Add(Massive);

            /*foreach (Song s in songs)
            {
                s.Play();
            }*/

            Playlist Vibes = new Playlist("Vibes", songs);
            Vibes.Shuffle();
            Console.WriteLine(Vibes);
            Vibes.Play();


        }
    }
}

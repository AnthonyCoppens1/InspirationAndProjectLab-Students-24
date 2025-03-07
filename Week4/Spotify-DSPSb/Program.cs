

namespace Spotify_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist Pascal = new Artist("Pasci", MusicType.Classical);
            Artist Justin = new Artist("Justin Bieber", MusicType.Pop);
            Artist Drake = new Artist("Drake", MusicType.HipHop);
            Artist Eminem = new Artist("Eminem", MusicType.Rap);
            Artist SabrinaCarpenter = new Artist("Sabrina Carpenter", MusicType.Pop);
            Artist BensonBoon = new Artist("Benson Boon", MusicType.Pop);
            Artist Skrillex = new Artist("Skrillex", MusicType.Dubstep);
            Justin.AddAlbum();
            Justin.AddAlbum();
            Pascal.AddAlbum();
            Eminem.AddAlbum();
            Eminem.AddAlbum();
            Eminem.AddAlbum();
            Eminem.AddAlbum();
            BensonBoon.AddAlbum();
            Skrillex.AddAlbum();

            Eminem.RemoveAlbum();

            List<Artist> artists = new List<Artist>();
            artists.Add(Pascal);
            artists.Add(Justin);
            artists.Add(Drake);
            artists.Add(SabrinaCarpenter);
            artists.Add(BensonBoon);
            artists.Add(Skrillex);
            artists.Add(Eminem);

            /*foreach (Artist a in artists)
            {
                Console.WriteLine(a);
            }*/

            Song Sorry = new Song("Sorry", Justin, MusicType.Pop, 5);
            Song Conscious = new Song("Conscious", Pascal, MusicType.Classical, 2);
            Song HotLineBling = new Song("HotLineBling", Drake, MusicType.HipHop, 4);
            Song Espresso = new Song("Espresso", SabrinaCarpenter, MusicType.Pop, 3);
            Song BeautifulThings = new Song("Beautiful Things", BensonBoon, MusicType.Pop, 5);
            Song Bangarang = new Song("Bangarang", Skrillex, MusicType.Dubstep, 2);
            Song SlimShady = new Song("Slim Shady", Eminem, MusicType.Rap, 4);

            List<Song> songs = new List<Song>();
            songs.Add(Sorry); songs.Add(Conscious); songs.Add(HotLineBling);
            songs.Add(Espresso); songs.Add(BeautifulThings); songs.Add(Bangarang);
            songs.Add(SlimShady);

            /*foreach (Song s in songs)
            {
                s.Play();
            }*/


            Playlist playlist1 = new Playlist("playlist1", songs);
            playlist1.Shuffle();
            Console.WriteLine(playlist1);
            playlist1.Play();

        }
    }
}

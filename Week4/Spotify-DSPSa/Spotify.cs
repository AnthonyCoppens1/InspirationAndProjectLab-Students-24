using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_DSPSa
{
    public class Artist
    {
        public MusicGenre Genre { get; set; }
        public string Name { get; set; }
        public int Followers { get; set; }
        public int AlbumCount { get; set; }

        public Artist(string name, MusicGenre genre, int followers)
        {
            Name = name;
            Genre = genre;
            Followers = followers;
            AlbumCount = 0; //Some artists can have 0 albums but many songs
        }

        public void AddAlbum()
        {
            AlbumCount++;
        }

        public void RemoveAlbum()
        {
            if (AlbumCount > 0)
            {
                AlbumCount--;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Genre} - Albums: {AlbumCount} - Followers: {Followers}";
        }
    }


    public class Song
    {
        public string Title { get; set; }
        public Artist Singer { get; set; }
        public int Time { get; set; }
        public MusicGenre Genre { get; set; }

        public Song(string title, Artist singer, int time, MusicGenre genre)
        {
            Title = title;
            Singer = singer;
            Time = time;
            Genre = genre;
        }

        public void Play()
        {   
            Console.WriteLine($"Now Playing: {Title} by {Singer.Name}");
            for (int i = 0; i < Time; i++)
            {
                Console.Write($"{Time - i} ");
                Console.Beep();
                Thread.Sleep(1000);
            }
            Console.WriteLine($"\nFinished Playing: {Title} by {Singer.Name}\n");
        }

        public override string ToString()
        {
            return $"{Title} - {Singer.Name} - {Genre} - {Time}";
        }
    }


    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int Time { get; set; }

        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
            Time = 0;
        }

        public Playlist(string name, List<Song> songs)
        {
            Name = name;
            Songs = songs;
            Time = 0;
            foreach (Song s in Songs)
            {
                Time += s.Time;
            }
        }

        public void AddSong(Song s)
        {
            Songs.Add(s);
            Time += s.Time;
        }

        public void RemoveSong(Song s)
        {
            Songs.Remove(s);
            Time -= s.Time;
        }

        public void Play()
        {
            foreach (Song s in Songs)
            {
                s.Play();
            }
        }

        public override string ToString()
        {
            string s = $"PLAYLIST:{Name} - Duration: {Time}\n";
            foreach (Song so in Songs)
            {
                s += $"* {so} \n";
            }

            return s;
        }

        public void Shuffle()
        {
            Random rd = new Random();
            for (int i = Songs.Count - 1; i >= 0; i--)
            {
                int nr = rd.Next(0, i + 1);
                Song temp = Songs[nr];
                Songs[nr] = Songs[i];
                Songs[i] = temp;
            }
        }
    }















    public enum MusicGenre
    {
        Pop,
        Jazz,
        Rock,
        Funk,
        House,
        Rap,
        DrumAndBass,
        RnB,
        Blues,
        Classical,
        Soul,
        Electronic,
        Techno,
        Dubstep,
        Latin,
        World,
        SoundTrack,
        Alternative,
        Indie,
        Trance,
        Metal,
        HeavyMetal,
        MetalCore,
        FrenchCore,
        BlackMetal,
        DeathMetal,
        Country,
        Disco,
        Swing,
        Ska,
        Hardstyle,
        Reggae,
        Cher,
        Children,
        Podcast,
        HipHop,
        Autotune
    }
}

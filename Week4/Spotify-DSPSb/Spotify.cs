using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_DSPSb
{
    public class Song
    {
        public Artist Singer { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public MusicType Genre { get; set; }

        public Song(string title, Artist singer, MusicType genre, int duration)
        {
            Title = title;
            Singer = singer;
            Genre = genre;
            Duration = duration;
        }

        public void Play()
        {
            Console.WriteLine($"Now playing: {Title} by {Singer.Name}");
            Console.Write($" Duration remaining:");
            for (int i = 0; i < Duration; i++)
            {
                Console.Write($"{Duration - i} "); //check duration length left
                Console.Beep();
                Thread.Sleep(1000);

            }
            Console.WriteLine($"\nFinished playing: {Title} by {Singer.Name}");
        }
        //ignore pause for now

        public override string ToString()
        {
            return $"{Title} - {Singer.Name} - {Duration} - {Genre}";
        }

    }

    public class Artist
    {
        public string Name { get; set; }
        public MusicType Genre { get; set; }
        public int AlbumCount { get; private set; }

        public Artist(string name, MusicType genre)
        {
            Name = name;
            Genre = genre;
            AlbumCount = 0;
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
                //Want to prevent negative amount of albums
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Genre} - Albums: {AlbumCount}";
        }


    }

    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int Duration { get; set; }

        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
            Duration = 0;
        }

        public Playlist(string name, List<Song> songs)
        {
            Name = name;
            Songs = songs;
            Duration = 0;
            foreach (var item in Songs)
            {
                Duration += item.Duration;
            }
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
            Duration += song.Duration;
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
            Duration -= song.Duration;
        }

        public void Play()
        {
            foreach (Song song in Songs)
            {
                song.Play();
            }
        }

        public override string ToString()
        {
            string s = $"{Name} - Duration: {Duration}\n";
            foreach (Song song in Songs)
            {
                s += "*" + song + "\n";
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

    public enum MusicType
    {
        Pop,
        Jazz,
        Rock,
        HipHop,
        HeavyMetal,
        Dubstep,
        DrumAndBass,
        Classical,
        Opera,
        Rap,
        RnB,
        Afro,
        Country,
        Techno,
        Electronic,
        Soul,
        Folk,
        Punk,
        House,
        Trance,
        Alternative,
        Indie,
        Ska,
        Swing,
        Disco,
        Latin,
        World,
        NewAge,
        Childrens,
        SoundTrack,
        Blues,
        Reggae
    }
}

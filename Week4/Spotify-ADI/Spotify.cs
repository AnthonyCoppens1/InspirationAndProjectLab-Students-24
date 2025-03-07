using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_ADI
{
    public class Song
    {
        public string Titel { get; set; }
        public List<Artiest> Zangers { get; set; }
        public Genres Genre { get; set; }
        public int Tijd { get; set; }

        public Song(string titel, List<Artiest> zangers, Genres genre, int tijd)
        {
            Titel = titel;
            Zangers = zangers;
            Genre = genre;
            Tijd = tijd;
        }

        public void Play()
        {
            Console.WriteLine($"Now playing: {Titel} by ");
            for (int i = 0; i < Tijd; i++)
            {
                Console.Write($"{Tijd - i} ");
                Console.Beep();
                Thread.Sleep(1000);
            }
            Console.WriteLine($"\nFinished playing: {Titel} by"); 
        }

        public override string ToString()
        {
            string s = $"{Titel} - ";
            foreach (Artiest a in Zangers)
            {
                s += $"{a.Naam} - ";
            }

            s += $"{Genre} - {Tijd}";
            return s;

        }


    }

    public class Artiest
    {
        public string Naam { get; set; }
        public Genres Genre { get; set; }
        public int AlbumCount { get; private set; }

        public Artiest(string naam, Genres genre)
        {
            Naam = naam;
            Genre = genre;
            AlbumCount = 0;
        }

        public void VoegAlbumToe()
        {
            AlbumCount++;
        }

        public void VerwijderAlbum()
        {
            if (AlbumCount > 0)
            {
                AlbumCount--;
            }
        }
    }

    public class Playlist
    {
        public string Naam { get; set; }
        public List<Song> Songs { get; set; }
        public int Tijd { get; set; }

        public Playlist(string naam)
        {
            Naam = naam;
            Songs = new List<Song>();
            Tijd = 0;
        }

        public Playlist(string naam, List<Song> songs)
        {
            Naam = naam;
            Songs = songs;
            Tijd = 0;
            foreach (Song s in Songs)
            {
                Tijd += s.Tijd;
            }
        }

        public void VoegSongToe(Song s)
        {
            Songs.Add(s);
            Tijd += s.Tijd;
        }

        public void VerwijderSong(Song s)
        {
            Songs.Remove(s);
            Tijd -= s.Tijd;
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
            string str = $"{Naam} - Duur: {Tijd}\n";
            foreach (Song s in Songs)
            {
                str += $"*{s}\n";
            }
            return str;
        }

        public void Shuffle()
        {
            Random rd = new Random();
            for (int i = Songs.Count - 1; i >= 0; i--) //A B C D E
            {
                int nr = rd.Next(0, i + 1); //0 1 2 3 4 
                Song temp = Songs[nr];
                Songs[nr] = Songs[i];
                Songs[i] = temp;
            }
        }

    }




    public enum Genres
    {
        HipHop,
        RnB,
        Techno,
        House,
        Rock,
        Pop,
        Funk,
        HeavyMetal,
        Folk,
        Jazz,
        Classical,
        Country,
        Trance,
        Electronic,
        EDM,
        Dubstep,
        DrumAndBass,
        TripHop,
        Reggae,
        Hardcore,
        Hardstyle,
        FrenchCore,
        BlackMetal,
        Metal,
        Rap,
        Experimental,
        Indie,
        Alternative,
        Swing,
        Ska,
        NewAge,
        SoundTrack,
        Podcast,
        Children,
        Blues,
        Soul,
        Sacrellic,
        Latin
    }
}

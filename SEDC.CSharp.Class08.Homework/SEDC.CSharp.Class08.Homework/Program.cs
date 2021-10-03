using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharp.Class08.Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> FansArray = new List<Person>();
            //fans
            Person Jerry = new Person("Jerry", "Tompson", 78, Genre.Rock);
            Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
            Person Maria = new Person("Maria", "Campbel", 43, Genre.Classical);
            Person Jane = new Person("Jane", "Doe", 28, Genre.Techno);

            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
            Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
            Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
            Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
            Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
            Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
            Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
            Song song10 = new Song("Fight the Power", 321, Genre.Techno);
            Song song11 = new Song("The Message", 363, Genre.Techno);
            Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
            Song song13 = new Song("No Fear", 182, Genre.Techno);
            Song song14 = new Song("Hereditary", 340, Genre.Techno);
            Song song15 = new Song("Bounce Back", 226, Genre.Techno);
            Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
            Song song17 = new Song("Canon in D major", 376, Genre.Classical);
            Song song18 = new Song("Swan Lake", 461, Genre.Classical);
            Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
            Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
            Song song23 = new Song("Planet E", 420, Genre.Techno);
            Song song24 = new Song("Phasor", 368, Genre.Techno);
            Song song25 = new Song("Counting Comets", 242, Genre.Techno);
            Song song26 = new Song("Cold Summer", 358, Genre.Techno);
            Song song27 = new Song("Destroyer", 359, Genre.Techno);
            Song song28 = new Song("Phalanx", 307, Genre.Techno);
            Song song29 = new Song("Vision", 693, Genre.Techno);
            Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

            List<Song> Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                                song8, song9, song10, song11, song12, song13, song14,
                                                song15, song16, song17, song18, song19, song20,
                                                song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };

            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);

            //Select  the person Jerry and add all the songs which start with the letter B
            List<Song> jerryFavouriteSongs = Songs.Where(x => x.Title.StartsWith("B")).ToList();
            Jerry.FavoriteSongs = jerryFavouriteSongs;
            Jerry.GetFavSongs();

            //Select  the person Maria and add all the songs with length  longer than 6 mins
            List<Song> mariaFavouriteSongs = Songs.Where(x => x.Length / 60 > 6).ToList();
            Maria.FavoriteSongs = mariaFavouriteSongs;
            Maria.GetFavSongs();

            //Select the person Jane and add all the songs that are of genre Rock
            List<Song> janeFavouriteSongs = Songs.Where(x => x.Genre == Genre.Rock).ToList();
            Jane.FavoriteSongs = janeFavouriteSongs;
            Jane.GetFavSongs();

            //Select  the person Stefan and add all songs shorter than 3 mins and of genre Hip-Hop
            List<Song> stefanFavouriteSongs = Songs.Where(x => x.Length / 60 < 3).Where(x => x.Genre == Genre.Hip_hop).ToList();
            Stefan.FavoriteSongs = stefanFavouriteSongs;
            Stefan.GetFavSongs();

            //Select  all persons from the persons array that have 4 or more songs
            var personsWithFourOrMoreSongs = FansArray.Where(x => x.FavoriteSongs.Count() >= 4).Select(x => x.FName).ToList();
            Console.WriteLine("The people with 4 or more favourite songs are:");
            GoThroughCollection(personsWithFourOrMoreSongs, "");
        }
        static void GoThroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name} items:");
            foreach (var item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
    

    
}

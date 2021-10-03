using ClassLibrary;
using System;
using System.Collections.Generic;

namespace SEDC.CSharp.Class08.Homework.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Rose",325,Genre.Rock);
            Song song2 = new Song("Table",225,Genre.Hip_hop);
            Song song3 = new Song("Lady",325,Genre.Classical);
            Song song4 = new Song("Nail",325,Genre.Techno);

            List<Song> songs = new List<Song>()
            {
                song1,
                song4
            };

            Person John = new Person("John", "Smith", 28, Genre.Techno);
            John.FavoriteSongs = songs;
            John.GetFavSongs();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Person
    {
        private int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string fName, string lName, int age, Genre favGenre)
        {
            this.FName = fName;
            this.LName = lName;
            this.Age = age;
            this.FavoriteMusicType = favGenre;
        }
        public void GetFavSongs()
        {
            if (FavoriteSongs.Count > 0)
            {
                Console.WriteLine($"{FName} likes these songs: ");
                foreach(Song song in FavoriteSongs)
                {
                    Console.WriteLine($"Song:{song.Title}, Length: {song.Length}, Genre: {song.Genre}");
                }
            } else
            {
                Console.WriteLine($"{FName} Doesn't have favourite songs");
            }
        }
    }
}

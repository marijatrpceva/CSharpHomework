using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Cinema
    {
        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            this.Name = name;
            this.Halls = halls;
            this.ListOfMovies = movies;
        }
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }
        public void MoviePlaying(Movie movie)
        {
      

            if (movie == null)
            {
                throw new Exception();
            }          
         Console.WriteLine($"Watching movie {movie.Title}");
           
        }
    }
}

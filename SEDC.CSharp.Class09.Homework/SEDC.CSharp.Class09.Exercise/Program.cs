using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharp.Class09.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            Cinema cinema1 = new Cinema("Cineplexx", new List<int>() { 1, 2, 3, 4 }, MovieSet1);
            Cinema cinema2 = new Cinema("Milenium", new List<int>() { 1, 2 }, MovieSet2);

            Console.WriteLine("Choose a cinema, enter 1 for Cineplexx, 2 for Milenium");
            string cinemaChoiceString = Console.ReadLine();
            Cinema chosenCinema = cinema1;
            int cinemaChoice = 0;
            try
            {
                cinemaChoice = Int32.Parse(cinemaChoiceString);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Somting is wrong {ex}");
            }
            List<Movie> chosenCinemaSet= MovieSet1;
            if (cinemaChoice == 1)
            {
                chosenCinemaSet = MovieSet1;
                chosenCinema = cinema1;
            } 
            else if(cinemaChoice == 2)
            {
                chosenCinemaSet = MovieSet2;
                chosenCinema = cinema2;
            }
            else
            {
                try
                {
                    throw new Exception("Wrong cinema choice");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); 
                }
                
            }

            Console.WriteLine("Choose 1 to see all movies or 2 by genre");
            string seeAllMoviesOByGenre = Console.ReadLine();
            if ( seeAllMoviesOByGenre == "1")
            {
                List<string> namesOfTheMovies = MovieList(chosenCinemaSet);
                GoThroughCollection(namesOfTheMovies);
                Console.WriteLine("Enter the movie you want to watch");
                string movieToWatch = Console.ReadLine();
                Movie chosenMovie = chosenCinemaSet.FirstOrDefault(movie => movie.Title.ToLower() == movieToWatch.ToLower());
                try
                {
                    chosenCinema.MoviePlaying(chosenMovie);
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"The movie does not exist: {ex}");
                }
                
            }
            else if(seeAllMoviesOByGenre == "2")
            {
                Console.WriteLine("Enter your favourite genre: ");
                string inputGenre = Console.ReadLine();
                List<string> moviesByGenre = chosenCinemaSet.Where(movie => movie.Genre.ToString().ToLower() == inputGenre.ToLower()).Select(movie => movie.Title).ToList();
                GoThroughCollection(moviesByGenre);
                Console.WriteLine("Enter the movie you want to watch");
                string movieToWatch = Console.ReadLine();
                Movie chosenMovie = chosenCinemaSet.FirstOrDefault(movie => movie.Title.ToLower() == movieToWatch.ToLower());
                try
                {
                    chosenCinema.MoviePlaying(chosenMovie);
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"The movie does not exist: {ex}");
                }

            }

        }
        static List<string> MovieList(List<Movie> movies)
        {
            List<string> shownMovies = movies.Select(movie => movie.Title).ToList();
            return shownMovies;
        }
        static void GoThroughCollection(IEnumerable collection)
        {
            Console.WriteLine($"The movies are:");
            foreach (var item in collection)
            {
                Console.WriteLine($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace ClassLibrary1
{
    public class Movie
    {
        public Movie(string title, Genre genre, int rating)
        {
            this.Title = title;
            this.Genre = genre;
            if (rating <= 5 && rating >= 1)
            {
                this.Rating = rating;
            } else
            {
                throw new Exception("The rating you added is not valid");
            }
            this.TicketPrice = 5 * rating;

        }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }
        public void showData()
        {
            Console.WriteLine($"The title is {Title}, of genre: {Genre}, rating: {Rating}, and the price: {TicketPrice}");
        }
    }
}

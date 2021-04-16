using System;
using SEDC.CsBasicHomework.Class09.Domain.Classes;

namespace SEDC.CsBasicHomework.Class09.Domain
{
    public class Movie
    {
        public Movie()
        {

        }
        public Movie(string title, Genre genre, int rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                this.Rating = rating;
            }
            else
            {
                throw new Exception();
            }
            this.Title = title;
            this.Genre = genre;
            this.TicketPrice = 5 * rating;
        }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }
    }
}

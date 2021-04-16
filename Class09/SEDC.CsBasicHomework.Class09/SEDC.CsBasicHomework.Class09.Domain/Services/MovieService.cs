using System;
using System.Collections.Generic;
using System.Text;
using SEDC.CsBasicHomework.Class09.Domain.Classes;

namespace SEDC.CsBasicHomework.Class09.Domain.Services
{
    public class MovieService
    {
        public List<Movie> MovieSet1 { get; set; } = new List<Movie>
        {
        new Movie("Scary Movie", Genre.Comedy, 4),
        new Movie("American Pie", Genre.Comedy, 4),
        new Movie("Saw", Genre.Horror, 4),
        new Movie("The Shining", Genre.Horror, 4),
        new Movie("Rambo", Genre.Action, 4),
        new Movie("The Terminator", Genre.Action, 4),
        new Movie("Forrest Gump", Genre.Drama, 4),
        new Movie("12 Angru Men", Genre.Drama, 4),
        new Movie("Passengers", Genre.SciFi, 4),
        new Movie("Interstellar", Genre.SciFi, 4),
        };
        public List<Movie> MovieSet2 { get; set; } = new List<Movie>
        {
            new Movie("Airplane", Genre.Comedy, 4),
            new Movie("Johnny English", Genre.Comedy, 4),
            new Movie("The Ring", Genre.Horror, 4),
            new Movie("Sinister", Genre.Horror, 4),
            new Movie("RoboCop", Genre.Action, 4),
            new Movie("Judge Dredd", Genre.Action, 4),
            new Movie("The Social Network", Genre.Drama, 4),
            new Movie("The Shawshank Redemption", Genre.Drama, 4),
            new Movie("Inception", Genre.SciFi, 4),
            new Movie("Avatar", Genre.SciFi, 4),
        };

    }
};


/*List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
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
*/


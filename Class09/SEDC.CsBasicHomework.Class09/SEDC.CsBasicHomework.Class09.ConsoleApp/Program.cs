using System;
using System.Collections.Generic;
using System.Linq;
using SEDC.CsBasicHomework.Class09.Domain;
using SEDC.CsBasicHomework.Class09.Domain.Classes;
using SEDC.CsBasicHomework.Class09.Domain.Services;

namespace SEDC.CsBasicHomework.Class09.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data
            //Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
            //Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            //Movie movie3 = new Movie("Saw", Genre.Horror, 4);
            //Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            //Movie movie5 = new Movie("Rambo", Genre.Action, 4);
            //Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
            //Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
            //Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
            //Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
            //Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
            //List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            //Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            //Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
            //Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            //Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            //Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            //Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            //Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
            //Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
            //Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
            //Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);
            //List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            //Cinema cinema1 = new Cinema("Cineplexx", new List<int>() { 1, 2, 3, 4 }, MovieSet1);
            //Cinema cinema2 = new Cinema("Milenium", new List<int>() { 1, 2 }, MovieSet2);
            #endregion

            TotheMovies();

            Console.ReadLine();
        }
        public static void TotheMovies()
        {
            MovieService movieService = new MovieService();
            Cinema cinema1 = new Cinema("Cineplexx", new List<int>() { 1, 2, 3, 4 }, movieService.MovieSet1);
            Cinema cinema2 = new Cinema("Milenium", new List<int>() { 1, 2 }, movieService.MovieSet2);

            Console.WriteLine("Please choose a cinema");
            Console.WriteLine($"1.{cinema1.Name} \n2.{cinema2.Name}");

            Cinema userCinema = new Cinema();

            int userCinemaChoice = IsValidUserCinemaChoice(Console.ReadLine());
            while (userCinemaChoice == 0)
            {
                Console.WriteLine($"1.{cinema1.Name} \n2.{cinema2.Name}");
                userCinemaChoice = IsValidUserCinemaChoice(Console.ReadLine());

            }
            switch (userCinemaChoice)
            {
                case 1:
                    userCinema = cinema1;
                    break;
                case 2:
                    userCinema = cinema2;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Do you want to see \n1.All movies \n2.By Genre");
            int userChoiceOfMovies = IsValidUserCinemaChoice(Console.ReadLine());
            while (userChoiceOfMovies == 0)
            {
                Console.WriteLine("Do you want to see \n1.All movies \n2.By Genre");
                userChoiceOfMovies = IsValidUserCinemaChoice(Console.ReadLine());
            }

            if (userChoiceOfMovies == 1) // all movies
            {
                userCinema.PrintMovies(userCinema.ListOfMovies);
            }

            List<Movie> userMovieChoice = null;
            if (userChoiceOfMovies == 2) // by genre
            {
                while (userMovieChoice == null)
                {
                    try
                    {
                        Console.WriteLine($"Please enter your favorite genre");
                        userMovieChoice = userCinema.FilterMoviesByGenre(Console.ReadLine());
                        userCinema.PrintMovies(userMovieChoice);
                    }
                    catch (InvalidGenreException ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                }
            }

            Movie selectedMovie = null;
            Console.WriteLine("Enter the movie number to watch the movie");
            if (userChoiceOfMovies == 1)
            {
                while (selectedMovie == null)
                {
                    try
                    {
                        selectedMovie = userCinema.IsValidMovieSelection(userCinema.ListOfMovies, Console.ReadLine());
                    }
                    catch (InvalidMovieSelectedException ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                }
            }

            if (userChoiceOfMovies == 2)
            {
                while (selectedMovie == null)
                {
                    try
                    {
                        selectedMovie = userCinema.IsValidMovieSelection(userMovieChoice, Console.ReadLine());
                    }
                    catch (InvalidMovieSelectedException ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                }
            }
            userCinema.MoviePlaying(selectedMovie);
        }
        public static int IsValidUserCinemaChoice(string userInput


    }
}

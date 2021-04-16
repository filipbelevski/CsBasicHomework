using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SEDC.CsBasicHomework.Class09.Domain.Classes
{
    public class Cinema
    {
        public Cinema()
        {

        }
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
            Console.WriteLine($"Watching {movie.Title}");
        }

        public void PrintMovies(List<Movie> movies)
        {
            Console.WriteLine("Please select a movie by entering the number");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Title},   Genre: {movies[i].Genre}");
            }
        }

        public List<Movie> FilterMoviesByGenre(string userInput)
        {
            List<Movie> filteredMovies = ListOfMovies.Where(movie => movie.Genre.ToString().ToLower() == userInput.ToLower()).ToList(); ;
            if (filteredMovies.Count == 0)
            {
                throw new InvalidGenreException();
            }
            try
            {
                filteredMovies = ListOfMovies.Where(movie => movie.Genre.ToString().ToLower() == userInput.ToLower()).ToList(); ;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch
            {
                throw new InvalidGenreException();
            }

            return filteredMovies;
        }

        public Movie IsValidMovieSelection(List<Movie> movies, string userInput)
        {
            Movie selectedMovie = new Movie();
            bool IsValidUserInput = int.TryParse(userInput, out int validUserInput);
            if (!IsValidUserInput)
            {
                throw new InvalidMovieSelectedException();
            }
            try
            {
                selectedMovie = movies[validUserInput - 1];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + " please enter a valid number since this number doesn't ");
            }
            catch
            {
                throw new InvalidMovieSelectedException();
            }

            return selectedMovie;
        }

    }
}

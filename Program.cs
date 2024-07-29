using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Creating movie management system object
			MovieLogic movieLogic = new MovieLogic();

			// Adding sample movies
			movieLogic.AddMovie(new Movie(1, "The Shawshank Redemption", Genre.Drama, 1994, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 142, 9.3, "Frank Darabont", new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, true));
			movieLogic.AddMovie(new Movie(2, "The Godfather", Genre.Drama, 1972, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", 175, 9.2, "Francis Ford Coppola", new List<string> { "Marlon Brando", "Al Pacino", "James Caan" }, true));
			movieLogic.AddMovie(new Movie(3, "The Dark Knight", Genre.Action, 2008, "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", 152, 9.0, "Christopher Nolan", new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" }, true));

			// Displaying all movies
			Console.WriteLine("All Movies:");
			movieLogic.ViewAllMovies();
			Console.WriteLine();

			// Updating a movie
			movieLogic.UpdateMovie(2, "The Godfather Part II", Genre.Drama, 1974, "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", 202, 9.0, "Francis Ford Coppola", new List<string> { "Al Pacino", "Robert De Niro", "Robert Duvall" }, true);

			// Displaying updated movie
			Console.WriteLine("Updated Movie:");
			movieLogic.SearchMovieByTitle("The Godfather Part II");
			Console.WriteLine();

			// Deleting a movie
			movieLogic.DeleteMovie(1);

			// Displaying all movies after deletion
			Console.WriteLine("All Movies after Deletion:");
			movieLogic.ViewAllMovies();
			Console.WriteLine();

			// Searching for a movie by title
			Console.WriteLine("Search Results:");
			movieLogic.SearchMovieByTitle("The Dark Knight");
			Console.WriteLine();

			// Searching for movies by genre
			Console.WriteLine("Movies in Drama Genre:");
			movieLogic.SearchMoviesByGenre(Genre.Drama);
			Console.WriteLine();

			// Displaying action history
			movieLogic.DisplayActionHistory();

			Console.ReadLine();
		}
	}
}

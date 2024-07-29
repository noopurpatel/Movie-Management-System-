using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3
{
	// Movie Management System class
	public class MovieLogic :IMovie
	{
		private LinkedList<Movie> moviesList; // Using linked list to store movies
		private Stack<string> actionHistory; // Using stack to maintain action history
		private Dictionary<int, Movie> movieDictionary; // Using dictionary for fast movie lookup by ID

		// Constructor
		public MovieLogic()
		{
			moviesList = new LinkedList<Movie>();
			actionHistory = new Stack<string>();
			movieDictionary = new Dictionary<int, Movie>();
		}

		// Method to add a movie
		public void AddMovie(Movie movie)
		{
			moviesList.AddLast(movie);
			actionHistory.Push($"Added movie: {movie.Title}");
			movieDictionary.Add(movie.MovieID, movie);
		}

		// Method to view all movies
		public void ViewAllMovies()
		{
			foreach (var movie in moviesList)
			{
				movie.DisplayDetails();
				Console.WriteLine();
			}
		}

		// Method to update a movie
		public void UpdateMovie(int movieID, string title, Genre genre, int releaseYear, string description, int duration, double rating, string director, List<string> cast, bool isAvailable)
		{
			Movie movieToUpdate;
			if (movieDictionary.TryGetValue(movieID, out movieToUpdate))
			{
				movieToUpdate.Title = title;
				movieToUpdate.Genre = genre;
				movieToUpdate.ReleaseYear = releaseYear;
				movieToUpdate.Description = description;
				movieToUpdate.Duration = duration;
				movieToUpdate.Rating = rating;
				movieToUpdate.Director = director;
				movieToUpdate.Cast = cast;
				movieToUpdate.IsAvailable = isAvailable;
				actionHistory.Push($"Updated movie: {title}");
			}
			else
			{
				Console.WriteLine("Movie not found.");
			}
		}

		// Method to delete a movie
		public void DeleteMovie(int movieID)
		{
			Movie movieToDelete;
			if (movieDictionary.TryGetValue(movieID, out movieToDelete))
			{
				moviesList.Remove(movieToDelete);
				actionHistory.Push($"Deleted movie: {movieToDelete.Title}");
				movieDictionary.Remove(movieID);
				Console.WriteLine("Movie deleted successfully.");
			}
			else
			{
				Console.WriteLine("Movie not found.");
			}
		}

		// Method to search for a movie by title
		public void SearchMovieByTitle(string title)
		{
			Movie movie = moviesList.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
			if (movie != null)
			{
				movie.DisplayDetails();
			}
			else
			{
				Console.WriteLine("Movie not found.");
			}
		}

		// Method to search for movies by genre
		public void SearchMoviesByGenre(Genre genre)
		{
			var matchingMovies = moviesList.Where(m => m.Genre == genre);
			if (matchingMovies != null && matchingMovies.Any())
			{
				foreach (var movie in matchingMovies)
				{
					movie.DisplayDetails();
					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("No movies found for the specified genre.");
			}
		}

		// Method to display action history
		public void DisplayActionHistory()
		{
			Console.WriteLine("Action History:");
			foreach (var action in actionHistory)
			{
				Console.WriteLine(action);
			}
		}
	}
}

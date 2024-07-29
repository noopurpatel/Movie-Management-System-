using System.Collections.Generic;

namespace Module3
{
	public interface IMovie
	{
		void AddMovie(Movie movie);
		void ViewAllMovies();
		void UpdateMovie(int movieID, string title, Genre genre, int releaseYear, string description, int duration, double rating, string director, List<string> cast, bool isAvailable);
		void DeleteMovie(int movieID);
		void SearchMovieByTitle(string title);
		void SearchMoviesByGenre(Genre genre);

	}
}

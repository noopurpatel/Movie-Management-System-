using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
	// Movie class
	public class Movie
	{
		// Properties
		public int MovieID { get; set; }
		public string Title { get; set; }
		public Genre Genre { get; set; }
		public int ReleaseYear { get; set; }
		public string Description { get; set; }
		public int Duration { get; set; }
		public double Rating { get; set; }
		public string Director { get; set; }
		public List<string> Cast { get; set; }
		public bool IsAvailable { get; set; }

		// Constructor
		public Movie(int id, string title, Genre genre, int releaseYear, string description, int duration, double rating, string director, List<string> cast, bool isAvailable)
		{
			MovieID = id;
			Title = title;
			Genre = genre;
			ReleaseYear = releaseYear;
			Description = description;
			Duration = duration;
			Rating = rating;
			Director = director;
			Cast = cast;
			IsAvailable = isAvailable;
		}

		// Method to display movie details
		public void DisplayDetails()
		{
			Console.WriteLine($"Title: {Title}");
			Console.WriteLine($"Genre: {Genre}");
			Console.WriteLine($"Release Year: {ReleaseYear}");
			Console.WriteLine($"Description: {Description}");
			Console.WriteLine($"Duration: {Duration} minutes");
			Console.WriteLine($"Rating: {Rating}");
			Console.WriteLine($"Director: {Director}");
			Console.WriteLine($"Cast: {string.Join(", ", Cast)}");
			Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
		}
	}
}

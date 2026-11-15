using Newtonsoft.Json;
using System.Collections.Generic;

namespace RapidApiConsume.Models
{
	public class ApiMovieResponse
	{
		public int page { get; set; }
		public List<ApiMovieViewModel> result { get; set; }
	}
	public class ApiMovieViewModel
	{
		public int rank { get; set; }

		[JsonProperty("Series_Title")]
		public string title { get; set; }

		[JsonProperty("Released_Year")]
		public string year { get; set; }

		[JsonProperty("Poster_Link")]
		public string poster { get; set; }

		[JsonProperty("Genre")]
		public string genre { get; set; }

		[JsonProperty("IMDB_Rating")]
		public string rating { get; set; }

		[JsonProperty("Overview")]
		public string overview { get; set; }

		[JsonProperty("Director")]
		public string director { get; set; }
	}
}

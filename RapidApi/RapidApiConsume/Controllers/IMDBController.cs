using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
	public class IMDBController : Controller
	{
		public async Task<IActionResult> Index()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-1000-movies-series.p.rapidapi.com/list/1"),
				Headers =
			{
				{ "x-rapidapi-key", "apikey" },
				{ "x-rapidapi-host", "imdb-top-1000-movies-series.p.rapidapi.com" },
			},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ApiMovieResponse>(body);
				return View(values.result);
			}
		}
	}
}

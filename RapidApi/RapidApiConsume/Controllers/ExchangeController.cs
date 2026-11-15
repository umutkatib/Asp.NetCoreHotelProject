using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
	public class ExchangeController : Controller
	{
		public async Task<IActionResult> Index()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/timeseries?start_date=2025-11-15&end_date=2026-11-15&base=USD&symbols=TRY"),
				Headers =
	{
		{ "x-rapidapi-key", "apikey" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ExchangeViewModel>(body);
				return View(values);
			}
		}
	}
}

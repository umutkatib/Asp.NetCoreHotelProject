using Newtonsoft.Json;
using System.Collections.Generic;

namespace RapidApiConsume.Models
{
	public class ExchangeViewModel
	{
		public bool success { get; set; }
		public bool timeseries { get; set; }

		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		[JsonProperty("base")]
		public string BaseCurrency { get; set; }

		public Dictionary<string, Dictionary<string, decimal>> rates { get; set; }
	}
}

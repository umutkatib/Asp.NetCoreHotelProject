using HotelProject.WebUI.Dtos.SocialMediaDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
	public class _FooterSocialMediaPartialComponent : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _FooterSocialMediaPartialComponent(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:49068/api/SocialMedias");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

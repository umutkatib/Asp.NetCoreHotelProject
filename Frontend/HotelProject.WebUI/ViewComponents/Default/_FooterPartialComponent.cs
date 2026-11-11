using HotelProject.WebUI.Dtos.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
	public class _FooterPartialComponent : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _FooterPartialComponent(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:49068/api/Contacts");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

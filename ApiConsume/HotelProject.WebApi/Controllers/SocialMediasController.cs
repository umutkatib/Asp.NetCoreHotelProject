using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.SocialMediaDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SocialMediasController : ControllerBase
	{
		private readonly ISocialMediaService _socialMediaService;
		private readonly IMapper _mapper;

		public SocialMediasController(ISocialMediaService socialMediaService, IMapper mapper)
		{
			_socialMediaService = socialMediaService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult SocialMediaList()
		{
			return Ok(_mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult SocialMediaAdd(CreateSocialMediaDto createSocialMediaDto)
		{
			var value = _mapper.Map<SocialMedia>(createSocialMediaDto);
			_socialMediaService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult SocialMediaDelete(int id)
		{
			_socialMediaService.TDelete(_socialMediaService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult SocialMediaUpdate(UpdateSocialMediaDto updateSocialMediaDto)
		{
			var value = _mapper.Map<SocialMedia>(updateSocialMediaDto);
			_socialMediaService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult SocialMediaGet(int id)
		{
			var value = _socialMediaService.TGetByID(id);
			return Ok(_mapper.Map<GetSocialMediaDto>(value));
		}
	}
}

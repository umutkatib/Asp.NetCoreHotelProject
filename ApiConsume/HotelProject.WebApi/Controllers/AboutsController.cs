using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.AboutDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AboutsController : ControllerBase
	{
		private readonly IAboutService _aboutService;
		private readonly IMapper _mapper;

		public AboutsController(IAboutService AboutService, IMapper mapper)
		{
			_aboutService = AboutService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult AboutList()
		{
			return Ok(_mapper.Map<List<ResultAboutDto>>(_aboutService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult AboutAdd(CreateAboutDto createAboutDto)
		{
			var existingAbouts = _aboutService.TGetListAll();
			if(existingAbouts != null && existingAbouts.Any())
			{
				return BadRequest("Sistemde zaten 1 adet Hakkımızda kaydı bulunmaktadır. Yeni kayıt eklenemez.");
			}
			var value = _mapper.Map<About>(createAboutDto);
			_aboutService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult AboutDelete(int id)
		{
			_aboutService.TDelete(_aboutService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult AboutUpdate(UpdateAboutDto updateAboutDto)
		{
			var value = _mapper.Map<About>(updateAboutDto);
			_aboutService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult AboutGet(int id)
		{
			var value = _aboutService.TGetByID(id);
			return Ok(_mapper.Map<GetAboutDto>(value));
		}
	}
}

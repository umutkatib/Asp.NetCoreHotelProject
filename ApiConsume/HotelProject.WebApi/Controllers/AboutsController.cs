using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.AboutDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AboutsController : ControllerBase
	{
		private readonly IAboutService _AboutService;
		private readonly IMapper _mapper;

		public AboutsController(IAboutService AboutService, IMapper mapper)
		{
			_AboutService = AboutService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult AboutList()
		{
			return Ok(_mapper.Map<List<ResultAboutDto>>(_AboutService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult AboutAdd(CreateAboutDto createAboutDto)
		{
			var value = _mapper.Map<About>(createAboutDto);
			_AboutService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult AboutDelete(int id)
		{
			_AboutService.TDelete(_AboutService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult AboutUpdate(UpdateAboutDto updateAboutDto)
		{
			var value = _mapper.Map<About>(updateAboutDto);
			_AboutService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult AboutGet(int id)
		{
			var value = _AboutService.TGetByID(id);
			return Ok(_mapper.Map<GetAboutDto>(value));
		}
	}
}

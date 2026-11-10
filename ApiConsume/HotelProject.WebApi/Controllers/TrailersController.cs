using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.TrailerDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TrailersController : ControllerBase
	{
		private readonly ITrailerService _trailerService;
		private readonly IMapper _mapper;

		public TrailersController(ITrailerService trailerService, IMapper mapper)
		{
			_trailerService = trailerService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult TrailerList()
		{
			return Ok(_mapper.Map<List<ResultTrailerDto>>(_trailerService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult TrailerAdd(CreateTrailerDto createTrailerDto)
		{
			var value = _mapper.Map<Trailer>(createTrailerDto);
			_trailerService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult TrailerDelete(int id)
		{
			_trailerService.TDelete(_trailerService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult TrailerUpdate(UpdateTrailerDto updateTrailerDto)
		{
			var value = _mapper.Map<Trailer>(updateTrailerDto);
			_trailerService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult TrailerGet(int id)
		{
			var value = _trailerService.TGetByID(id);
			return Ok(_mapper.Map<GetTrailerDto>(value));
		}
	}
}

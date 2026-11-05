using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.ServiceDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly IServiceService _serviceService;
		private readonly IMapper _mapper;

		public ServicesController(IServiceService serviceService, IMapper mapper)
		{
			_serviceService = serviceService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ServiceList()
		{
			return Ok(_mapper.Map<List<ResultServiceDto>>(_serviceService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult ServiceAdd(CreateServiceDto createServiceDto)
		{
			var value = _mapper.Map<Service>(createServiceDto);
			_serviceService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult ServiceDelete(int id)
		{
			_serviceService.TDelete(_serviceService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult ServiceUpdate(UpdateServiceDto updateServiceDto)
		{
			var value = _mapper.Map<Service>(updateServiceDto);
			_serviceService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult ServiceGet(int id)
		{
			var value = _serviceService.TGetByID(id);
			return Ok(_mapper.Map<GetServiceDto>(value));
		}
	}
}

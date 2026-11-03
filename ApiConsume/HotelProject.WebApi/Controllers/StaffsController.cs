using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.StaffDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffsController : ControllerBase
	{
		private readonly IStaffService _staffService;
		private readonly IMapper _mapper;

		public StaffsController(IStaffService staffService, IMapper mapper)
		{
			_staffService = staffService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			return Ok(_mapper.Map<List<ResultStaffDto>>(_staffService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult StaffAdd(CreateStaffDto createStaffDto)
		{
			var value = _mapper.Map<Staff>(createStaffDto);
			_staffService.TInsert(value);
			return Ok();
		}

		[HttpDelete]
		public IActionResult StaffDelete(int id)
		{
			_staffService.TDelete(_staffService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult StaffUpdate(UpdateStaffDto updateStaffDto)
		{
			var value = _mapper.Map<Staff>(updateStaffDto);
			_staffService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult StaffGet(int id)
		{
			var value = _staffService.TGetByID(id);
			return Ok(_mapper.Map<GetStaffDto>(value));
		}
	}
}

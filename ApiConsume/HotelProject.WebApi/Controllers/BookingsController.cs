using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.BookingDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingsController : ControllerBase
	{
		private readonly IBookingService _BookingService;
		private readonly IMapper _mapper;

		public BookingsController(IBookingService BookingService, IMapper mapper)
		{
			_BookingService = BookingService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult BookingList()
		{
			return Ok(_mapper.Map<List<ResultBookingDto>>(_BookingService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult BookingAdd(CreateBookingDto createBookingDto)
		{
			var value = _mapper.Map<Booking>(createBookingDto);
			_BookingService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult BookingDelete(int id)
		{
			_BookingService.TDelete(_BookingService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult BookingUpdate(UpdateBookingDto updateBookingDto)
		{
			var value = _mapper.Map<Booking>(updateBookingDto);
			_BookingService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult BookingGet(int id)
		{
			var value = _BookingService.TGetByID(id);
			return Ok(_mapper.Map<GetBookingDto>(value));
		}
	}
}

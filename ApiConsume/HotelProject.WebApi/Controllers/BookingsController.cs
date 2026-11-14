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
		private readonly IBookingService _bookingService;
		private readonly IMapper _mapper;

		public BookingsController(IBookingService BookingService, IMapper mapper)
		{
			_bookingService = BookingService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult BookingList()
		{
			return Ok(_mapper.Map<List<ResultBookingDto>>(_bookingService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult BookingAdd(CreateBookingDto createBookingDto)
		{
			var value = _mapper.Map<Booking>(createBookingDto);
			_bookingService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult BookingDelete(int id)
		{
			_bookingService.TDelete(_bookingService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult BookingUpdate(UpdateBookingDto updateBookingDto)
		{
			var value = _mapper.Map<Booking>(updateBookingDto);
			_bookingService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult BookingGet(int id)
		{
			var value = _bookingService.TGetByID(id);
			return Ok(_mapper.Map<GetBookingDto>(value));
		}

		[HttpGet("BookingStatusChange/{id}")]
		public IActionResult BookingStatusChange(int id)
		{
			_bookingService.TBookingStatusChange(id);
			return Ok();
		}
	}
}

using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.RoomDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomsController : ControllerBase
	{
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;

		public RoomsController(IRoomService roomService, IMapper mapper)
		{
			_roomService = roomService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult RoomList()
		{
			return Ok(_mapper.Map<List<ResultRoomDto>>(_roomService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult RoomAdd(CreateRoomDto createRoomDto)
		{
			var value = _mapper.Map<Room>(createRoomDto);
			_roomService.TInsert(value);
			return Ok();
		}

		[HttpDelete]
		public IActionResult RoomDelete(int id)
		{
			_roomService.TDelete(_roomService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult RoomUpdate(UpdateRoomDto updateRoomDto)
		{
			var value = _mapper.Map<Room>(updateRoomDto);
			_roomService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult RoomGet(int id)
		{
			var value = _roomService.TGetByID(id);
			return Ok(_mapper.Map<GetRoomDto>(value));
		}
	}
}

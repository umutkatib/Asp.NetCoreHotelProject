using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.MessageDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessagesController : ControllerBase
	{
		private readonly IMessageService _messageService;
		private readonly IMapper _mapper;

		public MessagesController(IMessageService MessageService, IMapper mapper)
		{
			_messageService = MessageService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult MessageList()
		{
			return Ok(_mapper.Map<List<ResultMessageDto>>(_messageService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult MessageAdd(CreateMessageDto createMessageDto)
		{
			var value = _mapper.Map<Message>(createMessageDto);
			_messageService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult MessageDelete(int id)
		{
			_messageService.TDelete(_messageService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult MessageUpdate(UpdateMessageDto updateMessageDto)
		{
			var value = _mapper.Map<Message>(updateMessageDto);
			_messageService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult MessageGet(int id)
		{
			var value = _messageService.TGetByID(id);
			return Ok(_mapper.Map<GetMessageDto>(value));
		}
	}
}

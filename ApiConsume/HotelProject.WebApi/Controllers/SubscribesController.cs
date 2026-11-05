using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.SubscribeDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribesController : ControllerBase
	{
		private readonly ISubscribeService _subscribeService;
		private readonly IMapper _mapper;

		public SubscribesController(ISubscribeService subscribeService, IMapper mapper)
		{
			_subscribeService = subscribeService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult SubscribeList()
		{
			return Ok(_mapper.Map<List<ResultSubscribeDto>>(_subscribeService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult SubscribeAdd(CreateSubscribeDto createSubscribeDto)
		{
			var value = _mapper.Map<Subscribe>(createSubscribeDto);
			_subscribeService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult SubscribeDelete(int id)
		{
			_subscribeService.TDelete(_subscribeService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult SubscribeUpdate(UpdateSubscribeDto updateSubscribeDto)
		{
			var value = _mapper.Map<Subscribe>(updateSubscribeDto);
			_subscribeService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult SubscribeGet(int id)
		{
			var value = _subscribeService.TGetByID(id);
			return Ok(_mapper.Map<GetSubscribeDto>(value));
		}
	}
}

using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.ContactDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController : ControllerBase
	{
		private readonly IContactService _contactService;
		private readonly IMapper _mapper;

		public ContactsController(IContactService contactService, IMapper mapper)
		{
			_contactService = contactService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ContactList()
		{
			return Ok(_mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult ContactAdd(CreateContactDto createContactDto)
		{
			var value = _mapper.Map<Contact>(createContactDto);
			_contactService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult ContactDelete(int id)
		{
			_contactService.TDelete(_contactService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult ContactUpdate(UpdateContactDto updateContactDto)
		{
			var value = _mapper.Map<Contact>(updateContactDto);
			_contactService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult ContactGet(int id)
		{
			var value = _contactService.TGetByID(id);
			return Ok(_mapper.Map<GetContactDto>(value));
		}
	}
}

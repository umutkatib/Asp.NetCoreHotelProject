using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.ServiceDtos;
using HotelProject.DtoLayer.TestimonialDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialsController : ControllerBase
	{

		private readonly ITestimonialService _testimonialService;
		private readonly IMapper _mapper;

		public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
		{
			_testimonialService = testimonialService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult TestimonialList()
		{
			return Ok(_mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll()));
		}

		[HttpPost]
		public IActionResult TestimonialAdd(CreateTestimonialDto createTestimonialDto)
		{
			var value = _mapper.Map<Testimonial>(createTestimonialDto);
			_testimonialService.TInsert(value);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult TestimonialDelete(int id)
		{
			_testimonialService.TDelete(_testimonialService.TGetByID(id));
			return Ok();
		}

		[HttpPut]
		public IActionResult TestimonialUpdate(UpdateTestimonialDto updateTestimonialDto)
		{
			var value = _mapper.Map<Testimonial>(updateTestimonialDto);
			_testimonialService.TUpdate(value);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult TestimonialGet(int id)
		{
			var value = _testimonialService.TGetByID(id);
			return Ok(_mapper.Map<GetTestimonialDto>(value));
		}
	}
}

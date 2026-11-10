using AutoMapper;
using HotelProject.DtoLayer.AboutDtos;
using HotelProject.DtoLayer.RoomDtos;
using HotelProject.DtoLayer.ServiceDtos;
using HotelProject.DtoLayer.StaffDtos;
using HotelProject.DtoLayer.SubscribeDtos;
using HotelProject.DtoLayer.TestimonialDto;
using HotelProject.DtoLayer.TrailerDtos;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<Staff, ResultStaffDto>().ReverseMap();
			CreateMap<Staff, CreateStaffDto>().ReverseMap();
			CreateMap<Staff, UpdateStaffDto>().ReverseMap();
			CreateMap<Staff, GetStaffDto>().ReverseMap();

			//

			CreateMap<Room, ResultRoomDto>().ReverseMap();
			CreateMap<Room, CreateRoomDto>().ReverseMap();
			CreateMap<Room, UpdateRoomDto>().ReverseMap();
			CreateMap<Room, GetRoomDto>().ReverseMap();
			
			//

			CreateMap<Service, ResultServiceDto>().ReverseMap();
			CreateMap<Service, CreateServiceDto>().ReverseMap();
			CreateMap<Service, UpdateServiceDto>().ReverseMap();
			CreateMap<Service, GetServiceDto>().ReverseMap();

			//

			CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();

			//

			CreateMap<Subscribe, ResultSubscribeDto>().ReverseMap();
			CreateMap<Subscribe, CreateSubscribeDto>().ReverseMap();
			CreateMap<Subscribe, UpdateSubscribeDto>().ReverseMap();
			CreateMap<Subscribe, GetSubscribeDto>().ReverseMap();

			//

			CreateMap<About, ResultAboutDto>().ReverseMap();
			CreateMap<About, CreateAboutDto>().ReverseMap();
			CreateMap<About, UpdateAboutDto>().ReverseMap();
			CreateMap<About, GetAboutDto>().ReverseMap();

			//

			CreateMap<Trailer, ResultTrailerDto>().ReverseMap();
			CreateMap<Trailer, CreateTrailerDto>().ReverseMap();
			CreateMap<Trailer, UpdateTrailerDto>().ReverseMap();
			CreateMap<Trailer, GetTrailerDto>().ReverseMap();
		}
	}
}

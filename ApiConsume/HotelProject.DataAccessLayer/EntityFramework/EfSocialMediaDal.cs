using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
	{
		public EfSocialMediaDal(HotelProjectContext context) : base(context)
		{
		}
	}
}

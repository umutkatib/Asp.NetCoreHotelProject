using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfTrailerDal : GenericRepository<Trailer>, ITrailerDal
	{
		public EfTrailerDal(HotelProjectContext context) : base(context)
		{
		}
	}
}

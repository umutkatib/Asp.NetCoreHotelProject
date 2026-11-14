using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(HotelProjectContext context) : base(context)
		{
		}

		public void BookingStatusChange(int id)
		{
			using var context = new HotelProjectContext();
			var value = context.Bookings.Find(id);
			value.BookingStatus = !value.BookingStatus;
			context.SaveChanges();
		}
	}
}

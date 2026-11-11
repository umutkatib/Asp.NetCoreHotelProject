using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
	public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingManager(IBookingDal bookingDal)
		{
			_bookingDal = bookingDal;
		}

		public void TDelete(Booking entity)
		{
			_bookingDal.Delete(entity);
		}

		public Booking TGetByID(int id)
		{
			return _bookingDal.GetByID(id);
		}

		public List<Booking> TGetListAll()
		{
			return _bookingDal.GetListAll();
		}

		public void TInsert(Booking entity)
		{
			_bookingDal.Insert(entity);
		}

		public void TUpdate(Booking entity)
		{
			_bookingDal.Update(entity);
		}
	}
}

using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public void TDelete(Staff entity)
		{
			_staffDal.Delete(entity);
		}

		public Staff TGetByID(int id)
		{
			return _staffDal.GetByID(id);
		}

		public List<Staff> TGetListAll()
		{
			return _staffDal.GetListAll();
		}

		public void TInsert(Staff entity)
		{
			_staffDal.Insert(entity);
		}

		public void TUpdate(Staff entity)
		{
			_staffDal.Update(entity);
		}
	}
}

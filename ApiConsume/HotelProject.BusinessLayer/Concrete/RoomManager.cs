using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
	public class RoomManager : IRoomService
	{
		private readonly IRoomDal _roomDal;

		public RoomManager(IRoomDal roomDal)
		{
			_roomDal = roomDal;
		}

		public void TDelete(Room entity)
		{
			_roomDal.Delete(entity);
		}

		public Room TGetByID(int id)
		{
			return _roomDal.GetByID(id);
		}

		public List<Room> TGetListAll()
		{
			return _roomDal.GetListAll();
		}

		public void TInsert(Room entity)
		{
			_roomDal.Insert(entity);
		}

		public void TUpdate(Room entity)
		{
			_roomDal.Update(entity);
		}
	}
}

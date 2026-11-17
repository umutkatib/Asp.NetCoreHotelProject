using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfRoomDal : GenericRepository<Room>, IRoomDal
	{
		public EfRoomDal(HotelProjectContext context) : base(context)
		{
		}

		public List<Room> RoomListForDefault()
		{
			using var context = new HotelProjectContext();
			return context.Rooms.OrderBy(x => x.RoomID).Take(6).ToList();
		}
	}
}

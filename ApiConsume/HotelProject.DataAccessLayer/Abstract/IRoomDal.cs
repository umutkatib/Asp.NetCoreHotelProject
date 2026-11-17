using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IRoomDal : IGenericDal<Room>
	{
		List<Room> RoomListForDefault();
	}
}

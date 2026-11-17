using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Abstract
{
	public interface IRoomService : IGenericService<Room>
	{
		List<Room> RoomListForDefault();
	}
}

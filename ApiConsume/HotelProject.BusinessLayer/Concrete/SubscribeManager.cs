using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal sbscribeDal)
		{
			_subscribeDal = sbscribeDal;
		}

		public void TDelete(Subscribe entity)
		{
			_subscribeDal.Delete(entity);
		}

		public Subscribe TGetByID(int id)
		{
			return _subscribeDal.GetByID(id);
		}

		public List<Subscribe> TGetListAll()
		{
			return _subscribeDal.GetListAll();
		}

		public void TInsert(Subscribe entity)
		{
			_subscribeDal.Insert(entity);
		}

		public void TUpdate(Subscribe entity)
		{
			_subscribeDal.Update(entity);
		}
	}
}

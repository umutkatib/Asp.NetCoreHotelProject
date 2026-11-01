using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void TDelete(Service entity)
		{
			_serviceDal.Delete(entity);
		}

		public Service TGetByID(int id)
		{
			return _serviceDal.GetByID(id);
		}

		public List<Service> TGetListAll()
		{
			return _serviceDal.GetListAll();
		}

		public void TInsert(Service entity)
		{
			_serviceDal.Insert(entity);
		}

		public void TUpdate(Service entity)
		{
			_serviceDal.Update(entity);
		}
	}
}

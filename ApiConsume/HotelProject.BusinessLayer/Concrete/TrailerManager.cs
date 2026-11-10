using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
	public class TrailerManager : ITrailerService
	{
		private readonly ITrailerDal _trailerDal;

		public TrailerManager(ITrailerDal trailerDal)
		{
			_trailerDal = trailerDal;
		}

		public void TDelete(Trailer entity)
		{
			_trailerDal.Delete(entity);
		}

		public Trailer TGetByID(int id)
		{
			return _trailerDal.GetByID(id);
		}

		public List<Trailer> TGetListAll()
		{
			return _trailerDal.GetListAll();
		}

		public void TInsert(Trailer entity)
		{
			_trailerDal.Insert(entity);
		}

		public void TUpdate(Trailer entity)
		{
			_trailerDal.Update(entity);
		}
	}
}

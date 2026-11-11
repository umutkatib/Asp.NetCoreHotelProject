using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
	public class SocialMediaManager : ISocialMediaService
	{
		private readonly ISocialMediaDal _socialMediaDal;

		public SocialMediaManager(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public void TDelete(SocialMedia entity)
		{
			_socialMediaDal.Delete(entity);
		}

		public SocialMedia TGetByID(int id)
		{
			return _socialMediaDal.GetByID(id);
		}

		public List<SocialMedia> TGetListAll()
		{
			return _socialMediaDal.GetListAll();
		}

		public void TInsert(SocialMedia entity)
		{
			_socialMediaDal.Insert(entity);
		}

		public void TUpdate(SocialMedia entity)
		{
			_socialMediaDal.Update(entity);
		}
	}
}

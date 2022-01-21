using MyWebsite.Business.Abstract;
using MyWebsite.Core.Aspects.Autofac.Caching;
using MyWebsite.DataAccess.Abstract;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        [CacheRemoveAspect("IAnnouncementService.Get")]
        public void Add(Announcement announcement)
        {
            _announcementDal.Add(announcement);
        }

        [CacheRemoveAspect("IAnnouncementService.Get")]
        public void Delete(Announcement announcement)
        {
            _announcementDal.Delete(announcement);
        }

        [CacheAspect]
        public Announcement Get(Expression<Func<Announcement, bool>> filter)
        {
           return _announcementDal.Get(filter);
        }

        [CacheAspect]
        public List<Announcement> GetAll(Expression<Func<Announcement, bool>> filter = null)
        {
           return _announcementDal.GetAll(filter);
        }

        [CacheAspect]
        public List<Announcement> GetAllByNonDeleted(Expression<Func<Announcement, bool>> filter = null)
        {
            return _announcementDal.GetAll(x => !x.IsDeleted);
        }

        [CacheRemoveAspect("IAnnouncementService.Get")]
        public void Update(Announcement announcement)
        {
            _announcementDal.Update(announcement);
        }
    }
}

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
    public class VideoManager : IVideoService
    {

        IVideoDal _videoDal;

        public VideoManager(IVideoDal videoDal)
        {
            _videoDal = videoDal;
        }

        [CacheRemoveAspect("IVideoService.Get")]
        public void Add(Video video)
        {
            _videoDal.Add(video);
        }

        [CacheRemoveAspect("IVideoService.Get")]
        public void Delete(Video video)
        {
            _videoDal.Delete(video);
        }

        [CacheAspect]
        public Video Get(Expression<Func<Video, bool>> filter)
        {
            return _videoDal.Get(filter);
        }

        [CacheAspect]
        public List<Video> GetAll(Expression<Func<Video, bool>> filter = null)
        {
           return _videoDal.GetAll(filter);
        }

        public List<Video> GetAllByNonDeleted(Expression<Func<Video, bool>> filter = null)
        {
            return _videoDal.GetAll(x => !x.IsDeleted);
        }

        [CacheRemoveAspect("IVideoService.Get")]
        public void Update(Video video)
        {
            _videoDal.Update(video);
        }
    }
}

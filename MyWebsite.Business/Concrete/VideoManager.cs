using MyWebsite.Business.Abstract;
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

        public void Add(Video video)
        {
            _videoDal.Add(video);
        }

        public void Delete(Video video)
        {
            _videoDal.Delete(video);
        }

        public Video Get(Expression<Func<Video, bool>> filter)
        {
            return _videoDal.Get(filter);
        }

        public List<Video> GetAll(Expression<Func<Video, bool>> filter = null)
        {
           return _videoDal.GetAll(filter);
        }

        public void Update(Video video)
        {
            _videoDal.Update(video);
        }
    }
}

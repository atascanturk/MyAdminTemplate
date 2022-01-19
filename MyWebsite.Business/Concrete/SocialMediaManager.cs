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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Add(SocialMedia socialMedia)
        {
            _socialMediaDal.Add(socialMedia);
        }

        public void Delete(SocialMedia socialMedia)
        {
            _socialMediaDal.Delete(socialMedia);
        }

        public SocialMedia Get(Expression<Func<SocialMedia, bool>> filter)
        {
            return _socialMediaDal.Get(filter);
        }

        public List<SocialMedia> GetAll(Expression<Func<SocialMedia, bool>> filter = null)
        {
            return _socialMediaDal.GetAll(filter);
        }

        public void Update(SocialMedia socialMedia)
        {
            _socialMediaDal.Update(socialMedia);
        }
    }
}

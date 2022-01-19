using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
   public interface ISocialMediaService
    {
        List<SocialMedia> GetAll(Expression<Func<SocialMedia, bool>> filter = null);
        SocialMedia Get(Expression<Func<SocialMedia, bool>> filter);
        void Add(SocialMedia socialMedia);
        void Update(SocialMedia socialMedia);
        void Delete(SocialMedia socialMedia);
    }
}

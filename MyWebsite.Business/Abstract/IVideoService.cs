using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IVideoService
    {
        List<Video> GetAll(Expression<Func<Video, bool>> filter = null);
        Video Get(Expression<Func<Video, bool>> filter);
        void Add(Video video);
        void Update(Video video);
        void Delete(Video video);
    }
}

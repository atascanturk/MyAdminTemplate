using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface INewsService
    {
        List<News> GetAll(Expression<Func<News, bool>> filter = null);
        List<News> GetAllByNonDeletedAndActive(Expression<Func<News, bool>> filter = null);
        List<News> GetAllByNonDeleted(Expression<Func<News, bool>> filter = null);
        News Get(Expression<Func<News, bool>> filter);
        void Add(News news);
        void Update(News news);
        void Delete(News news);
    }
}

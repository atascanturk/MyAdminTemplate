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
    public class NewsManager : INewsService
    {
        INewsDal _newsDal;

        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        [CacheRemoveAspect("INewsService.Get")]
        public void Add(News news)
        {
            _newsDal.Add(news);
        }

        [CacheRemoveAspect("INewsService.Get")]
        public void Delete(News news)
        {
            _newsDal.Delete(news);
        }

       
        public News Get(Expression<Func<News, bool>> filter)
        {
           return _newsDal.Get(filter);
        }

       
        public News GetByIdNonDeletedAndActive(int id, Expression<Func<News, bool>> filter = null)
        {
            return _newsDal.Get((x => x.IsActive & !x.IsDeleted & x.Id== id));
        }

        [CacheAspect]
        public List<News> GetAll(Expression<Func<News, bool>> filter = null)
        {
           return _newsDal.GetAll(filter);
        }

        [CacheAspect]
        public List<News> GetAllByNonDeleted(Expression<Func<News, bool>> filter = null)
        {
            return _newsDal.GetAll(x => !x.IsDeleted, x => x.Category);
        }

        [CacheAspect]
        public List<News> GetAllByNonDeletedAndActive(Expression<Func<News, bool>> filter = null)
        {
            return _newsDal.GetAll((x => x.IsActive & !x.IsDeleted));
        }

        [CacheRemoveAspect("INewsService.Get")]
        public void Update(News news)
        {
            _newsDal.Update(news);
        }
    }
}

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
    public class SeoManager : ISeoService
    {
        ISeoDal _seoDal;

        public SeoManager(ISeoDal seoDal)
        {
            _seoDal = seoDal;
        }

        [CacheRemoveAspect("ISeoService.Get")]
        public void Add(Seo seo)
        {
            _seoDal.Add(seo);
        }

        [CacheAspect]
        public Seo Get(Expression<Func<Seo, bool>> filter)
        {
            return _seoDal.Get(filter);
        }

        [CacheRemoveAspect("ISeoService.Get")]
        public void Update(Seo seo)
        {
            _seoDal.Update(seo);
        }
    }
}

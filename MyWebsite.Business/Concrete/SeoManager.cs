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
    public class SeoManager : ISeoService
    {
        ISeoDal _seoDal;

        public SeoManager(ISeoDal seoDal)
        {
            _seoDal = seoDal;
        }

        public void Add(Seo seo)
        {
            _seoDal.Add(seo);
        }

        public Seo Get(Expression<Func<Seo, bool>> filter)
        {
            return _seoDal.Get(filter);
        }

        public void Update(Seo seo)
        {
            _seoDal.Update(seo);
        }
    }
}

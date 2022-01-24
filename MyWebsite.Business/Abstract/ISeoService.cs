using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface ISeoService
    {
        Seo Get(Expression<Func<Seo, bool>> filter);
        void Add(Seo seo);
        void Update(Seo seo);
    }
}

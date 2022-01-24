using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IVisitorCountService
    {
        List<VisitorCount> GetAll(Expression<Func<VisitorCount, bool>> filter = null);
        VisitorCount Get(Expression<Func<VisitorCount, bool>> filter);
        void Add(VisitorCount visitorCount);
        void Update(VisitorCount visitorCount);
    }
}

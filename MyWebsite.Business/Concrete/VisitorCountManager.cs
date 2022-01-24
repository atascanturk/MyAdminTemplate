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
    public class VisitorCountManager : IVisitorCountService
    {
        IVisitorCountDal _visitorCountDal;

        public VisitorCountManager(IVisitorCountDal visitorCountDal)
        {
            _visitorCountDal = visitorCountDal;
        }

        public void Add(VisitorCount visitorCount)
        {
            _visitorCountDal.Add(visitorCount);
        }

        public VisitorCount Get(Expression<Func<VisitorCount, bool>> filter)
        {
            return _visitorCountDal.Get(filter);
        }

        public List<VisitorCount> GetAll(Expression<Func<VisitorCount, bool>> filter = null)
        {
            return _visitorCountDal.GetAll(filter);
        }

        public void Update(VisitorCount visitorCount)
        {
            _visitorCountDal.Update(visitorCount);
        }
    }
}

using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IBulletinService
    {       
        List<Bulletin> GetAllByNonDeleted(Expression<Func<Bulletin, bool>> filter = null);
        Bulletin Get(Expression<Func<Bulletin, bool>> filter);
        void Add(Bulletin bulletin);
        void Update(Bulletin bulletin);       
        void Delete(Bulletin bulletin);
    }
}

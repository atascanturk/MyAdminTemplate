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
    public class BulletinManager : IBulletinService
    {
        IBulletinDal _bulletinDal;

        public BulletinManager(IBulletinDal bulletinDal)
        {
            _bulletinDal = bulletinDal;
        }

        public void Add(Bulletin bulletin)
        {
            _bulletinDal.Add(bulletin);
        }

        public void Delete(Bulletin bulletin)
        {
            _bulletinDal.Delete(bulletin);
        }

        public Bulletin Get(Expression<Func<Bulletin, bool>> filter)
        {
            return _bulletinDal.Get(filter);
        }

        public List<Bulletin> GetAllByNonDeleted(Expression<Func<Bulletin, bool>> filter = null)
        {
            return _bulletinDal.GetAll(x=>!x.IsDeleted);
        }

        public void Update(Bulletin bulletin)
        {
            _bulletinDal.Update(bulletin);
        }
    }
}

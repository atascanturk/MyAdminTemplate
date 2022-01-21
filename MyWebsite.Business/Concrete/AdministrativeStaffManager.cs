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
    public class AdministrativeStaffManager : IAdministrativeStaffService
    {
        IAdministrativeStaffDal _administrativeStaffDal;

        public AdministrativeStaffManager(IAdministrativeStaffDal administrativeStaffDal)
        {
            _administrativeStaffDal = administrativeStaffDal;
        }

        public void Add(AdministrativeStaff administrativeStaff)
        {
            _administrativeStaffDal.Add(administrativeStaff);
        }

        public void Delete(AdministrativeStaff administrativeStaff)
        {
            _administrativeStaffDal.Delete(administrativeStaff);
        }

        public AdministrativeStaff Get(Expression<Func<AdministrativeStaff, bool>> filter)
        {
            return _administrativeStaffDal.Get(filter);
        }

        public List<AdministrativeStaff> GetAll(Expression<Func<AdministrativeStaff, bool>> filter = null)
        {
            return _administrativeStaffDal.GetAll(filter);
        }

        public List<AdministrativeStaff> GetAllByNonDeleted(Expression<Func<AdministrativeStaff, bool>> filter = null)
        {
            return _administrativeStaffDal.GetAll(x => !x.IsDeleted);
        }

        public void Update(AdministrativeStaff administrativeStaff)
        {
            _administrativeStaffDal.Update(administrativeStaff);
        }
    }
}

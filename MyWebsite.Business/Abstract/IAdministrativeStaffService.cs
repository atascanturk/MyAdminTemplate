using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IAdministrativeStaffService
    {
        List<AdministrativeStaff> GetAll(Expression<Func<AdministrativeStaff, bool>> filter = null);
        List<AdministrativeStaff> GetAllByNonDeleted(Expression<Func<AdministrativeStaff, bool>> filter = null);
        AdministrativeStaff Get(Expression<Func<AdministrativeStaff, bool>> filter);
        void Add(AdministrativeStaff administrativeStaff);
        void Update(AdministrativeStaff administrativeStaff);
        void Delete(AdministrativeStaff administrativeStaff);
    }
}

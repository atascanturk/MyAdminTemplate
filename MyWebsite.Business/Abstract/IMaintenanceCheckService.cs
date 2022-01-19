using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IMaintenanceCheckService
    {
        void Update(MaintenanceCheck maintenanceCheck);
        MaintenanceCheck Get(Expression<Func<MaintenanceCheck, bool>> filter);
    }
}

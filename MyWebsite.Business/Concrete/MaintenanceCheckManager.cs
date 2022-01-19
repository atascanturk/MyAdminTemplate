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
    public class MaintenanceCheckManager : IMaintenanceCheckService
    {
        IMaintenanceCheckDal _maintenanceCheckDal;

        public MaintenanceCheckManager(IMaintenanceCheckDal maintenanceCheckDal)
        {
            _maintenanceCheckDal = maintenanceCheckDal;
        }

        [CacheAspect]
        public MaintenanceCheck Get(Expression<Func<MaintenanceCheck, bool>> filter)
        {
           return _maintenanceCheckDal.Get(filter);
        }

        [CacheRemoveAspect("IMaintenanceCheck.Get")]
        public void Update(MaintenanceCheck maintenanceCheck)
        {
            _maintenanceCheckDal.Update(maintenanceCheck);
        }
    }
}
